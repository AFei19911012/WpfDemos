// Copyright (c) 2019-2021 Jonathan Wood (www.softcircuits.com)
// Licensed under the MIT license.
//
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace SoftCircuits.EasyEncryption
{
    /// <summary>
    /// Encryption algorithm types.
    /// </summary>
    public enum EncryptionAlgorithm
    {
        /// <summary>
        /// Specifies the Advanced Encryption Standard (AES) symmetric encryption algorithm.
        /// </summary>
        Aes,

        /// <summary>
        /// Specifies the Data Encryption Standard (DES) symmetric encryption algorithm.
        /// </summary>
        Des,

        /// <summary>
        /// Specifies the RC2 symmetric encryption algorithm.
        /// </summary>
        Rc2,

        /// <summary>
        /// Specifies the Rijndael symmetric encryption algorithm.
        /// </summary>
        Rijndael,

        /// <summary>
        /// Specifies the TripleDES symmetric encryption algorithm.
        /// </summary>
        TripleDes
    }

    /// <summary>
    /// Class to provide encryption and decryption services.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The Encryption class performs encryption and decryption using the specified algorithm.
    /// </para>
    /// <para>
    /// The encrypted values may appear considerably larger than the decrypted values
    /// because encrypted values contains some additional meta data. If either data size or
    /// performance is a concern, use the <see cref="CreateStreamReader(Stream)"/> or
    /// <see cref="CreateStreamWriter(Stream)"/> methods to work with the streaming classes
    /// instead.
    /// </para>
    /// </remarks>
    public class Encryption
    {
        private static readonly int SaltLength = 8;

        private static readonly Dictionary<EncryptionAlgorithm, Type> AlgorithmLookup = new Dictionary<EncryptionAlgorithm, Type>
        {
            [EncryptionAlgorithm.Aes] = typeof(Aes),
            [EncryptionAlgorithm.Des] = typeof(DES),
            [EncryptionAlgorithm.Rc2] = typeof(RC2),
            [EncryptionAlgorithm.Rijndael] = typeof(Rijndael),
            [EncryptionAlgorithm.TripleDes] = typeof(TripleDES),
        };

        private string Password { get; }
        private Type AlgorithmType { get; }

        /// <summary>
        /// Converts a byte array to a string.
        /// </summary>
        /// <param name="bytes">The byte array to be converted.</param>
        /// <returns>Returns the converted string.</returns>
        public static string EncodeBytesToString(byte[] bytes) => Convert.ToBase64String(bytes);

        /// <summary>
        /// Converts a string to a byte array.
        /// </summary>
        /// <param name="s">The string to be converted.</param>
        /// <returns>Returns the converted byte array.</returns>
        public static byte[] DecodeBytesFromString(string s) => Convert.FromBase64String(s);

        /// <summary>
        /// Constructs a new <c>Encryption</c> instance.
        /// </summary>
        /// <param name="password">Specifies the encryption password. Leading and trailing spaces are removed.</param>
        /// <param name="algorithm">Specifies which encryption algorithm is used.</param>
        public Encryption(string password, EncryptionAlgorithm algorithm)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Password is required.", nameof(password));
            Password = password.Trim();
            AlgorithmType = AlgorithmLookup[algorithm];
        }

        #region Encryption stream creation methods

        /// <summary>
        /// Creates an <see cref="EncryptionWriter"/> instance using the specified stream.
        /// </summary>
        /// <remarks>
        /// The <see cref="EncryptionWriter"/> class is the preferred method to encrypt data
        /// as it will store some necessary meta data only once for all data in the stream.
        /// It is also more performant. The other encryption methods defer to the EncryptionWriter
        /// class for actual encryption.
        /// </remarks>
        /// <param name="stream">The stream the encrypted data will be written to.</param>
        /// <returns>An instance of the <see cref="EncryptionWriter"/> class.</returns>
        public EncryptionWriter CreateStreamWriter(Stream stream)
        {
            // Create a random salt and write to stream
            byte[] salt = CreateSalt();
            stream.Write(salt, 0, salt.Length);
            // Create symmetric algorithm
            SymmetricAlgorithm algorithm = CreateAlgorithm();
            algorithm.Padding = PaddingMode.PKCS7;
            // Create key and IV
            byte[] key, iv;
            GenerateKeyAndIv(algorithm, salt, out key, out iv);
            // Create EncryptionWriter
            ICryptoTransform encryptor = algorithm.CreateEncryptor(key, iv);
            CryptoStream cs = new CryptoStream(stream, encryptor, CryptoStreamMode.Write);
            return new EncryptionWriter(algorithm, encryptor, stream);
        }

        /// <summary>
        /// Creates an <see cref="EncryptionWriter"/> instance using the specified file name.
        /// </summary>
        /// <remarks>
        /// The <see cref="EncryptionWriter"/> class is the preferred method to encrypt data
        /// as it will store some necessary meta data only once for all data in the stream.
        /// It is also more performant. The other encryption methods defer to the EncryptionWriter
        /// class for actual encryption.
        /// </remarks>
        /// <param name="path">The file name the encrypted data will be written to.</param>
        /// <returns>An instance of the <see cref="EncryptionWriter"/> class.</returns>
        public EncryptionWriter CreateStreamWriter(string path)
        {
            return CreateStreamWriter(File.Open(path, FileMode.OpenOrCreate, FileAccess.Write));
        }

        /// <summary>
        /// Creates an <see cref="EncryptionReader"/> instance using the specified stream.
        /// </summary>
        /// <remarks>
        /// The <see cref="EncryptionReader"/> class is the preferred method to decrypt data.
        /// It is also more performant. The other decryption methods defer to the EncryptionReader
        /// class for actual decryption.
        /// </remarks>
        /// <param name="stream">The stream the encrypted data will be read from.</param>
        /// <returns>An instance of the <see cref="EncryptionReader"/> class.</returns>
        public EncryptionReader CreateStreamReader(Stream stream)
        {
            // Read salt from input stream
            byte[] salt = new byte[SaltLength];
            if (stream.Read(salt, 0, salt.Length) < SaltLength)
                throw new ArgumentOutOfRangeException("Reached end of input stream before reading encryption metadata.");
            // Create symmetric algorithm
            SymmetricAlgorithm algorithm = CreateAlgorithm();
            algorithm.Padding = PaddingMode.PKCS7;
            // Create key and IV
            byte[] key, iv;
            GenerateKeyAndIv(algorithm, salt, out key, out iv);
            // Create EncryptionReader
            ICryptoTransform decryptor = algorithm.CreateDecryptor(key, iv);
            CryptoStream cs = new CryptoStream(stream, decryptor, CryptoStreamMode.Read);
            return new EncryptionReader(algorithm, decryptor, stream);
        }

        /// <summary>
        /// Creates an <see cref="EncryptionReader"/> instance using the specified file name.
        /// </summary>
        /// <remarks>
        /// The <see cref="EncryptionReader"/> class is the preferred method to decrypt data.
        /// It is also more performant. The other decryption methods defer to the EncryptionReader
        /// class for actual decryption.
        /// </remarks>
        /// <param name="path">The file name the encrypted data will be read from.</param>
        /// <returns>An instance of the <see cref="EncryptionReader"/> class.</returns>
        public EncryptionReader CreateStreamReader(string path)
        {
            return CreateStreamReader(File.Open(path, FileMode.Open, FileAccess.Read));
        }

        #endregion

        #region Encryption

        /// <summary>
        /// Encrypts a <c>string</c> value.
        /// </summary>
        /// <remarks>
        /// The encrypted value will be larger than the unencrypted value because the
        /// encrypted value will contain some additional meta data. To minimize the
        /// size of this meta data when encrypting multiple values, use <see cref="CreateStreamWriter(Stream)"/>
        /// to create a <see cref="EncryptionWriter"/> instead.
        /// </remarks>
        /// <param name="value">The value to decrypt.</param>
        /// <returns>Returns the encrypted value</returns>
        public string Encrypt(String value) => Encrypt(w => w.Write(value ?? String.Empty));

        /// <summary>
        /// Encrypts a <c>bool</c> value.
        /// </summary>
        /// <remarks>
        /// The encrypted value will be larger than the unencrypted value because the
        /// encrypted value will contain some additional meta data. To minimize the
        /// size of this meta data when encrypting multiple values, use <see cref="CreateStreamWriter(Stream)"/>
        /// to create a <see cref="EncryptionWriter"/> instead.
        /// </remarks>
        /// <param name="value">The value to decrypt.</param>
        /// <returns>Returns the encrypted value</returns>
        public string Encrypt(Boolean value) => Encrypt(w => w.Write(value));

        /// <summary>
        /// Encrypts a <c>char</c> value.
        /// </summary>
        /// <remarks>
        /// The encrypted value will be larger than the unencrypted value because the
        /// encrypted value will contain some additional meta data. To minimize the
        /// size of this meta data when encrypting multiple values, use <see cref="CreateStreamWriter(Stream)"/>
        /// to create a <see cref="EncryptionWriter"/> instead.
        /// </remarks>
        /// <param name="value">The value to decrypt.</param>
        /// <returns>Returns the encrypted value</returns>
        public string Encrypt(Char value) => Encrypt(w => w.Write(value));

        /// <summary>
        /// Encrypts a <c>sbyte</c> value.
        /// </summary>
        /// <remarks>
        /// The encrypted value will be larger than the unencrypted value because the
        /// encrypted value will contain some additional meta data. To minimize the
        /// size of this meta data when encrypting multiple values, use <see cref="CreateStreamWriter(Stream)"/>
        /// to create a <see cref="EncryptionWriter"/> instead.
        /// </remarks>
        /// <param name="value">The value to decrypt.</param>
        /// <returns>Returns the encrypted value</returns>
        public string Encrypt(SByte value) => Encrypt(w => w.Write(value));

        /// <summary>
        /// Encrypts a <c>byte</c> value.
        /// </summary>
        /// <remarks>
        /// The encrypted value will be larger than the unencrypted value because the
        /// encrypted value will contain some additional meta data. To minimize the
        /// size of this meta data when encrypting multiple values, use <see cref="CreateStreamWriter(Stream)"/>
        /// to create a <see cref="EncryptionWriter"/> instead.
        /// </remarks>
        /// <param name="value">The value to decrypt.</param>
        /// <returns>Returns the encrypted value</returns>
        public string Encrypt(Byte value) => Encrypt(w => w.Write(value));

        /// <summary>
        /// Encrypts a <c>short</c> value.
        /// </summary>
        /// <remarks>
        /// The encrypted value will be larger than the unencrypted value because the
        /// encrypted value will contain some additional meta data. To minimize the
        /// size of this meta data when encrypting multiple values, use <see cref="CreateStreamWriter(Stream)"/>
        /// to create a <see cref="EncryptionWriter"/> instead.
        /// </remarks>
        /// <param name="value">The value to decrypt.</param>
        /// <returns>Returns the encrypted value</returns>
        public string Encrypt(Int16 value) => Encrypt(w => w.Write(value));

        /// <summary>
        /// Encrypts a <c>ushort</c> value.
        /// </summary>
        /// <remarks>
        /// The encrypted value will be larger than the unencrypted value because the
        /// encrypted value will contain some additional meta data. To minimize the
        /// size of this meta data when encrypting multiple values, use <see cref="CreateStreamWriter(Stream)"/>
        /// to create a <see cref="EncryptionWriter"/> instead.
        /// </remarks>
        /// <param name="value">The value to decrypt.</param>
        /// <returns>Returns the encrypted value</returns>
        public string Encrypt(UInt16 value) => Encrypt(w => w.Write(value));

        /// <summary>
        /// Encrypts a <c>int</c> value.
        /// </summary>
        /// <remarks>
        /// The encrypted value will be larger than the unencrypted value because the
        /// encrypted value will contain some additional meta data. To minimize the
        /// size of this meta data when encrypting multiple values, use <see cref="CreateStreamWriter(Stream)"/>
        /// to create a <see cref="EncryptionWriter"/> instead.
        /// </remarks>
        /// <param name="value">The value to decrypt.</param>
        /// <returns>Returns the encrypted value</returns>
        public string Encrypt(Int32 value) => Encrypt(w => w.Write(value));

        /// <summary>
        /// Encrypts a <c>uint</c> value.
        /// </summary>
        /// <remarks>
        /// The encrypted value will be larger than the unencrypted value because the
        /// encrypted value will contain some additional meta data. To minimize the
        /// size of this meta data when encrypting multiple values, use <see cref="CreateStreamWriter(Stream)"/>
        /// to create a <see cref="EncryptionWriter"/> instead.
        /// </remarks>
        /// <param name="value">The value to decrypt.</param>
        /// <returns>Returns the encrypted value</returns>
        public string Encrypt(UInt32 value) => Encrypt(w => w.Write(value));

        /// <summary>
        /// Encrypts a <c>long</c> value.
        /// </summary>
        /// <remarks>
        /// The encrypted value will be larger than the unencrypted value because the
        /// encrypted value will contain some additional meta data. To minimize the
        /// size of this meta data when encrypting multiple values, use <see cref="CreateStreamWriter(Stream)"/>
        /// to create a <see cref="EncryptionWriter"/> instead.
        /// </remarks>
        /// <param name="value">The value to decrypt.</param>
        /// <returns>Returns the encrypted value</returns>
        public string Encrypt(Int64 value) => Encrypt(w => w.Write(value));

        /// <summary>
        /// Encrypts a <c>ulong</c> value.
        /// </summary>
        /// <remarks>
        /// The encrypted value will be larger than the unencrypted value because the
        /// encrypted value will contain some additional meta data. To minimize the
        /// size of this meta data when encrypting multiple values, use <see cref="CreateStreamWriter(Stream)"/>
        /// to create a <see cref="EncryptionWriter"/> instead.
        /// </remarks>
        /// <param name="value">The value to decrypt.</param>
        /// <returns>Returns the encrypted value</returns>
        public string Encrypt(UInt64 value) => Encrypt(w => w.Write(value));

        /// <summary>
        /// Encrypts a <c>float</c> value.
        /// </summary>
        /// <remarks>
        /// The encrypted value will be larger than the unencrypted value because the
        /// encrypted value will contain some additional meta data. To minimize the
        /// size of this meta data when encrypting multiple values, use <see cref="CreateStreamWriter(Stream)"/>
        /// to create a <see cref="EncryptionWriter"/> instead.
        /// </remarks>
        /// <param name="value">The value to decrypt.</param>
        /// <returns>Returns the encrypted value</returns>
        public string Encrypt(Single value) => Encrypt(w => w.Write(value));

        /// <summary>
        /// Encrypts a <c>double</c> value.
        /// </summary>
        /// <remarks>
        /// The encrypted value will be larger than the unencrypted value because the
        /// encrypted value will contain some additional meta data. To minimize the
        /// size of this meta data when encrypting multiple values, use <see cref="CreateStreamWriter(Stream)"/>
        /// to create a <see cref="EncryptionWriter"/> instead.
        /// </remarks>
        /// <param name="value">The value to decrypt.</param>
        /// <returns>Returns the encrypted value</returns>
        public string Encrypt(Double value) => Encrypt(w => w.Write(value));

        /// <summary>
        /// Encrypts a <c>decimal</c> value.
        /// </summary>
        /// <remarks>
        /// The encrypted value will be larger than the unencrypted value because the
        /// encrypted value will contain some additional meta data. To minimize the
        /// size of this meta data when encrypting multiple values, use <see cref="CreateStreamWriter(Stream)"/>
        /// to create a <see cref="EncryptionWriter"/> instead.
        /// </remarks>
        /// <param name="value">The value to decrypt.</param>
        /// <returns>Returns the encrypted value</returns>
        public string Encrypt(Decimal value) => Encrypt(w => w.Write(value));

        /// <summary>
        /// Encrypts a <c>DateTime</c> value.
        /// </summary>
        /// <remarks>
        /// The encrypted value will be larger than the unencrypted value because the
        /// encrypted value will contain some additional meta data. To minimize the
        /// size of this meta data when encrypting multiple values, use <see cref="CreateStreamWriter(Stream)"/>
        /// to create a <see cref="EncryptionWriter"/> instead.
        /// </remarks>
        /// <param name="value">The value to decrypt.</param>
        /// <returns>Returns the encrypted value</returns>
        public string Encrypt(DateTime value) => Encrypt(w => w.Write(value));

        /// <summary>
        /// Encrypts a <c>byte[]</c> value.
        /// </summary>
        /// <remarks>
        /// The encrypted value will be larger than the unencrypted value because the
        /// encrypted value will contain some additional meta data. To minimize the
        /// size of this meta data when encrypting multiple values, use <see cref="CreateStreamWriter(Stream)"/>
        /// to create a <see cref="EncryptionWriter"/> instead.
        /// </remarks>
        /// <param name="value">The value to decrypt.</param>
        /// <returns>Returns the encrypted value</returns>
        public string Encrypt(Byte[] value) => Encrypt(w => w.Write(value));

        /// <summary>
        /// Encrypts a <c>string[]</c> value.
        /// </summary>
        /// <remarks>
        /// The encrypted value will be larger than the unencrypted value because the
        /// encrypted value will contain some additional meta data. To minimize the
        /// size of this meta data when encrypting multiple values, use <see cref="CreateStreamWriter(Stream)"/>
        /// to create a <see cref="EncryptionWriter"/> instead.
        /// </remarks>
        /// <param name="value">The value to decrypt.</param>
        /// <returns>Returns the encrypted value</returns>
        public string Encrypt(String[] value) => Encrypt(w => w.Write(value));

        private string Encrypt(Action<EncryptionWriter> action)
        {
            using (MemoryStream stream = new MemoryStream())
            using (EncryptionWriter writer = CreateStreamWriter(stream))
            {
                action(writer);
                return EncodeBytesToString(stream.ToArray());
            }
        }

        #endregion

        #region Decryption

        /// <summary>
        /// Decrypts a <c>string</c> value encrypted with <see cref="Encrypt(string)"/>.
        /// </summary>
        /// <param name="encryptedValue">The value to decrypt.</param>
        /// <returns>Returns the decrypted value</returns>
        public String DecryptString(string encryptedValue) => (String)Decrypt(encryptedValue, r => r.ReadString());

        /// <summary>
        /// Decrypts a <c>bool</c> value encrypted with <see cref="Encrypt(bool)"/>.
        /// </summary>
        /// <param name="encryptedValue">The value to decrypt.</param>
        /// <returns>Returns the decrypted value</returns>
        public Boolean DecryptBoolean(string encryptedValue) => (Boolean)Decrypt(encryptedValue, r => r.ReadBoolean());

        /// <summary>
        /// Decrypts a <c>char</c> value encrypted with <see cref="Encrypt(char)"/>.
        /// </summary>
        /// <param name="encryptedValue">The value to decrypt.</param>
        /// <returns>Returns the decrypted value</returns>
        public Char DecryptChar(string encryptedValue) => (Char)Decrypt(encryptedValue, r => r.ReadChar());

        /// <summary>
        /// Decrypts a <c>sbyte</c> value encrypted with <see cref="Encrypt(sbyte)"/>.
        /// </summary>
        /// <param name="encryptedValue">The value to decrypt.</param>
        /// <returns>Returns the decrypted value</returns>
        public SByte DecryptSByte(string encryptedValue) => (SByte)Decrypt(encryptedValue, r => r.ReadSByte());

        /// <summary>
        /// Decrypts a <c>byte</c> value encrypted with <see cref="Encrypt(byte)"/>.
        /// </summary>
        /// <param name="encryptedValue">The value to decrypt.</param>
        /// <returns>Returns the decrypted value</returns>
        public Byte DecryptByte(string encryptedValue) => (Byte)Decrypt(encryptedValue, r => r.ReadByte());

        /// <summary>
        /// Decrypts a <c>short</c> value encrypted with <see cref="Encrypt(short)"/>.
        /// </summary>
        /// <param name="encryptedValue">The value to decrypt.</param>
        /// <returns>Returns the decrypted value</returns>
        public Int16 DecryptInt16(string encryptedValue) => (Int16)Decrypt(encryptedValue, r => r.ReadInt16());

        /// <summary>
        /// Decrypts a <c>ushort</c> value encrypted with <see cref="Encrypt(ushort)"/>.
        /// </summary>
        /// <param name="encryptedValue">The value to decrypt.</param>
        /// <returns>Returns the decrypted value</returns>
        public UInt16 DecryptUInt16(string encryptedValue) => (UInt16)Decrypt(encryptedValue, r => r.ReadUInt16());

        /// <summary>
        /// Decrypts a <c>int</c> value encrypted with <see cref="Encrypt(int)"/>.
        /// </summary>
        /// <param name="encryptedValue">The value to decrypt.</param>
        /// <returns>Returns the decrypted value</returns>
        public Int32 DecryptInt32(string encryptedValue) => (Int32)Decrypt(encryptedValue, r => r.ReadInt32());

        /// <summary>
        /// Decrypts a <c>uint</c> value encrypted with <see cref="Encrypt(uint)"/>.
        /// </summary>
        /// <param name="encryptedValue">The value to decrypt.</param>
        /// <returns>Returns the decrypted value</returns>
        public UInt32 DecryptUInt32(string encryptedValue) => (UInt32)Decrypt(encryptedValue, r => r.ReadUInt32());

        /// <summary>
        /// Decrypts a <c>long</c> value encrypted with <see cref="Encrypt(long)"/>.
        /// </summary>
        /// <param name="encryptedValue">The value to decrypt.</param>
        /// <returns>Returns the decrypted value</returns>
        public Int64 DecryptInt64(string encryptedValue) => (Int64)Decrypt(encryptedValue, r => r.ReadInt64());

        /// <summary>
        /// Decrypts a <c>ulong</c> value encrypted with <see cref="Encrypt(ulong)"/>.
        /// </summary>
        /// <param name="encryptedValue">The value to decrypt.</param>
        /// <returns>Returns the decrypted value</returns>
        public UInt64 DecryptUInt64(string encryptedValue) => (UInt64)Decrypt(encryptedValue, r => r.ReadUInt64());

        /// <summary>
        /// Decrypts a <c>float</c> value encrypted with <see cref="Encrypt(float)"/>.
        /// </summary>
        /// <param name="encryptedValue">The value to decrypt.</param>
        /// <returns>Returns the decrypted value</returns>
        public Single DecryptSingle(string encryptedValue) => (Single)Decrypt(encryptedValue, r => r.ReadSingle());

        /// <summary>
        /// Decrypts a <c>double</c> value encrypted with <see cref="Encrypt(double)"/>.
        /// </summary>
        /// <param name="encryptedValue">The value to decrypt.</param>
        /// <returns>Returns the decrypted value</returns>
        public Double DecryptDouble(string encryptedValue) => (Double)Decrypt(encryptedValue, r => r.ReadDouble());

        /// <summary>
        /// Decrypts a <c>decimal</c> value encrypted with <see cref="Encrypt(decimal)"/>.
        /// </summary>
        /// <param name="encryptedValue">The value to decrypt.</param>
        /// <returns>Returns the decrypted value</returns>
        public Decimal DecryptDecimal(string encryptedValue) => (Decimal)Decrypt(encryptedValue, r => r.ReadDecimal());

        /// <summary>
        /// Decrypts a <c>DateTime</c> value encrypted with <see cref="Encrypt(DateTime)"/>.
        /// </summary>
        /// <param name="encryptedValue">The value to decrypt.</param>
        /// <returns>Returns the decrypted value</returns>
        public DateTime DecryptDateTime(string encryptedValue) => (DateTime)Decrypt(encryptedValue, r => r.ReadDateTime());

        /// <summary>
        /// Decrypts a <c>byte[]</c> value encrypted with <see cref="Encrypt(byte[])"/>.
        /// </summary>
        /// <param name="encryptedValue">The value to decrypt.</param>
        /// <returns>Returns the decrypted value</returns>
        public Byte[] DecryptByteArray(string encryptedValue) => (Byte[])Decrypt(encryptedValue, r => r.ReadByteArray());

        /// <summary>
        /// Decrypts a <c>string[]</c> value encrypted with <see cref="Encrypt(string[])"/>.
        /// </summary>
        /// <param name="encryptedValue">The value to decrypt.</param>
        /// <returns>Returns the decrypted value</returns>
        public String[] DecryptStringArray(string encryptedValue) => (String[])Decrypt(encryptedValue, r => r.ReadStringArray());

        private object Decrypt(string encryptedValue, Func<EncryptionReader, object> action)
        {
            using (MemoryStream stream = new MemoryStream(DecodeBytesFromString(encryptedValue)))
            using (EncryptionReader reader = CreateStreamReader(stream))
            {
                return action(reader);
            }
        }

        #endregion

        #region Encryption/decryption of objects

        /// <summary>
        /// Class to hold encrypt/decrypt functions for each supported data type.
        /// </summary>
        private class TypeInfo
        {
            public Func<Encryption, object, string> Encrypt { get; set; }
            public Func<Encryption, string, object> Decrypt { get; set; }

            public TypeInfo(Func<Encryption, object, string> encrypt, Func<Encryption, string, object> decrypt)
            {
                Encrypt = encrypt;
                Decrypt = decrypt;
            }
        }

        private static readonly Dictionary<Type, TypeInfo> TypeInfoLookup = new Dictionary<Type, TypeInfo>()
        {
            [typeof(String)] = new TypeInfo((e, v) => e.Encrypt((String)v), (e, s) => e.DecryptString(s)),
            [typeof(Boolean)] = new TypeInfo((e, v) => e.Encrypt((Boolean)v), (e, s) => e.DecryptBoolean(s)),
            [typeof(Char)] = new TypeInfo((e, v) => e.Encrypt((Char)v), (e, s) => e.DecryptChar(s)),
            [typeof(SByte)] = new TypeInfo((e, v) => e.Encrypt((SByte)v), (e, s) => e.DecryptSByte(s)),
            [typeof(Byte)] = new TypeInfo((e, v) => e.Encrypt((Byte)v), (e, s) => e.DecryptByte(s)),
            [typeof(Int16)] = new TypeInfo((e, v) => e.Encrypt((Int16)v), (e, s) => e.DecryptInt16(s)),
            [typeof(UInt16)] = new TypeInfo((e, v) => e.Encrypt((UInt16)v), (e, s) => e.DecryptUInt16(s)),
            [typeof(Int32)] = new TypeInfo((e, v) => e.Encrypt((Int32)v), (e, s) => e.DecryptInt32(s)),
            [typeof(UInt32)] = new TypeInfo((e, v) => e.Encrypt((UInt32)v), (e, s) => e.DecryptUInt32(s)),
            [typeof(Int64)] = new TypeInfo((e, v) => e.Encrypt((Int64)v), (e, s) => e.DecryptInt64(s)),
            [typeof(UInt64)] = new TypeInfo((e, v) => e.Encrypt((UInt64)v), (e, s) => e.DecryptUInt64(s)),
            [typeof(Single)] = new TypeInfo((e, v) => e.Encrypt((Single)v), (e, s) => e.DecryptSingle(s)),
            [typeof(Double)] = new TypeInfo((e, v) => e.Encrypt((Double)v), (e, s) => e.DecryptDouble(s)),
            [typeof(Decimal)] = new TypeInfo((e, v) => e.Encrypt((Decimal)v), (e, s) => e.DecryptDecimal(s)),
            [typeof(DateTime)] = new TypeInfo((e, v) => e.Encrypt((DateTime)v), (e, s) => e.DecryptDateTime(s)),
            [typeof(Byte[])] = new TypeInfo((e, v) => e.Encrypt((Byte[])v), (e, s) => e.DecryptByteArray(s)),
            [typeof(String[])] = new TypeInfo((e, v) => e.Encrypt((String[])v), (e, s) => e.DecryptStringArray(s)),
        };

        /// <summary>
        /// Indicates if the specified data type is supported by the encryption and decryption methods.
        /// </summary>
        /// <remarks>
        /// The encryption code supports all basic .NET data types in addition to <c>byte[]</c>
        /// and <c>string[]</c>. More complex data types are not supported.
        /// </remarks>
        /// <param name="type">The data type to be tested.</param>
        /// <returns>True if the specified type is supported. False otherwise.</returns>
        public static bool IsTypeSupported(Type type) => TypeInfoLookup.ContainsKey(type);

        /// <summary>
        /// Encrypts an object value. The object must hold one of the supported data types.
        /// </summary>
        /// <param name="value">Object to be encrypted.</param>
        /// <exception cref="ArgumentException"><paramref name="value"/> holds an unsupported data type.</exception>
        /// <returns>An encrypted string that can be decrypted using Decrypt.</returns>
        public string? Encrypt(object value)
        {
            if (value == null)
                return null;
            if (TypeInfoLookup.TryGetValue(value.GetType(), out TypeInfo? info))
                return info.Encrypt(this, value);
            throw new ArgumentException(string.Format("Cannot encrypt value : Data type '{0}' is not supported", value.GetType()));
        }

        /// <summary>
        /// Decrypts an object value of the specified type.
        /// </summary>
        /// <param name="encryptedValue">The encrypted string to be decrypted.</param>
        /// <param name="targetType">The type of data that was originally encrypted into <paramref name="encryptedValue"/>.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns>Returns the decrypted value.</returns>
        public object Decrypt(string encryptedValue, Type targetType)
        {
            if (TypeInfoLookup.TryGetValue(targetType, out TypeInfo? info))
                return info.Decrypt(this, encryptedValue);
            throw new ArgumentException(string.Format("Cannot decrypt value : Data type '{0}' is not supported", targetType));
        }

        #endregion

        #region Support methods

        /// <summary>
        /// Creates a SymmetricAlgorithm instance for the current encryption algorithm.
        /// </summary>
        /// <returns>
        /// Returns the created SymmetricAlgorithm instance.
        /// </returns>
        protected SymmetricAlgorithm CreateAlgorithm()
        {
            MethodInfo? method = AlgorithmType.GetMethod("Create", Array.Empty<Type>());
            if (method != null)
            {
                if (method.Invoke(null, null) is SymmetricAlgorithm algorithm)
                    return algorithm;
            }
            throw new Exception($"Unable to create instance of {AlgorithmType.FullName}.");
        }

        /// <summary>
        /// Generates a salt that contains a cryptographically strong sequence of random values.
        /// </summary>
        /// <returns>The generated salt value.</returns>
        private byte[] CreateSalt()
        {
            byte[] salt = new byte[SaltLength];
            using (RNGCryptoServiceProvider generator = new RNGCryptoServiceProvider())
            {
                generator.GetBytes(salt);
            }
            return salt;
        }

        /// <summary>
        /// Generates a pseudorandom key and initialization vector from the current password and the
        /// given salt.
        /// </summary>
        /// <param name="algorithm"><see cref="SymmetricAlgorithm"></see> being used to encrypt.</param>
        /// <param name="salt">The salt used to derive the key and initialization vector.</param>
        /// <param name="key">Returns the generated key.</param>
        /// <param name="iv">Returns the generated initialization vector.</param>
        protected void GenerateKeyAndIv(SymmetricAlgorithm algorithm, byte[] salt, out byte[] key, out byte[] iv)
        {
            int keyLength = (algorithm.KeySize >> 3);
            int ivLength = (algorithm.BlockSize >> 3);
            byte[] bytes = DeriveBytes(salt, keyLength + ivLength);
            key = new byte[keyLength];
            Buffer.BlockCopy(bytes, 0, key, 0, keyLength);
            iv = new byte[ivLength];
            Buffer.BlockCopy(bytes, keyLength, iv, 0, ivLength);
        }

        /// <summary>
        /// Generates a series of pseudorandom bytes of the specified length based on the current
        /// password and the given salt.
        /// </summary>
        /// <param name="salt">The salt used to derive the bytes.</param>
        /// <param name="bytes">The number of bits of data to generate.</param>
        /// <returns>Returns the derived bytes.</returns>
        protected byte[] DeriveBytes(byte[] salt, int bytes)
        {
            Rfc2898DeriveBytes derivedBytes = new Rfc2898DeriveBytes(Password, salt, 1000);
            return derivedBytes.GetBytes(bytes);
        }

        #endregion

    }
}
