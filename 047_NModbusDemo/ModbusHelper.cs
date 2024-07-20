namespace NModbusDemo
{
    public class ModbusHelper
    {
        public static ushort[] Bytes2Ushorts(byte[] src, bool reverse = false)
        {
            int len = src.Length;
            byte[] srcPlus = new byte[len + 1];
            src.CopyTo(srcPlus, 0);
            int count = len >> 1;
            if (len % 2 != 0)
            {
                count += 1;
            }

            ushort[] dst = new ushort[count];
            if (reverse)
            {
                for (int i = 0; i < count; i++)
                {
                    dst[i] = (ushort)(srcPlus[i * 2] << 8 | srcPlus[2 * i + 1] & 0xff);
                }
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    dst[i] = (ushort)(srcPlus[i * 2] & 0xff | srcPlus[2 * i + 1] << 8);
                }
            }
            return dst;
        }

        public static byte[] Ushorts2Bytes(ushort[] src, bool reverse = false)
        {
            int count = src.Length;
            byte[] dst = new byte[count << 1];
            if (reverse)
            {
                for (int i = 0; i < count; i++)
                {
                    dst[i * 2] = (byte)(src[i] >> 8);
                    dst[i * 2 + 1] = (byte)(src[i] >> 0);
                }
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    dst[i * 2] = (byte)(src[i] >> 0);
                    dst[i * 2 + 1] = (byte)(src[i] >> 8);
                }
            }
            return dst;
        }
    }
}