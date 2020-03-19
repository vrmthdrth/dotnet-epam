namespace CountdownTask
{
    using System;
    using System.Threading;

    /// <summary>
    /// A countdown timer class.
    /// </summary>
    public class CountdownTimer
    {
        /// <summary>
        /// A field designed to store time in seconds.
        /// </summary>
        private int _time;

        /// <summary>
        /// Gets or sets time for countdown.
        /// </summary>
        public int Time
        {
            get
            {
                return this._time;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }

                this._time = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CountdownTimer"/> class.
        /// </summary>
        /// <param name="time">Time</param>
        public CountdownTimer(int time)
        {
            this.Time = time;
        }

        /// <summary>
        /// The event defining the end of countdown.
        /// </summary>
        public event EventHandler<TimeIsOverEventArgs> TimeIsOver;

        /// <summary>
        /// Starts the time.
        /// </summary>
        /// <param name="message"> The message to listeners. </param>
        public void StartCountdown(string message)
        {
            Thread.Sleep(1000 * this.Time);
            this.OnTimeIsOver(new TimeIsOverEventArgs(message));
        }

        /// <summary>
        /// Method that controls the event.
        /// </summary>
        /// <param name="eventArgs">Event arguments</param>
        private void OnTimeIsOver(TimeIsOverEventArgs eventArgs)
        {
            EventHandler<TimeIsOverEventArgs> eventHandler = this.TimeIsOver;
            eventHandler?.Invoke(this, eventArgs);
        }
    }
}