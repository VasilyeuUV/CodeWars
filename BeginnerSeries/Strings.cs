using System.Collections.Generic;
using System.Linq;
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

    }
}
