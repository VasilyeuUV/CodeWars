using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;

namespace CodeWarsConsoleApp.BeginnerSeries
{
    internal class Operations
    {
        /// <summary>
        /// Calculate the required number of blank sheets.
        /// </summary>
        /// <param name="n">Number of classmates.</param>
        /// <param name="m">Number of pages in paperwork.</param>
        /// <returns></returns>
        public static int Paperwork(int n, int m)
            => n < 0 || m < 0 ? 0 : m * n;


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


        /// <summary>
        /// Вычислите среднее значение и сравните свои баллы.<br/>
        /// Ваши баллы не входят в массив баллов вашего класса. 
        /// </summary>
        /// <param name="ClassPoints">Массив с результатами тестов</param>
        /// <param name="YourPoints"> свои баллы</param>
        /// <returns>true, если вы лучше, иначе false</returns>
        public static bool BetterThanAverage(int[] classPoints, int yourPoints)
            => classPoints.Average() < yourPoints;


        /// <summary>
        /// Вычислите сумму чисел в n-й строке этого треугольника
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long RowSumOddNumbers(long n)
        {
            int[][] arr = {
                new int[] { 1 },
                new int[] { 3, 5 },
                new int[] { 7, 9, 11 },
                new int[] { 13, 15, 17, 19 },
                new int[] { 21, 23, 25, 27, 29 }
            };

            var result = ((n * n - n + 1) + (n * n + n - 1)) / 2 * n;
            var result1 = n * n * n;
            var result2 = (long)Math.Pow(n, 3);

            return result;
        }


        /// <summary>
        /// Найти среднее значение из трех переданных оценок и вернуть буквенное значение, связанное с этой оценкой.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <param name="s3"></param>
        /// <returns></returns>
        public static char GetGrade(int s1, int s2, int s3)
        {
            var a = (s1 + s2 + s3) / 3;
            var result = a >= 90 ? 'A'
                : a >= 80 ? 'B'
                : a >= 70 ? 'C'
                : a >= 60 ? 'D'
                : 'F';

            var result1 = ((s1 + s2 + s3) / 30) switch
            {
                10 => 'A',
                9 => 'A',
                8 => 'B',
                7 => 'C',
                6 => 'D',
                _ => 'F'
            };

            var dict = new Dictionary<int, char>
            {
                { 90, 'A' },
                { 80, 'B' },
                { 70, 'C' },
                { 60, 'D' },
                { 0, 'F' },
            };
            var result2 = dict.First(e => (new int[] { s1, s2, s3 }).Average() >= e.Key).Value;

            int s = (s1 + s2 + s3) / 3;
            var result3 = s >= 60
                ? (char)(74 - s / 10 + s / 100)
                : 'F';

            return result;
        }


        /// <summary>
        /// Камень-ножницы-бумага. вернуть, кто из игроков выиграл.
        /// <code>
        /// "scissors", "paper" --> "Player 1 won!"
        /// "scissors", "rock" --> "Player 2 won!"
        /// "paper", "paper" --> "Draw!"
        /// </code>
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public string Rps(string p1, string p2)
        {
            Dictionary<string, string> wons = new Dictionary<string, string>()
            {
                { "scissors", "paper" },
                { "paper", "rock" },
                { "rock", "scissors" },
            };
            var result = p1.Equals(p2, StringComparison.OrdinalIgnoreCase) ? "Draw!"
                : wons[p1].Equals(p2, StringComparison.OrdinalIgnoreCase) ? "Player 1 won!"
                : "Player 2 won!";

            string r = (p1[0] + p2[0]).ToString();
            var p = r == "sp" || r == "rs" || r == "pr" ? 1 : 2;
            var result1 = p1 == p2 ? "Draw!" : $"Player {p} won!";

            var result2 = p1 == p2
                ? "Draw!"
                : $"Player {(new[] { 3, -1, -2 }.Contains(p1[0] - p2[0]) ? 1 : 2)} won!";

            HashSet<string> map = new HashSet<string> { "scissorspaper", "paperrock", "rockscissors" };
            var result3 = p1 == p2
                ? "Draw!"
                : map.Contains(p1 + p2) ? "Player 1 won!" : "Player 2 won!";

            return result;
        }


        /// <summary>
        /// установить будильник,
        /// </summary>
        /// <param name="employed">true, когда вы работаете</param>
        /// <param name="vacation">true, когда вы в отпуске</param>
        /// <returns>true, если вы работаете и не в отпуске</returns>
        public static bool SetAlarm(bool employed, bool vacation)
            => employed && !vacation;


        /// <summary>
        /// Вычислить индекс массы тела (bmi = вес/рост2)
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static string Bmi(double weight, double height)
        {
            var result = (weight / (height * height)) switch
            {
                <= 18.5 => "Underweight",
                <= 25.0 => "Normal",
                <= 30.0 => "Overweight",
                _ => "Obese"
            };

            var result1 = (weight = weight / height / height) > 30 ? "Obese"
                : weight > 25 ? "Overweight"
                : weight > 18.5 ? "Normal"
                : "Underweight";

            return result;
        }


        /// <summary>
        /// Вернуть количество литров, округлив до наименьшего значения.<br/>
        /// Расход 0,5 литра воды за час езды
        /// </summary>
        /// <param name="time">время в часах</param>
        /// <returns></returns>
        public static int Litres(double time)
        {
            var result = (int)Math.Floor(0.5 * time);

            var result1 = (int)(time / 2);
            var result2 = (int)(time * 0.5);
            var result3 = (int)time >> 1;

            return result;
        }


        /// <summary>
        /// Рассчитать общую сумму ренты за разное количество дней.<br/>
        /// Каждый день аренды автомобиля стоит 40 долларов.<br/>
        /// Если вы арендуете машину на 7 или более дней, то получите скидку 50 долларов.<br/>
        /// Если вы арендуете автомобиль на 3 или более дней, вы получите скидку $20. 
        /// </summary>
        /// <param name="d">Количество дней.</param>
        /// <returns></returns>
        public static int RentalCarCost(int d)
        {
            var sum = 40 * d;
            var result = d >= 7 ? sum - 50
                : d >= 3 ? sum - 20
                : sum;

            var result1 = d * 40 - (d > 6 ? 50 : d > 2 ? 20 : 0);

            return result;
        }


        /// <summary>
        /// Ребенок бросает мяч из окна высокого здания. Мяч отскакивает.<br/>
        /// Сколько раз мяч пролетит мимо наблюдаемой высоты.<br/>
        /// Мяч можно увидеть, только если высота отскочившего мяча строго больше параметра window.
        /// <code>
        /// h = 3, bounce = 0.66, window = 1.5, result is 3
        /// </code>
        /// </summary>
        /// <param name="h">Высота этажа над уровнем земли > 0</param>
        /// <param name="bounce">Коэффициент отскока мяча. 0 > b > 1</param>
        /// <param name="window">Высота, через которое виден пролетающий мяч. меньше h</param>
        /// <returns>Количество пролетов мяча мимо наблюдателя или -1</returns>
        public static int BouncingBall(double h, double bounce, double window)
        {
            if (h <= 0 || bounce <= 0 || bounce >= 1 || window >= h)
                return -1;
            int count = 0;
            do
            {
                ++count;
                h *= bounce;
            } while (h > window);
            var result = count * 2 - 1;

            var result1 = 2 + BouncingBall(h * bounce, bounce, window);
            var result2 = (int)Math.Log(window / h, bounce) * 2 + 1;                 // !!!

            var result3 = h > 0 && bounce > 0 && bounce < 1 && window < h
                ? h < window
                    ? -1
                    : 2 + BouncingBall(h * bounce, bounce, window)
                : -1;

            int countA;
            for (countA = -1; h > window && bounce > 0 && bounce < 1; h *= bounce)
                countA += 2;
            var result4 = count;

            return result;
        }


        /// <summary>
        /// Если у одного из цветков четное количество лепестков, а у другого - нечетное, вернуть true, иначе - false
        /// </summary>
        /// <param name="flower1">количество лепестков цветка 1</param>
        /// <param name="flower2">количество лепестков цветка 2</param>
        /// <returns></returns>
        public static bool Lovefunc(int flower1, int flower2)
        {
            var result = ((flower1 + flower2) & 1) == 1;
            var result2 = Convert.ToBoolean((flower1 ^ flower2) & 1);
            var result1 = (flower1 + flower2) % 2 == 1;

            return result;
        }


        /// <summary>
        /// Объединить расположенные рядом одинаковые элементы.<br/>
        /// <code>
        /// uniqueInOrder("ABBCcAD") == {'A', 'B', 'C', 'c', 'A', 'D'}
        /// uniqueInOrder([1,2,2,3,3]) == {1,2,3}
        /// </code>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="iterable"></param>
        /// <returns></returns>
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            var result = new List<T>();
            var arr = iterable.ToArray();
            for (int i = 0; i < iterable.Count(); i++)
            {
                if (i == 0 || !arr[i].Equals(arr[i - 1]))
                {
                    result.Add(arr[i]);
                }
            }
            //return result;

            T previous = default(T);
            foreach (T current in iterable)
            {
                if (!current.Equals(previous))
                {
                    previous = current;
                    yield return current;
                }
            }

            foreach (var element in iterable)
                if (!element.Equals(result.LastOrDefault()))
                    result.Add(element);

            var result1 = iterable.Where((x, i) => i == 0 || !Equals(x, iterable.ElementAt(i - 1)));        // !!!

            var array = iterable.ToArray();
            var result2 = array.Where((a, i) => i == 0 || Comparer<T>.Default.Compare(a, array[i - 1]) != 0);
        }


        /// <summary>
        /// Найти число кубиков, чтобы построить здание требуемого объема.<br/>
        /// Куб внизу будет иметь объем (n-1)^3<br/>
        /// Куб выше будет иметь объем 1^3
        /// <code>
        /// n^3 + (n−1)^3 + (n−2)^3 + ... + 1^3 = m
        /// findNb(1071225) --> 45
        /// findNb(91716553919377) --> -1
        /// </code>
        /// </summary>
        /// <param name="m">Общий объем здания</param>
        /// <returns>Вернуть целое число n,</returns>
        public static long FindNb(long m)
        {
            int n = 0;
            long v = 0;
            while (v < m)
            {
                v += (long)Math.Pow(++n, 3.0);
            }
            var result = v == m ? n : -1;

            long total = 1, i = 2;
            for (; total < m; i++)
                total += i * i * i;
            var result1 = total == m ? i - 1 : -1;

            long n2 = (long)Math.Floor(Math.Sqrt(2 * Math.Sqrt(m)));
            var result2 = ((n * (n + 1)) / 2) * ((n * (n + 1)) / 2) == m ? n : -1;

            long i3 = 1;
            while (m > 0)
                m -= i * i * i++;
            var result3 = m == 0 ? --i : -1;

            return result;
        }


        /// <summary>
        /// Посчитать, может ли автобус вместить всех пассажиров. 
        /// </summary>
        /// <param name="cap">количество людей, которое может вместить автобус, исключая водителя. </param>
        /// <param name="on">оличество людей в автобусе, исключая водителя</param>
        /// <param name="wait">количество людей, ожидающих посадки в автобус, исключая водителя. </param>
        /// <returns>Если места достаточно, верните 0, а если нет, верните количество пассажиров, которых не влезут в автобус.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static int Enough(int cap, int on, int wait)
        {
            var result = cap > on + wait ? 0 : on + wait - cap;
            var result1 = Math.Max(on + wait - cap, 0);

            return result;
        }


        /// <summary>
        /// Вероятность выживания в сражении с драконами.<br/>
        /// На одного дракона нужно две пули.
        /// </summary>
        /// <param name="bullets">Количество пуль</param>
        /// <param name="dragons">Количество драконов</param>
        /// <returns>true если пуль хватит на всех драконов </returns>
        public static bool Hero(int bullets, int dragons)
        {
            var result = bullets >= dragons << 1;

            return result;
        }


        /// <summary>
        /// Функция, которая вычислит общее время, необходимое всем покупателям для оформления заказа (РАСПРЕДЕЛЕНИЕ ОЧЕРЕДИ).
        /// <code>
        /// queueTime([10,2,3,3], 2) => 10 - потому что здесь n=2 и 2-й, 3-й и 4-й люди в очереди заканчивают работу до того, как закончит 1-й человек.
        /// queueTime([2,3,10], 2) => 12 - после второго станет 10-й
        /// </code>
        /// </summary>
        /// <param name="customers">Очередь. Каждое число - покупатель, его значение - количество времени, которое требуется покупателю для оформления заказа.</param>
        /// <param name="n">Количество касс</param>
        /// <returns>Общее время, необходимое для оформления заказа</returns>
        public static long QueueTime(int[] customers, int n)
        {
            int[] tills = new int[n];
            for (int i = 0; i < customers.Length; i++)
            {
                int index = Array.IndexOf(tills, tills.Min());
                tills[index] += customers[i];
            }
            var result = tills.Max();

            var tills1 = new List<int>(Enumerable.Repeat(0, n));
            foreach (int cust in customers)
            {
                tills1[tills1.IndexOf(tills1.Min())] += cust;
            }
            var result1 = tills1.Max();

            var result2 = customers.Aggregate(new int[n], (a, i) =>
            {
                a[Array.IndexOf(a, a.Min())] += i;
                return a;
            }).Max();

            return result;
        }


        /// <summary>
        /// Вычислите, сколько лет назад отцу было вдвое больше лет, чем его сыну (или через сколько лет ему будет вдвое больше лет). 
        /// </summary>
        /// <param name="dadYears">текущий возраст отца (лет)</param>
        /// <param name="sonYears">текущий возраст его сына (лет) </param>
        /// <returns></returns>
        public static int TwiceAsOld(int dadYears, int sonYears)
        {
            int result = 0;
            while (sonYears == 0 || (float)dadYears / sonYears != 2.0)
            {
                if (dadYears - sonYears > sonYears)
                {
                    ++dadYears;
                    ++sonYears;
                }
                else
                {
                    --dadYears;
                    --sonYears;
                }
                ++result;
            }

            var result1 = Math.Abs(dadYears - sonYears * 2);

            return result;
        }


        /// <summary>
        /// Количество очков, которые команда Х получила в чемпионате.
        /// <code>
        /// если x > y - 3 очка (победа),
        /// если x < y - 0 очков (поражение),
        /// если x = y - 1 очко (ничья)
        /// Команда всегда играет 10 матчей в чемпионате 
        /// 0 <= x <= 4 
        /// 0 <= y <= 4
        /// </code>
        /// </summary>
        /// <param name="games">
        /// Результаты матчей нашей команды записаны в набор строк.<br/>
        /// <code>
        /// For example: ["3:1", "2:2", "0:1", ...]
        /// </code>
        /// </param>
        /// <returns></returns>
        public static int TotalPoints(string[] games)
        {
            games = new[] { "1:0", "2:0", "3:0", "4:0", "2:1", "3:1", "4:1", "3:2", "4:2", "4:3" };
            var result = games
                .Select(g => g
                    .Split(':')
                    .Select(v => int.Parse(v))
                    .Aggregate((x, y) => x > y ? 3
                                        : x == y ? 1
                                        : 0))
                .Sum();

            var result1 = games.Sum(s => s[0] > s[2] ? 3 
                                        : s[0] == s[2] ? 1 
                                        : 0);

            var result3 = games
                .Select(x => x[0] == x[2] ? 1 
                            : x[0] > x[2] ? 3 
                            : 0)
                .Sum();

            var result2 = games.Where(x => x[0] > x[2]).Count() * 3 
                        + games.Where(y => y[0] == y[2]).Count();

            return result;
        }


        /// <summary>
        /// Фиббоначи. Вернуть F(n) - наименьшее из них, такое, что F(n) * F(n+1) > prod
        /// <code>
        /// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ...
        /// F(n) = F(n-1) + F(n-2) with F(0) = 0 and F(1) = 1.
        /// </code>
        /// Примеры:
        /// <code>
        /// productFib(714) # should return (21, 34, true), 
        ///                 # since F(8) = 21, F(9) = 34 and 714 = 21 * 34
        ///                 
        /// productFib(800) # should return (34, 55, false), 
        ///                 # since F(8) = 21, F(9) = 34, F(10) = 55 and 21 * 34 меньше 800 меньше 34 * 55
        /// 
        /// productFib(714) # should return [21, 34, true], 
        /// productFib(800) # should return [34, 55, false], 
        /// 
        /// productFib(714) # should return {21, 34, 1}, 
        /// productFib(800) # should return {34, 55, 0}, 
        /// </code>
        /// </summary>
        /// <param name="prod">Целое число для формирования массива </param>
        /// <returns>Если F(n) * F(n+1) = prod - Массив:
        /// <code>
        /// [F(n), F(n+1), true] or {F(n), F(n+1), 1} or (F(n), F(n+1), True)
        /// </code>
        /// Если F(n) * F(n+1) != prod - Массив:
        /// <code>
        /// [F(n), F(n+1), false] or {F(n), F(n+1), 0} or (F(n), F(n+1), False)
        /// </code>>
        /// </returns>
        public static ulong[] ProductFib(ulong prod)
        {
            ulong a = 0;
            ulong b = 1;
            while (a * b < prod)
            {
                b = a + b;
                a = b - a;
            }
            ulong[] result = a * b == prod 
                ? [a, b, 1]
                : [a, b, 0];


            (ulong a1, ulong b1) = (0, 1);
            while (prod > a1 * b1)
            {
                (a1, b1) = (b1, a1 + b1);
            }
            var result1 = new[] { a1, b1, (ulong)(prod == a1 * b1 ? 1 : 0) };


            (ulong a2, ulong b2) t = (0, 1);
            while (t.a2 * t.b2 < prod)
            {
                t = (t.b2, t.a2 + t.b2);
            }
            var result2 = new ulong[] { t.a2, t.b2, (t.a2 * t.b2 == prod) ? 1UL : 0UL };


            return result;
        }



    }
}
