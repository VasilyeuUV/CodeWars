using System.Data;
using System.Linq;

namespace CodeWarsConsoleApp.BeginnerSeries
{
    internal class Operations
    {
        /// <summary>
        /// create a function that does four basic mathematical operations.
        /// </summary>
        /// <param name="operation">string/char</param>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns>The function should return result of numbers after applying the chosen operation.</returns>
        public static double basicOp(char operation, double value1, double value2)
        {
            double result1 = operation switch
            {
                '+' => value1 + value2,
                '-' => value1 - value2,
                '*' => value1 * value2,
                '/' => value1 / value2,
                _ => -1
            };
            double result2 = Convert.ToDouble(new DataTable().Compute($"{value1}{operation}{value2}", ""));
            return result2;
        }


        /// <summary>
        /// Function that tells you if it is possible to get to the pump or not.
        /// </summary>
        /// <param name="distanceToPump"></param>
        /// <param name="mpg">car runs on about 25 miles per gallon</param>
        /// <param name="fuelLeft">gallons left</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft)
        {
            var result1 = distanceToPump <= mpg * fuelLeft;

            return result1;
        }


        /// <summary>
        /// omplete the square sum function so that it squares each number passed into it and then sums the results together.<br/>
        /// For example, for [1, 2, 2] it should return 9 because 
        /// <code>
        /// 1^2 + 2^2 + 2^2 = 9
        /// </code>
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int SquareSum(int[] numbers)
        {
            var sum1 = numbers.Select(x => x * x).Sum();
            var sum2 = numbers.Sum(i => i * i);

            return sum1;
        }


        /// <summary>
        /// To square every digit of a number and concatenate them.
        /// <code>
        /// An input of 765 will/should return 493625 because 7^2 is 49, 6^2 is 36, and 5^2 is 25. (49-36-25)
        /// </code>
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int SquareDigits(int n)
        {
            var result = Convert.ToInt32(string.Join("", n.ToString().ToArray().Select(c => (int)Math.Pow(Convert.ToInt32(c.ToString()), 2))));
            var result1 = int.Parse(String.Concat(n.ToString().Select(a => (int)Math.Pow(char.GetNumericValue(a), 2))));

            return result;
        }
    }
}
