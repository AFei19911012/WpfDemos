using System;

namespace SoftCircuits.SimpleLogFile
{
    /// <summary>
    /// Argument for <see cref="LogFile.LineLogged"/> event.
    /// </summary>
    /// <param name="text">Specifies the text that was logged.</param>
    public class LineLoggedEventArgs(string text)
                : EventArgs
    {
        /// <summary>
        /// The text that was logged.
        /// </summary>
        public string Text { get; set; } = text;
    }
}
