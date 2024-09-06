using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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




        /// <summary>
        /// return the lowest number in that list
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Min(int[] list)
        {
            var result1 = list.Min();

            var result3 = int.MaxValue;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] < result3)
                {
                    result3 = list[i];
                }
            }

            return result3;
        }


        /// <summary>
        /// return the largest number in that list
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Max(int[] list)
        {
            var result1 = list.Max();

            Array.Sort(list);
            var result2 = list[^1];

            var result3 = int.MinValue;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] > result3)
                {
                    result3 = list[i];
                }
            }

            return result3;
        }


        /// <summary>
        /// Calculates the average of the numbers in a given list.<br/>
        /// Note: Empty arrays should return 0.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static double FindAverage(double[] array)
        {
            var result1 = array.Length == 0 ? 0 : array.Average();
            var result2 = array.Length == 0 ? 0 : array.Sum() / array.Length;
            var result4 = array.Any() ? array.Average() : 0;
            var result5 = array.DefaultIfEmpty().Average();

            var result3 = 0d;
            for (int i = 0; i < array.Length; i++)
            {
                result3 += array[i];
            }
            result3 /= array.Length;

            return result3;
        }


        /// <summary>
        /// Найти наименьшее целоче число в массиве.
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static int FindSmallestInt(int[] args)
        {
            Array.Sort(args);
            var result = args[0];

            var result1 = args.Min();
            var result2 = Enumerable.Min(args);
            var result3 = unchecked(-args.Select(n => ~n).Max() + (-1));
            var result4 = args.OrderBy(a => a).First();

            return result;
        }


        /// <summary>
        /// Вернуть результат умножения значений массива по порядку
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int Grow(int[] x)
        {
            int result = 0;
            for (int i = 0; i < x.Length; i++)
                result *= x[i];

            var result1 = x.Aggregate((a, b) => a * b);

            return result;
        }


        /// <summary>
        /// Преобразование числа в обратный массив цифр.
        /// <code>
        /// 35231 => [1,3,2,5,3]
        /// </code>
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long[] Digitize(long n)
        {
            var result = n.ToString().Reverse().Select(ch => Convert.ToInt64(char.GetNumericValue(ch))).ToArray();
            var result1 = n.ToString().Reverse().Select(x => long.Parse(x.ToString())).ToArray();
            var result2 = $"{n}".Select(c => (long)c - '0').Reverse().ToArray();
        }
    }
}
