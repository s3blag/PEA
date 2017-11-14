using System.Diagnostics;

namespace Project_1
{
    /// <summary>
    ///     Stopwatch wrapper.
    /// </summary>
    public static class Clock
    {
        private static readonly Stopwatch Stopwatch = new Stopwatch();

        /// <summary>
        ///     Reset and start.
        /// </summary>
        public static void Start()
        {
            Stopwatch.Reset();
            Stopwatch.Start();
        }

        /// <summary>
        ///     Start after stopping, without cleaning current elapsed time.
        /// </summary>
        public static void Continue()
        {
            Stopwatch.Start();
        }

        /// <summary>
        ///     Stops the clock.
        /// </summary>
        public static void Stop()
        {
            Stopwatch.Stop();
        }

        /// <summary>
        ///     Stops and returns total elapsed miliseconds.
        /// </summary>
        /// <returns>Total elapsed miliseconds.</returns>
        public static double StopAndReturn()
        {
            Stopwatch.Stop();
            return Stopwatch.Elapsed.TotalMilliseconds;
        }

        /// <summary>
        ///     Returns total elapsed miliseconds.
        /// </summary>
        /// <returns>Total elapsed miliseconds.</returns>
        public static double ReturnElapsed()
        {
            return Stopwatch.Elapsed.TotalMilliseconds;
        }
    }
}
