using NModbus;
using NModbus.Device;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace NModbusDemo
{
    public class ModbusTcpServer
    {
        private IModbusSlave slave;
        private TcpListener tcpListener;
        private IModbusTcpSlaveNetwork network;

        public string IP { get; set; }
        public int Port { get; set; }
        public ushort MaxStringLength { get; set; } = 100;
        public event EventHandler<ModbusSlaveRequestEventArgs> ModbusSlaveRequestReceived;

        public ModbusTcpServer(string ip, int port)
        {
            IP = ip;
            Port = port;
        }

        private void Slave_ModbusSlaveRequestReceived(object sender, ModbusSlaveRequestEventArgs e)
        {
            ModbusSlaveRequestReceived?.Invoke(sender, e);
        }

        /// <summary>
        /// 启动服务
        /// </summary>
        public void Start()
        {
            tcpListener = new TcpListener(IPAddress.Parse(IP), Port);
            tcpListener.Start();

            var factory = new ModbusFactory();
            network = factory.CreateSlaveNetwork(tcpListener);
            slave = factory.CreateSlave(1);
            slave.ModbusSlaveRequestReceived += Slave_ModbusSlaveRequestReceived;
            network.AddSlave(slave);
            network.ListenAsync();
        }

        /// <summary>
        /// 关闭服务
        /// </summary>
        public void Stop()
        {
            tcpListener?.Stop();
            network?.Dispose();
        }

        /// <summary>
        /// 写入 short
        /// </summary>
        /// <param name="start"></param>
        /// <param name="data"></param>
        public void WriteInt16(ushort start, ushort data)
        {
            slave.DataStore.HoldingRegisters.WritePoints(start, [data]);
        }
        /// <summary>
        /// 读取 short
        /// </summary>
        /// <param name="start"></param>
        /// <returns></returns>
        public ushort ReadInt16(ushort start)
        {
            return slave.DataStore.HoldingRegisters.ReadPoints(start, 1)[0];
        }
        /// <summary>
        /// 批量写入 short
        /// </summary>
        /// <param name="start"></param>
        /// <param name="data"></param>
        public void WriteInt16(ushort start, ushort[] data)
        {
            slave.DataStore.HoldingRegisters.WritePoints(start, data);
        }
        /// <summary>
        /// 批量读取 short
        /// </summary>
        /// <param name="start"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        public ushort[] ReadInt16(ushort start, ushort len)
        {
            return slave.DataStore.HoldingRegisters.ReadPoints(start, len);
        }

        /// <summary>
        /// 写入 bool
        /// </summary>
        /// <param name="start"></param>
        /// <param name="data"></param>
        public void WriteBool(ushort start, bool data)
        {
            slave.DataStore.CoilDiscretes.WritePoints(start, [data]);
        }
        /// <summary>
        /// 读取 bool
        /// </summary>
        /// <param name="start"></param>
        /// <returns></returns>
        public bool ReadBool(ushort start)
        {
            return slave.DataStore.CoilDiscretes.ReadPoints(start, 1)[0];
        }
        /// <summary>
        /// 批量写入 bool
        /// </summary>
        /// <param name="start"></param>
        /// <param name="data"></param>
        public void WriteBool(ushort start, bool[] data)
        {
            slave.DataStore.CoilDiscretes.WritePoints(start, data);
        }
        /// <summary>
        /// 批量读取 bool
        /// </summary>
        /// <param name="start"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        public bool[] ReadBool(ushort start, ushort len)
        {
            return slave.DataStore.CoilDiscretes.ReadPoints(start, len);
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
            slave.DataStore.HoldingRegisters.WritePoints(start, buff);
        }
        /// <summary>
        /// 读取 float
        /// </summary>
        /// <param name="start"></param>
        /// <returns></returns>
        public float ReadFloat(ushort start)
        {
            var tmp = slave.DataStore.HoldingRegisters.ReadPoints(start, 2);
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
            slave.DataStore.HoldingRegisters.WritePoints(start, buff);
        }
        /// <summary>
        /// 读取 string，默认最大长度 100
        /// </summary>
        /// <param name="start"></param>
        /// <returns></returns>
        public string ReadString(ushort start)
        {
            var tmp = slave.DataStore.HoldingRegisters.ReadPoints(start, MaxStringLength);
            byte[] data = ModbusHelper.Ushorts2Bytes(tmp);
            return Encoding.UTF8.GetString(data).Trim(['\0']);
        }


        public void WriteCoilInputs(ushort start, bool data)
        {
            slave.DataStore.CoilInputs.WritePoints(start, [data]);
        }
        public bool ReadCoilInputs(ushort start)
        {
            return slave.DataStore.CoilInputs.ReadPoints(start, 1)[0];
        }
        public void WriteCoilInputs(ushort start, bool[] data)
        {
            slave.DataStore.CoilInputs.WritePoints(start, data);
        }
        public bool[] ReadCoilInputs(ushort start, ushort len)
        {
            return slave.DataStore.CoilInputs.ReadPoints(start, len);
        }

        public void WriteInputRegisters(ushort start, ushort data)
        {
            slave.DataStore.InputRegisters.WritePoints(start, [data]);
        }
        public ushort ReadInputRegisters(ushort start)
        {
            return slave.DataStore.InputRegisters.ReadPoints(start, 1)[0];
        }
        public void WriteInputRegisters(ushort start, ushort[] data)
        {
            slave.DataStore.InputRegisters.WritePoints(start, data);
        }
        public ushort[] ReadInputRegisters(ushort start, ushort len)
        {
            return slave.DataStore.InputRegisters.ReadPoints(start, len);
        }
    }
}