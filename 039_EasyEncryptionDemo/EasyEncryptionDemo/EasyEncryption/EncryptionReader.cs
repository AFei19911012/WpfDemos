// Copyright (c) 2019-2021 Jonathan Wood (www.softcircuits.com)
// Licensed under the MIT license.
//
using System;
using System.IO;
using System.Security.Cryptography;

namespace SoftCircuits.EasyEncryption
{
    /// <summary>
    /// Class that provides streaming decryption functionality.
    /// </summary>
    /// <remarks>
    /// Using this class is the preferred way to decrypt values from a file or memory.
    /// Other decryption methods defer to this class for actual decryption.
    /// </remarks>
    public class EncryptionReader : BinaryReader, IDisposable
    {
        private SymmetricAlgorithm Algorithm;
        private ICryptoTransform Decryptor;

        internal EncryptionReader(SymmetricAlgorithm algorithm, ICryptoTransform decryptor, Stream stream) : base(stream)
        {
            Algorithm = algorithm;
            Decryptor = decryptor;
        }

        /// <summary>
        /// Reads a <c>DateTime</c> value from the encrypted stream.
        /// </summary>
        /// <returns>The decrypted value.</returns>
        public DateTime ReadDateTime()
        {
            return new DateTime(ReadInt64());
        }

        /// <summary>
        /// Reads a <c>byte[]</c> value from the encrypted stream.
        /// </summary>
        /// <returns>The decrypted values.</returns>
        public byte[] ReadByteArray()
        {
            int count = ReadInt32();
            byte[] bytes = new byte[count];
            if (count > 0)
                Read(bytes, 0, count);
            return bytes;
        }

        /// <summary>
        /// Reads a <c>string[]</c> value from the encrypted stream.
        /// </summary>
        /// <returns>The decrypted values.</returns>
        public string[] ReadStringArray()
        {
            int count = ReadInt32();
            string[] strings = new string[count];
            for (int i = 0; i < count; i++)
                strings[i] = ReadString();
            return strings;
        }

        #region IDisposable implementation

        private bool disposed = false; // To detect redundant calls

        /// <summary>
        /// Releases all resources used by the current instance of the <c>EncryptionReader</c> class.
        /// </summary>
        public new void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Releases the unmanaged resources used by the <c>EncryptionReader</c> class and optionally
        /// releases the managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources;
        /// <c>false</c> to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
        {
            if (!disposed)
            {
                disposed = true;
                if (disposing)
                {
                    // Dispose managed objects
                    base.Dispose(true);
                    Decryptor.Dispose();
                    Algorithm.Dispose();
                }
            }
        }

        /// <summary>
        /// Destructs this instance of <c>EncryptionReader</c>.
        /// </summary>
        ~EncryptionReader()
        {
            Dispose(false);
        }

        #endregion

    }
}
