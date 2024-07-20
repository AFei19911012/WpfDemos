using NModbus;
using System.Net.Sockets;
using System.Text;

namespace NModbusDemo
{
    public class ModbusTcpClient
    {
        private IModbusMaster master;
        private TcpClient tcpClient;

        public string IP { get; set; }
        public int Port { get; set; }
        public ushort MaxStringLength { get; set; } = 100;
        public byte SlaveAddress { get; set; } = 0;
        public bool Connected
        {
            get
            {
                if (tcpClient == null)
                {
                    return false;
                }
                else
                {
                    return tcpClient.Connected;
                }
            }
        }

        public ModbusTcpClient(string ip, int port)
        {
            IP = ip;
            Port = port;
        }

        /// <summary>
        /// 连接
        /// </summary>
        public void Connect()
        {
            ModbusFactory factory = new ModbusFactory();
            tcpClient = new TcpClient(IP, Port);
            master = factory.CreateMaster(tcpClient);
            master.Transport.ReadTimeout = 2000;
            master.Transport.Retries = 10;
        }

        /// <summary>
        /// 断开
        /// </summary>
        public void Close()
        {
            tcpClient?.Close();
            master.Dispose();
        }

        /// <summary>
        /// 写入 short
        /// </summary>
        /// <param name="start"></param>
        /// <param name="data"></param>
        public void WriteInt16(ushort start, ushort data)
        {
            master.WriteSingleRegister(SlaveAddress, start, data);
        }
        /// <summary>
        /// 读取 short
        /// </summary>
        /// <param name="start"></param>
        /// <returns></returns>
        public ushort ReadInt16(ushort start)
        {
            return master.ReadHoldingRegisters(SlaveAddress, start, 1)[0];
        }
        /// <summary>
        /// 批量写入 short
        /// </summary>
        /// <param name="start"></param>
        /// <param name="data"></param>
        public void WriteInt16(ushort start, ushort[] data)
        {
            master.WriteMultipleRegisters(SlaveAddress, start, data);
        }
        /// <summary>
        /// 批量读取 short
        /// </summary>
        /// <param name="start"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        public ushort[] ReadInt16(ushort start, ushort len)
        {
            return master.ReadHoldingRegisters(SlaveAddress, start, len);
        }

        /// <summary>
        /// 写入 bool
        /// </summary>
        /// <param name="start"></param>
        /// <param name="data"></param>
        public void WriteBool(ushort start, bool data)
        {
            master.WriteSingleCoil(SlaveAddress, start, data);
        }
        /// <summary>
        /// 读取 bool
        /// </summary>
        /// <param name="start"></param>
        /// <returns></returns>
        public bool ReadBool(ushort start)
        {
            return master.ReadCoils(SlaveAddress, start, 1)[0];
        }
        /// <summary>
        /// 批量写入 bool
        /// </summary>
        /// <param name="start"></param>
        /// <param name="data"></param>
        public void WriteBool(ushort start, bool[] data)
        {
            master.WriteMultipleCoils(SlaveAddress, start, data);
        }
        /// <summary>
        /// 批量读取 bool
        /// </summary>
        /// <param name="start"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        public bool[] ReadBool(ushort start, ushort len)
        {
            return master.ReadCoils(SlaveAddress, start, len);
        }

        /// <summary>
        /// 写入 float
        /// </summary>
        /// <param name="start"></param>
        /// <param name="data"></param>
        public void WriteFloat(ushort start, float data)
        {
            byte[] tmp = BitConverter.GetBytes(data);
            ushort[] buff = ModbusHelper.Bytes2Ushorts(tmp);
            master.WriteMultipleRegisters(SlaveAddress, start, buff);
        }
        /// <summary>
        /// 读取 float
        /// </summary>
        /// <param name="start"></param>
        /// <returns></returns>
        public float ReadFloat(ushort start)
        {
            var tmp = master.ReadHoldingRegisters(SlaveAddress, start, 2);
            var buff = ModbusHelper.Ushorts2Bytes(tmp);
            return BitConverter.ToSingle(buff, 0);
        }

        /// <summary>
        /// 写入 string
        /// </summary>
        /// <param name="start"></param>
        /// <param name="data"></param>
        public void WriteString(ushort start, string data)
        {
            var tmp = Encoding.UTF8.GetBytes(data);
            var buff = ModbusHelper.Bytes2Ushorts(tmp);
            master.WriteMultipleRegisters(SlaveAddress, start, buff);
        }
        /// <summary>
        /// 读取 string，默认最大长度 100
        /// </summary>
        /// <param name="start"></param>
        /// <returns></returns>
        public string ReadString(ushort start)
        {
            var tmp = master.ReadHoldingRegisters(SlaveAddress, start, MaxStringLength);
            byte[] data = ModbusHelper.Ushorts2Bytes(tmp);
            return Encoding.UTF8.GetString(data).Trim(['\0']);
        }


        public bool[] ReadCoils(byte SlaveAddress, ushort startAddress, ushort num)
        {
            return master.ReadCoils(SlaveAddress, startAddress, num);
        }

        public bool[] ReadInputs(byte SlaveAddress, ushort startAddress, ushort num)
        {
            return master.ReadInputs(SlaveAddress, startAddress, num);
        }

        public ushort[] ReadHoldingRegisters(byte SlaveAddress, ushort startAddress, ushort num)
        {
            return master.ReadHoldingRegisters(SlaveAddress, startAddress, num);
        }

        public ushort[] ReadInputRegisters(byte SlaveAddress, ushort startAddress, ushort num)
        {
            return master.ReadInputRegisters(SlaveAddress, startAddress, num);
        }

        public void WriteSingleCoil(byte SlaveAddress, ushort startAddress, bool value)
        {
            master.WriteSingleCoil(SlaveAddress, startAddress, value);
        }

        public void WriteSingleRegister(byte SlaveAddress, ushort startAddress, ushort value)
        {
            master.WriteSingleRegister(SlaveAddress, startAddress, value);
        }

        public void WriteMultipleCoils(byte SlaveAddress, ushort startAddress, bool[] value)
        {
            master.WriteMultipleCoils(SlaveAddress, startAddress, value);
        }

        public void WriteMultipleRegisters(byte SlaveAddress, ushort startAddress, ushort[] value)
        {
            master.WriteMultipleRegisters(SlaveAddress, startAddress, value);
        }
    }
}
