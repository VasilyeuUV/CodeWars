using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            return result;
        }


        /// <summary>
        /// Верните сумму значений массива, как если бы все они были числами.
        /// </summary>
        /// <param name="x">Массив целых чисел в виде строк и чисел</param>
        /// <returns>Ответ в виде числа</returns>
        public static int SumMix(object[] x)
        {
            var result = x.Sum(n => (int)(n is int ? n : int.Parse(n.ToString())));
            var result1 = x.Sum(Convert.ToInt32);   // using static System.Convert;

            return result;
        }


        /// <summary>
        /// Вернуть массив, в котором каждое значение удвоено.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int[] Maps(int[] x)
        {
            var result = x.Select(n => n * 2).ToArray();
            var result1 = x.Select(n => n << 1).ToArray();

            var result2 = Array.ConvertAll(x, n => n * 2);

            return result1;
        }


        /// <summary>
        /// Возвращает сумму двух наименьших положительных чисел.
        /// </summary>
        /// <param name="numbers">Массив из минимум 4 положительных целых чисел</param>
        /// <returns></returns>
        public static int SumTwoSmallestNumbers(int[] numbers)
            => numbers.OrderBy(x => x).Take(2).Sum();


        /// <summary>
        /// найти индекс N, при котором сумма целых чисел слева от N равна сумме целых чисел справа от N.
        /// <code>
        /// {1,2,3,4,3,2,1} => 3 (в 3-й позиции массива сумма левой части индекса ({1,2,3}) и сумма правой части индекса ({3,2,1}) равны 6.)
        /// пустые массивы равны 0
        /// </code>
        /// </summary>
        /// <param name="arr">массив целых чисел.</param>
        /// <returns>Позицию N или -1, если такой позиции нет.</returns>
        public static int FindEvenIndex(int[] arr)
        {
            var result = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                int sumLeft = arr.Take(i).Sum();
                int sumRight = arr.Skip(i + 1).Take(arr.Length).Sum();
                if (sumLeft == sumRight)
                    result = i;
            }

            var result1 = -1;
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr.Take(i).Sum() == arr.Skip(i + 1).Sum())
                    result1 = i;
            }

            var result2 = Enumerable.Range(0, arr.Length).ToList().FindIndex(i => arr[..i].Sum() == arr[(i + 1)..].Sum());
            var result3 = Enumerable.Range(0, arr.Length).Where(i => arr[..i].Sum() == arr[(i + 1)..].Sum()).DefaultIfEmpty(-1).First();
            var result4 = Enumerable.Range(0, arr.Length).FirstOrDefault(i => arr[..i].Sum() == arr[(i + 1)..].Sum(), -1);

            return result;
        }


        /// <summary>
        /// В массиве целых чисел найдите то, которое встречается нечетное количество раз.
        /// <code>
        /// [0,1,0,1,0] должно возвращать 0, потому что оно встречается 3 раза (что нечетно).
        /// </code>
        /// </summary>
        /// <param name="seq"></param>
        /// <returns></returns>
        public static int Find_it(int[] seq)
        {
            var result = seq.GroupBy(x => x).First(g => (g.Count() & 1) == 1).Key;
            var result1 = seq.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key;
            var result2 = seq.First(x => seq.Count(s => s == x) % 2 == 1);
            var result3 = seq.Aggregate(0, (a, b) => a ^ b);                        // дано любое число «а»:
                                                                                    // а ^ а = 0
                                                                                    // из-за ассоциативных и коммутативных свойств оператора XOR:
                                                                                    // а ^ б ^ а = а ^ а ^ б = (а ^ а) ^ б = 0 ^ б = б
                                                                                    // т.е. каждое «двойное» число можно свести к 0, и останется единственное число, которое встречается нечетное число раз.

            return result;
        }


        /// <summary>
        /// Определить, является ли сумма элементов массива четной (even) или нечетной (odd).<br/>
        ///  Если входной массив пуст, считайте его как: [0] (массив с нулем).
        ///  <code>
        ///  Input: [0]         Output: "even"
        ///  Input: [0, 1, 4]   Output: "odd"
        /// </code>
        /// </summary>
        /// <param name="array"></param>
        /// <returns>even или odd</returns>
        public static string OddOrEven(int[] array)
        {
            var result = (array.Sum() & 1) == 1 ? "odd" : "even";
            var result1 = array.Sum() % 2 == 0 ? "even" : "odd";
            var result2 = array.Aggregate(0, (a, c) => a + c) % 2 == 0 ? "even" : "odd";

            return result;
        }


        /// <summary>
        /// Вернутиь сумму вмех положительных чисел в массиве.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int PositiveSum(int[] arr)
        {
            var result = arr.Where(n => n > 0).Sum();
            var result1 = arr.Aggregate(0, (e, r) => (r > 0 ? r + e : e));

            return result;
        }


        /// <summary>
        /// Из массива целых чисел удалите наименьшее значение. Не изменяйте исходный массив/список. 
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static List<int> RemoveSmallest(List<int> numbers)
        {
            //if (numbers.Any())
            if (numbers.Count != 0)                     // рекомендация.
                numbers.Remove(numbers.Min());
            var result = numbers;

            numbers.Remove(numbers.DefaultIfEmpty().Min());

            var result2 = numbers.Where((x, i) => i != numbers.IndexOf(numbers.Min())).ToList();
            var result3 = numbers.Any() && numbers.Remove(numbers.Min()) ? numbers : new List<int>();

            return result;
        }


        /// <summary>
        /// Возвращает минимальное и максимальное число из заданного списка/массива.
        /// </summary>
        /// <param name="lst"></param>
        /// <returns></returns>
        public static int[] MinMax(int[] lst)
        {
            var result = new int[] { lst.Min(), lst.Max() };
            var result1 = new[] { lst.Min(), lst.Max() };

            return result;
        }


        /// <summary>
        /// Все дороги выстроены в идеальную сетку.<br/>
        /// Всегда один квартал для каждой буквы (направления)<br/>
        /// На прохождение одного квартала уходит одна минута.
        /// </summary>
        /// <param name="walk">Направления для прогулок (например, ['n', 's', 'w', 'e']).</param>
        /// <returns>true, если прогулка, которую вам назначит приложение, займет ровно десять минут </returns>
        public static bool IsValidWalk(string[] walk)
        {
            var d = walk.GroupBy(a => a);
            var result = walk.Length == 10
                ? d.FirstOrDefault(g => g.Key.Equals("n"))?.Count() == d.FirstOrDefault(g => g.Key.Equals("s"))?.Count()
                    && d.FirstOrDefault(g => g.Key.Equals("w"))?.Count() == d.FirstOrDefault(g => g.Key.Equals("e"))?.Count()
                : false;

            var result1 = walk.Count(x => x == "n") == walk.Count(x => x == "s")
                && walk.Count(x => x == "e") == walk.Count(x => x == "w")
                && walk.Length == 10;

            var result2 = walk.Length == 10
                && walk.Sum(s => new Dictionary<string, int> { { "n", 1 }, { "s", -1 }, { "e", 10 }, { "w", -10 } }[s]) == 0;

            return result;
        }


        /// <summary>
        /// Создайте новый список, который содержит каждое число из списка не более N раз, без переупорядочивания.
        /// <code>
        /// x = 2, arr = [1,2,3,1,2,1,2,3] => result = [1,2,3,1,2,3]
        /// x = 1, arr = [20,37,20,21] => result = [20,37,21]
        /// </code>>
        /// </summary>
        /// <param name="arr">Список</param>
        /// <param name="x">Число</param>
        /// <returns></returns>
        public static int[] DeleteNth(int[] arr, int x)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            List<int> result = new List<int>();
            foreach (int i in arr)
            {
                if (d.ContainsKey(i))       //  if (d.TryGetValue(i, out int value))
                {
                    if (d[i] < x)           //  if (value < x) 
                    {
                        d[i] += 1;
                        result.Add(i);
                    }
                }
                else
                {
                    result.Add(i);
                    d.Add(i, 1);
                }
            }

            var result1 = new List<int>();
            foreach (var item in arr)
            {
                if (result1.Count(i => i == item) < x)
                    result1.Add(item);
            }

            var result2 = arr.Where((t, i) => arr.Take(i + 1).Count(s => s == t) <= x).ToArray();       // это неэффективно - O(n^2) 

            var result3 = arr.Where((e, i) => arr.Where((f, j) => j <= i && e == f).Count() <= x).ToArray();

            var d4 = arr.Distinct().ToDictionary(n => n, _ => 0);
            var result4 = arr.Where(n => d4[n]++ < x).ToArray();

            return result.ToArray();
        }


        /// <summary>
        /// Отсортировать нечетные числа в порядке возрастания, оставив четные числа на прежних местах.
        /// <code>
        /// [5, 8, 6, 3, 4]  =>  [3, 8, 6, 5, 4]
        /// [9, 8, 7, 6, 5, 4, 3, 2, 1, 0]  =>  [1, 8, 3, 6, 5, 4, 7, 2, 9, 0]
        /// </code>
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] SortArray(int[] array)
        {
            Queue<int> odds = new Queue<int>(array.Where(n => (n & 1) == 1).OrderBy(n => n));
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] & 1) == 1)
                {
                    array[i] = odds.Dequeue();
                }
            }
            var result = array;

            Queue<int> odds1 = new Queue<int>(array.Where(e => e % 2 == 1).OrderBy(e => e));
            var result1 = array.Select(e => e % 2 == 1 ? odds.Dequeue() : e).ToArray();

            return result;
        }


        /// <summary>
        /// Удалить все значения из списка a, которые присутствуют в списке b, сохраняя их порядок.<br/>
        /// Если значение присутствует в b, все его вхождения должны быть удалены из другого
        /// <code>
        /// ArrayDiff(new int[] {1, 2}, new int[] {1}) => new int[] {2}
        /// ArrayDiff(new int[] {1, 2, 2, 2, 3}, new int[] {2}) => new int[] {1, 3}
        /// </code>
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            var result = a.Where(ai => !b.Contains(ai)).ToArray();

            var sb = new HashSet<int>(b);
            var result1 = Array.FindAll(a, x => !sb.Contains(x));

            return result;
        }


        /// <summary>
        /// Удалить из массива каждый второй элемент. 
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static object[] RemoveEveryOther(object[] arr)
        {
            var result = arr.Where((e, i) => (i & 1) == 0).ToArray();
            var result1 = arr.Where((e, i) => i % 2 == 0).ToArray();

            var s = false;
            var result2 = arr.Where(x => s = !s).ToArray();

            return result;
        }


        /// <summary>
        /// Проверяет, есть ли в двух массивах "одинаковые" элементы с одинаковой кратностью<br/>
        /// (кратность члена - это количество раз, которое он встречается).
        /// <code>
        /// a = [121, 144, 19, 161, 19, 144, 19, 11]  
        /// b = [121, 14641, 20736, 361, 25921, 361, 20736, 361]
        /// comp(a, b) возвращает true, потому что в b:
        /// - 121 - квадрат 11, 
        /// - 14641 - квадрат 121, 
        /// - 20736 - квадрат 144, 
        /// - 361 - квадрат 19, 
        /// 25921 - квадрат 161, 
        /// и так далее.
        /// 
        /// Это становится очевидным, если записать элементы b в терминах квадратов:
        /// b = [11*11, 121*121, 144*144, 19*19, 161*161, 19*19, 144*144, 19*19]
        /// </code>
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool Comp(int[] a, int[] b)
        {
            //a = [121, 144, 19, 161, 19, 144, 19, 11];
            //b = [121, 14641, 20736, 361, 25921, 361, 20736, 361];
            if (b == null || a.Length != b.Length)
                return false;
            var listB = b.ToList();
            foreach (int ai in a)
            {
                listB.Remove(listB.FirstOrDefault(bi => bi == ai * ai));
            }
            var result = listB.Count == 0;


            var result1 = a != null 
                        && b != null 
                        && a.Select(v => v * v)
                            .OrderBy(v => v)
                            .SequenceEqual(b.OrderBy(v => v));

            var result2 = a != null                                                     // !!!
                        && b != null
                        && a.Length == b.Length
                        && a.Sum(x => x * x) == b.Sum();

            return result;
        }
    }
}
