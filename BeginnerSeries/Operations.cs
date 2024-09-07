using System.Data;
using System.Linq;
using System.Text.RegularExpressions;

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
    }
}
