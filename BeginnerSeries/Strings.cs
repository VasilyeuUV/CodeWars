namespace CodeWarsConsoleApp.BeginnerSeries
{
    internal class Strings
    {
        /// <summary>
        /// Write a function that removes the spaces from the string, then return the resultant string.
        /// </summary>
        /// <param name="input">Input string</param>
        /// <returns></returns>
        public static string NoSpace(string input)
        {
            var s1 = string.Join("", input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            var s2 = input.Replace(" ", "");
            var s3 = string.Join("", input.Split());
            return s2;
        }

    }
}
