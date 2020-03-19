namespace CountdownTask
{
    using System;

    /// <summary>
    /// Class containing property to store arguments for event of <see cref="CountdownTimer"/>.
    /// </summary>
    public class TimeIsOverEventArgs : EventArgs
    {
        /// <summary>
        /// Gets or sets a message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeIsOverEventArgs"/> class.
        /// </summary>
        /// <param name="message">Message</param>
        public TimeIsOverEventArgs(string message)
        {
            this.Message = message;
        }
    }
}
