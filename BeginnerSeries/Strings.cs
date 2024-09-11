using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using static System.Text.RegularExpressions.Regex;

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


        /// <summary>
        /// Write a function which converts the input string to uppercase.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string MakeUpperCase(string str)
            => str.ToUpper();


        /// <summary>
        /// В строках ДНК символы "A" и "T" являются дополнением друг друга, как и "C" и "G".<br/>
        /// Функция получает одну сторону ДНК, нужно вернуть другую, комплементарную ей сторону.
        /// </summary>
        /// <param name="dna"></param>
        /// <returns></returns>
        public static string MakeComplement(string dna)
        {
            Dictionary<char, char> chars = new Dictionary<char, char>()
            {
                { 'A', 'T' },
                { 'T', 'A' },
                { 'C', 'G' },
                { 'G', 'C' },
            };
            Queue<char> queue = new Queue<char>(dna);
            List<char> lst = new List<char>();
            while (queue.Count > 0)
            {
                var ch = queue.Dequeue();
                lst.Add(chars.ContainsKey(ch) ? chars[ch] : ch);
            }
            var result = string.Join("", lst);

            var mychars = dna.ToCharArray();
            var result1 = new string(mychars.Select(x => chars[x]).ToArray());

            var result2 = string.Join("",
                            from ch in dna
                            select "AGCT"["TCGA".IndexOf(ch)]
                            );

            var result3 = string.Concat(dna.Select(c => "AGCT"["TCGA".IndexOf(c)]));

            var result4 = dna.Replace('A', 't').Replace('C', 'g').Replace('T', 'a').Replace('G', 'c')
                            .ToUpper();

            var result5 = Replace(dna, ".", m => $"{"TAGC"["ATCG".IndexOf(m.Value[0])]}");      // using static System.Text.RegularExpressions.Regex;

            return result;
        }


        /// <summary>
        /// Перевести заданную строку ДНК в РНК.<br/>
        /// ДНК является основной молекулой хранения информации в биологических системах.<br/>
        /// Она состоит из четырех оснований нуклеиновой кислоты - гуанина ("G"), цитозина ("C"), аденина ("A") и тимина ("T").<br/>
        /// Рибонуклеиновая кислота, РНК, - это основная молекула-мессенджер в клетках.<br/>
        /// Она отличается от ДНК по химической структуре и не содержит тимина. В РНК тимин заменен другой нуклеиновой кислотой урацилом ("U"). 
        /// </summary>
        /// <param name="dna"></param>
        /// <returns></returns>
        public string DnaToRna(string dna)
        {
            var result = dna.Replace("T", "U");
            var result1 = Regex.Replace(dna, @"T", "U");

            return result;
        }



        /// <summary>
        /// return, "Hello, <name> how are you doing today?"
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string Greet(string name)
            => $"Hello, {name} how are you doing today?";


        /// <summary>
        /// Возвращает каждую строку, дополненную нужным номером. 
        /// </summary>
        /// <param name="lines"></param>
        /// <returns></returns>
        public static List<string> Number(List<string> lines)
            => lines
                .Select((x, i) => $"{++i}: {x}")
                .ToList();


        /// <summary>
        /// Преобразование имени в инициалы. 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string AbbrevName(string name)
            => string.Join(".", name.Split(' ').Select(n => n[0])).ToUpper();


        /// <summary>
        /// Преобразовать строку в новую строку, где каждый символ в новой строке будет:<br/>
        /// - "(", если этот символ встречается в исходной строке только один раз,<br/>
        /// - ")", если этот символ встречается в исходной строке более одного раза.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static string DuplicateEncode(string word)
        {
            var chars = word.ToLower().ToArray();
            var charGroups = chars.GroupBy(ch => ch);
            var result = string.Concat(chars.Select(ch => charGroups.First(g => g.Key == ch).Count() > 1 ? ')' : '('));

            var result1 = new string(word.ToLower().Select(ch => word.ToLower().Count(innerCh => ch == innerCh) == 1 ? '(' : ')').ToArray());
            var result2 = string.Concat(word.ToLower().Select(ch => word.ToLower().Count(x => x == ch) > 1 ? ')' : '('));
            var result6 = string.Join("", word.ToLower().Select(ch => word.ToLower().Count(x => x == ch) > 1 ? ')' : '('));
            var result3 = string.Concat(word.ToLower().Select(ch => word.ToLower().Split(ch).Length == 2 ? "(" : ")"));
            var result4 = string.Concat(word.ToLower().Select(ch => word.ToLower().Where(x => x == ch).Count() == 1 ? "(" : ")"));
            var result5 = new string(word.ToLower().Select(ch => (word.ToLower().IndexOf(ch) == word.ToLower().LastIndexOf(ch)) ? '(' : ')').ToArray());

            return result;
        }


        /// <summary>
        /// преобразовать строку в число.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int StringToNumber(String str)
        {
            var result = int.TryParse(str, out var number) ? number : default;
            var result1 = int.Parse(str);
            var result2 = Convert.ToInt32(str);

            return result;
        }


        /// <summary>
        /// Удалить все ! из строки.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string RemoveExclamationMarks(string s)
        {
            var result = s.Replace("!", "");
            var result1 = string.Join("", s.Split('!'));
            var result2 = string.Concat(s.Split('!'));

            return result;
        }


        /// <summary>
        /// Создайте функцию, которая отвечает на вопрос "Играете ли вы на банджо?".<br/>
        /// Если ваше имя начинается с буквы "R" или строчной буквы "r", то вы играете на банджо! и :
        /// </summary>
        /// <param name="name">Функция принимает имя в качестве единственного аргумента </param>
        /// <returns>возвращает одну из следующих строк: name + " plays banjo"; name + " does not play banjo"</returns>
        public static string AreYouPlayingBanjo(string name)
        {
            var result = name.StartsWith("r", StringComparison.OrdinalIgnoreCase)
                ? $"{name} plays banjo"
                : $"{name} does not play banjo";

            var result1 = name.ToLower()[0] == 'r' 
                ? name + " plays banjo" 
                : name + " does not play banjo";

            var result2 = string.Format("{0} {1} banjo", name, char.ToLower(name[0]) == 'r' 
                ? "plays" 
                : "does not play");

            var result3 = new Regex("^[rR]").IsMatch(name)
                ? name + " plays banjo"
                : name + " does not play banjo";

            return result;
        }


        /// <summary>
        /// вернуть строку, в которой каждый символ (с учетом регистра) повторяется ещё один раз.
        /// <code>
        /// * "Hello World" -> "HHeelllloo  WWoorrlldd"
        /// * "1234!_ "     -> "11223344!!__  "
        /// </code>
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string DoubleChar(string s)
        {
            var result = string.Join("", s.Select(x => new string(x, 2)));
            var result1 = string.Join("", s.Select(x => "" + x + x));
            var result2 = string.Concat(s.Select(x => $"{x}{x}"));
            var result3 = Regex.Replace(s, ".", "$&$&");
            var result5 = Regex.Replace(s, "(.)", "$1$1");
            var result4 = s.Aggregate("", (str, x) => str + x + x);

            return result;
        }
    }
}
