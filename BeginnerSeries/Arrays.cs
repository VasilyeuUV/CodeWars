namespace CodeWarsConsoleApp.BeginnerSeries
{
    public class Arrays
    {
        /// <summary>
        /// Return an array, where the first element is the count of positives numbers and the second element is sum of negative numbers.<br/>
        /// 0 is neither positive nor negative.<br/>
        /// If the input is an empty array or is null, return an empty array.
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Return an array with count of positives and sum of negatives</returns>
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            //// c#12
            //var arr1 = input is null || input.Length == 0
            //            ? []
            //            : [ input.Count(v => v > 0), input.Where(v => v < 0).Sum() ];

            return input is null || input.Length == 0
                ? Array.Empty<int>()
                : new int[] { input.Count(v => v > 0), input.Where(v => v < 0).Sum() };
        }


        /// <summary>
        /// Given a set of numbers, return the additive inverse of each.<br/>
        /// Each positive becomes negatives, and the negatives become positives.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int[] InvertValues(int[] input)
        {
            var arr1 = input.Select(v => v * -1).ToArray();
            var arr2 = input.Select(v => -v).ToArray();
            var arr3 = Array.ConvertAll(input, v => -v);
            return arr1;
        }


        /// <summary>
        /// Write a function that takes an array of numbers and returns the sum of the numbers.<br/>
        /// The numbers can be negative or non-integer.<br/>
        /// If the array does not contain any numbers then you should return 0.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static double SumArray(double[] array)
        {
            double value1 = array.Sum();

            double value2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                value2 += array[i];
            }
            return value2;
        }


        /// <summary>
        /// Create a function with two arguments that will return an array of the first n multiples of x.
        /// <code>
        /// countBy(1,10)  should return  {1,2,3,4,5,6,7,8,9,10}
        /// countBy(2,5)  should return {2,4,6,8,10}
        /// </code>
        /// </summary>
        /// <param name="x"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[] CountBy(int x, int n)
        {
            var arr1 = Enumerable.Range(1, n).Select(v => v * x).ToArray();

            int[] z = new int[n];
            for (int i = 1; i <= n; i++)
            {
                z[i - 1] = x * i;
            }
            return z;
        }
    }
}
