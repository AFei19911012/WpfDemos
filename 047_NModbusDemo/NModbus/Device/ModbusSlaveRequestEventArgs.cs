namespace NModbus.Device
{
    public class ModbusSlaveRequestEventArgs : EventArgs
    {
        private readonly IModbusMessage _message;

        internal ModbusSlaveRequestEventArgs(IModbusMessage message)
        {
            _message = message;
        }

        /// <summary>
        ///     Gets the message.
        /// </summary>
        public IModbusMessage Message
        {
            get { return _message; }
        }
    }
}