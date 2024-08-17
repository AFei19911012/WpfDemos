using System.Security.Cryptography;

namespace MatrixRainDemo
{
    ///
	/// ----------------------------------------------------------------
	/// Copyright @BigWang 2024 All rights reserved
	/// Author      : BigWang
	/// Created Time: 2024/8/17 23:18:31
	/// Description :
	/// ----------------------------------------------------------------
	/// Version      Modified Time              Modified By     Modified Content
	/// V1.0.0.0     2024/8/17 23:18:31                     BigWang         首次编写         
	///
    public class CryptoRandom : RandomNumberGenerator
    {
        /**
		 * <summary>
		 * Random number generator 
		 * </summary>
		 */
        private static RandomNumberGenerator r;

        /**
		 * <summary>
		 * Creates an instance of the default implementation of a cryptographic random number generator that can be used to generate random data.
		 * </summary>
		 */
        public CryptoRandom()
        {
            r = RandomNumberGenerator.Create();
        }

        /**
		 * <summary>
		 * Fills the elements of a specified array of bytes with random numbers.
		 * </summary>
		 * <param name="buffer">An array of bytes to contain random numbers.</param>
		 */
        public override void GetBytes(byte[] buffer)
        {
            r.GetBytes(buffer);
        }
        /**
		 * <summary>
		 * Returns a random number between 0.0 and 1.0
		 * </summary>
		 */
        public double NextDouble()
        {
            byte[] b = new byte[4];
            r.GetBytes(b);
            return (double)BitConverter.ToUInt32(b, 0) / UInt32.MaxValue;
        }

        /**
		 * <summary>
		 * Returns a random number within the specified range.
		 * </summary>
		 * <param name="minValue">The inclusive lower bound of the random number returned.</param>
		 * <param name="maxValue">The exclusive upper bound of the random number returned. maxValue must be greater than or equal to minValue.</param>
		 */
        public int Next(int minPValue, int maxPValue)
        {
            return (int)Math.Round(NextDouble() * (maxPValue - minPValue - 1)) + minPValue;
        }
        /**
		 * <summary>
		 * Returns a nonnegative random number
		 * </summary>
		 */
        public int Next()
        {
            return Next(0, Int32.MaxValue);
        }

        /**
		 * <summary>
		 * Returns a nonnegative random number less than the specified maximum
		 * </summary>
		 * <param name="maxValue">The inclusive upper bound of the random number returned. maxValue must be greater than or equal 0</param>
		 */
        public int Next(int maxValue)
        {
            return Next(0, maxValue);
        }

        /**
		 * <summary>
		 * When overridden in a derived class, fills an array of bytes with a cryptographically strong random sequence of nonzero values
		 * </summary>
		 * <param name="data">The array to fill with cryptographically strong random nonzero bytes</param>
		 */
        public override void GetNonZeroBytes(byte[] data)
        {
            throw new NotImplementedException();
        }
    }
}
