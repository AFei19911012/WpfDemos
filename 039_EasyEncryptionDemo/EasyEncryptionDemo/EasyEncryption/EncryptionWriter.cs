// Copyright (c) 2019-2021 Jonathan Wood (www.softcircuits.com)
// Licensed under the MIT license.
//
using System;
using System.IO;
using System.Security.Cryptography;

namespace SoftCircuits.EasyEncryption
{
    /// <summary>
    /// Class that provides streaming encryption functionality.
    /// </summary>
    /// <remarks>
    /// Using this class is the preferred way to encrypt values to a file or memory.
    /// Other encryption methods defer to this class for actual encryption. Meta data
    /// that must be stored with the encrypted result is only stored once for all
    /// data in the stream.
    /// </remarks>
    public class EncryptionWriter : BinaryWriter, IDisposable
    {
        private readonly SymmetricAlgorithm Algorithm;
        private readonly ICryptoTransform Encryptor;

        internal EncryptionWriter(SymmetricAlgorithm algorithm, ICryptoTransform encryptor, Stream stream) : base(stream)
        {
            Algorithm = algorithm;
            Encryptor = encryptor;
        }

        /// <summary>
        /// Writes a <c>DateTime</c> value to the encrypted stream.
        /// </summary>
        /// <param name="value"><c>DateTime</c> value to write.</param>
        public void Write(DateTime value)
        {
            Write((Int64)value.Ticks);
        }

        /// <summary>
        /// Writes a <c>byte</c> array to the encrypted stream.
        /// </summary>
        /// <remarks>
        /// Note: Hides <c>BinaryWriter.Write(byte[])</c>.
        /// </remarks>
        /// <param name="value"><c>byte[]</c> values to write.</param>
        public new void Write(byte[] value)
        {
            Write((Int32)value.Length);
            Write(value, 0, value.Length);
        }

        /// <summary>
        /// Writes a <c>string</c> to the encrypted stream.
        /// </summary>
        /// <param name="value"><c>string[]</c> values to write.</param>
        public void Write(string[] value)
        {
            Write((Int32)value.Length);
            for (int i = 0; i < value.Length; i++)
                Write(value[i]);
        }

        #region IDisposable implementation

        private bool disposed = false; // To detect redundant calls

        /// <summary>
        /// Releases all resources used by the current instance of the <c>EncryptionWriter</c> class.
        /// </summary>
        public new void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Releases the unmanaged resources used by the <c>EncryptionWriter</c> class and optionally
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
                    Encryptor.Dispose();
                    Algorithm.Dispose();
                }
            }
        }

        /// <summary>
        /// Destructs this instance of <c>EncryptionWriter</c>.
        /// </summary>
        ~EncryptionWriter()
        {
            Dispose(false);
        }

        #endregion

    }
}
