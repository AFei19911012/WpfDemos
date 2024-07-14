// Copyright (c) 2020-2024 Jonathan Wood (www.softcircuits.com)
// Licensed under the MIT license.
//

using System;
using System.IO;
using System.Text;

namespace SoftCircuits.SimpleLogFile
{
    /// <summary>
    /// Supports logging entries to a log file.
    /// </summary>
    public class LogFile
    {
        private const bool DefaultShowFullExceptionClassName = false;
        private const bool DefaultDividersEnabled = true;
        private const string DefaultLogItemDelimiter = " : ";
        private const string DefaultSecondaryPrefix = " : ";
        private const char DefaultDividerChar = '-';

        private const string NullString = "(null)";
        private const string NullExceptionString = "(null exception)";

        /// <summary>
        /// Event raised when a line is logged.
        /// </summary>
        /// <remarks>
        /// Note: If you override the <see cref="OnWrite(string)"/> method, this event will not be fired
        /// unless you call the base method or raise the event in your own code.
        /// </remarks>
        public event EventHandler<LineLoggedEventArgs>? LineLogged;

        /// <summary>
        /// Gets or sets the name of the file that log entries are written to. Setting this
        /// property to <c>null</c> disables logging. Note that a derived class can override
        /// how and where log entries are written.
        /// </summary>
        public string Filename { get; set; }

        /// <summary>
        /// Gets or sets which log entries are written to the log file. Only entries with the
        /// specified level or higher will be written.
        /// </summary>
        public LogLevel LogLevel { get; set; }

        /// <summary>
        /// Gets or sets whether the log methods that receive an <see cref="Exception"/> argument
        /// will also log the exception's inner exceptions. When <c>false</c>, only the outer-most
        /// exception is logged.
        /// </summary>
        public bool LogInnerExceptions { get; set; }

        /// <summary>
        /// Gets or sets whether the full exception class namespace is displayed when formatting
        /// exceptions.
        /// </summary>
        public bool ShowFullExceptionClassName { get; set; }

        /// <summary>
        /// Gets or sets whether the <see cref="LogDivider(char)"/> method is enabled. Setting
        /// this property to <c>false</c> will cause that method to have no effect.
        /// </summary>
        public bool DividersEnabled { get; set; }

        /// <summary>
        /// Gets or sets the delimiter inserted between multiple log-entry items.
        /// </summary>
        public string LogItemDelimiter { get; set; }

        /// <summary>
        /// Gets or sets the prefix for secondary entries. Secondary entries are part of a log
        /// entry that appear on a new line. Currently, the only secondary entries are when
        /// logging an exception and <see cref="LogInnerExceptions"/> is <c>true</c>.
        /// </summary>
        public string SecondaryPrefix { get; set; }

        /// <summary>
        /// Gets or sets the character used by the <see cref="LogFile.LogDivider()"/> method.
        /// </summary>
        public char DividerChar { get; set; }

        /// <summary>
        /// Constructs a new <see cref="LogFile"/> instance.
        /// </summary>
        /// <param name="filename">Name of the file log where entries will be written. Set to
        /// <c>null</c> to disables logging.</param>
        /// <param name="logLevel">Determines which log entries are written to the log file.
        /// Only log entries with the specified level or higher will be written.
        /// </param>
        /// <param name="logInnerExceptions">Determines whether the log methods that receive
        /// an <see cref="Exception"/> argument will also log all the inner exceptions.</param>
        public LogFile(string filename, LogLevel logLevel = LogLevel.All, bool logInnerExceptions = false)
        {
            Filename = filename;
            LogLevel = logLevel;
            LogInnerExceptions = logInnerExceptions;
            ShowFullExceptionClassName = DefaultShowFullExceptionClassName;
            DividersEnabled = DefaultDividersEnabled;
            LogItemDelimiter = DefaultLogItemDelimiter;
            SecondaryPrefix = DefaultSecondaryPrefix;
            DividerChar = DefaultDividerChar;
        }

        /// <summary>
        /// Logs an entry.
        /// </summary>
        /// <param name="level">Specifies the entry importance, or level.</param>
        /// <param name="args">Any number of values for this entry.</param>
        public void Log(LogLevel level, params object[] args)
        {
            if (level >= LogLevel)
            {
                OnWrite(OnFormat(level, FormatItems(args, out Exception? ex)));
                // Log inner exceptions if specified and we found an exception
                if (LogInnerExceptions && ex != null)
                {
                    while (ex.InnerException != null)
                    {
                        ex = ex.InnerException;
                        OnWrite(OnFormatSecondary(level, $"[INNER EXCEPTION] {OnFormatException(ex)}"));
                    }
                }
            }
        }

        /// <summary>
        /// Logs a formatted entry.
        /// </summary>
        /// <param name="level">Specifies the entry importance, or level.</param>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Any number of objects to format.</param>
        public void LogFormat(LogLevel level, string format, params object[] args)
        {
            if (level >= LogLevel)
                OnWrite(OnFormat(level, string.Format(format, args)));
        }

        /// <summary>
        /// Logs an information-level entry.
        /// </summary>
        /// <param name="args">Any number of values for this entry.</param>
        public void LogInfo(params object[] args) => Log(LogLevel.Info, args);

        /// <summary>
        /// Logs a formatted information-level entry.
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Any number of objects to format.</param>
        public void LogInfoFormat(string format, params object[] args) => LogFormat(LogLevel.Info, format, args);

        /// <summary>
        /// Logs an warning-level entry.
        /// </summary>
        /// <param name="args">Any number of values for this entry.</param>
        public void LogWarning(params object[] args) => Log(LogLevel.Warning, args);

        /// <summary>
        /// Logs a formatted warning-level entry.
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Any number of objects to format.</param>
        public void LogWarningFormat(string format, params object[] args) => LogFormat(LogLevel.Warning, format, args);

        /// <summary>
        /// Logs an error-level entry.
        /// </summary>
        /// <param name="args">Any number of values for this entry.</param>
        public void LogError(params object[] args) => Log(LogLevel.Error, args);

        /// <summary>
        /// Logs a formatted error-level entry.
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Any number of objects to format.</param>
        public void LogErrorFormat(string format, params object[] args) => LogFormat(LogLevel.Error, format, args);

        /// <summary>
        /// Logs an critical-level entry.
        /// </summary>
        /// <param name="args">Any number of values for this entry.</param>
        public void LogCritical(params object[] args) => Log(LogLevel.Critical, args);

        /// <summary>
        /// Logs a formatted critical-level entry.
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Any number of objects to format.</param>
        public void LogCriticalFormat(string format, params object[] args) => LogFormat(LogLevel.Critical, format, args);

        /// <summary>
        /// Writes a horizontal divider to the log file to visually separate groups of
        /// log entries. The divider is drawn using the character specified by the
        /// <see cref="DividerChar"/> property.
        /// </summary>
        public void LogDivider() => LogDivider(DividerChar);

        /// <summary>
        /// Writes a horizontal divider to the log file to visually separate groups of
        /// log entries. The divider is drawn using the character specified by
        /// <paramref name="dividerChar"/>.
        /// </summary>
        /// <param name="dividerChar">Specifies the character used to draw the divider.</param>
        public void LogDivider(char dividerChar)
        {
            if (LogLevel != LogLevel.None && DividersEnabled)
                OnWrite(new string(dividerChar, 79));
        }

        /// <summary>
        /// Deletes the current log file.
        /// </summary>
        public void Delete() => OnDelete();

        #region Overridables

        /// <summary>
        /// Overridable handler to format text before it is written to the log file.
        /// </summary>
        /// <param name="level">Specifies the entry importance, or level.</param>
        /// <param name="text">Text to be written to the log file.</param>
        /// <returns>The formatted text.</returns>
        protected virtual string OnFormat(LogLevel level, string text)
        {
            return string.Format("[{0:G}][{1}] {2}",
                DateTime.Now,
                level.ToString().ToUpper(),
                text ?? NullString);
        }

        /// <summary>
        /// Overridable handler to format text for secondary log entries.
        /// Currently, this is only used for inner exceptions.
        /// </summary>
        /// <param name="level">Specifies the entry importance, or level.</param>
        /// <param name="text">Text to be written to the log file.</param>
        /// <returns>The formatted text.</returns>
        protected virtual string OnFormatSecondary(LogLevel level, string text)
        {
            return string.Format("{0}{1}", DefaultLogItemDelimiter, text);
        }

        /// <summary>
        /// Overridable handler to format an exception. Does not include inner exceptions.
        /// </summary>
        /// <param name="ex">The exception to format.</param>
        /// <returns>The formatted exception.</returns>
        protected virtual string OnFormatException(Exception ex)
        {
            if (ex == null)
                return NullExceptionString;
            Type type = ex.GetType();
            return string.Format("{0}: {1}", ShowFullExceptionClassName ? type.FullName : type.Name, ex.Message);
        }

        /// <summary>
        /// Overridable handler to write text to the log file.
        /// </summary>
        /// <param name="text">Text to be written to the log file.</param>
        protected virtual void OnWrite(string text)
        {
            if (!string.IsNullOrEmpty(Filename))
            {
                using StreamWriter writer = File.AppendText(Filename);
                writer.WriteLine(text ?? NullString);
            }

            LineLogged?.Invoke(this, new(text ?? NullString));
        }

        /// <summary>
        /// Overridable handler to delete the current log file.
        /// </summary>
        protected virtual void OnDelete()
        {
            if (!string.IsNullOrEmpty(Filename))
            {
                try
                {
                    File.Delete(Filename);
                }
                catch (Exception) { }
            }
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Formats a collection of items into a single string.
        /// </summary>
        /// <param name="items">Items to format.</param>
        /// <param name="ex">Returns a reference to the first item that
        /// was an exception, or <c>null</c> if no items were exceptions.</param>
        /// <returns>The formatted string.</returns>
        private string FormatItems(object[] items, out Exception? ex)
        {
            ex = null;

            StringBuilder builder = new();
            foreach (object item in items)
            {
                if (builder.Length > 0)
                    builder.Append(LogItemDelimiter ?? string.Empty);
                if (item == null)
                {
                    builder.Append(NullString);
                }
                else if (item is Exception exception)
                {
                    builder.Append(OnFormatException(exception));
                    ex ??= exception;
                }
                else builder.Append(item.ToString());
            }
            return builder.ToString();
        }

        #endregion

    }
}
