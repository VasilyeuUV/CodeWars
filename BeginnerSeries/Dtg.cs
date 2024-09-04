namespace CodeWarsConsoleApp.BeginnerSeries
{
    internal class Dtg
    {
        /// <summary>
        /// Write a function which returns the time since midnight in milliseconds
        /// </summary>
        /// <param name="h">hours after midnight.</param>
        /// <param name="m">minutes after midnight.</param>
        /// <param name="s"> seconds after midnight.</param>
        /// <returns></returns>
        public static int Past(int h, int m, int s)
        {
            var difference1 = (int)((new TimeOnly(h, m, s)) - TimeOnly.MinValue).TotalMilliseconds;
            var difference2 = (int)(new TimeSpan(h, m, s)).TotalMilliseconds;
            return difference1;
        }
    }
}
