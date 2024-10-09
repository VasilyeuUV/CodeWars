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


        /// <summary>
        /// Задав год, верните век, в котором он находится.
        /// </summary>
        /// <param name="year"></param>
        /// <returns>
        /// <code>
        /// 1705 --> 18
        /// 1900 --> 19
        /// </code>
        /// </returns>
        public static int СenturyFromYear(int year)
        {
            var result =  (int)Math.Ceiling(year / 100m);
            var result1 = (year + 99) / 100;

            return result;
        }




    }
}
