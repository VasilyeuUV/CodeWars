using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsConsoleApp.BeginnerSeries
{
    internal class Numbers
    {
        /// <summary>
        /// Code as fast as you can! You need to double the integer and return it.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int DoubleInteger(int n)
            => n << 1;


        /// <summary>
        /// Cоздать функцию, которая может принимать в качестве аргумента любое неотрицательное целое число и возвращать его с цифрами в порядке убывания.
        /// <code>
        /// Example - Input: 42145 Output: 54421
        /// </code>
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int DescendingOrder(int num)
        {
            var result = Convert.ToInt32(string.Join("", num.ToString().ToArray().OrderByDescending(ch => ch)));
            var result1 = int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));

            return result;
        }


        /// <summary>
        /// Вернуть сумму всех чисел от 1 до num.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int Summation(int num)
        {
            var result = Enumerable.Range(1, num).Sum();
            var result1 = num * ++num / 2;

            return result;
        }


        /// <summary>
        /// Сделать число отрицательным.
        /// </summary>
        /// <code>
        /// MakeNegative(1);  return -1
        /// MakeNegative(-5); return -5
        /// MakeNegative(0);  return 0
        /// </code> 
        /// <param name="number"></param>
        /// <returns></returns>
        public static int MakeNegative(int number)
        {
            var result = number > 0 ? -number : number;
            var result1 = -Math.Abs(number);
            var result2 = Math.Min(number, -number);
            var result3 = (number >> 31) - (number ^ (number >> 31));

            return result;
        }


        /// <summary>
        /// Быстрое целочисленное возведение в степень.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="power"></param>
        /// <returns></returns>
        public static long IntPower(int x, short power)
        {
            if (power == 0)
                return 1;
            if (power == 1)
                return x;

            int n = 15;
            while ((power <<= 1) >= 0)
                n--;

            long tmp = x;
            while (--n > 0)
                tmp = tmp * tmp * (((power <<= 1) < 0) ? x : 1);

            return tmp;
        }


        /// <summary>
        /// Определить, является ли переданное число четным (even).<br/>
        /// Плавающие числа с десятичной частью, не равной нулю, считаются нечетными для этого ката.
        /// </summary>
        /// <param name="n">положительное или отрицательное целое или плавающее</param>
        /// <returns>true, либо false.</returns>
        public static bool IsEven(double n)
        {
            var result = n == Math.Truncate(n)
                        && (Math.Abs(n) % 2) == 0;

            var result1 = n % 2 == 0;

            return result;
        }
    }
}
