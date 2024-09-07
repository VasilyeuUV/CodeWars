using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWarsConsoleApp.BeginnerSeries
{
    internal class RegularExpr
    {
        /// <summary>
        /// Проверить PIN-код (не могут содержать ничего, кроме ровно 4 цифр или ровно 6 цифр)
        /// </summary>
        /// <param name="pin"></param>
        /// <returns>Если функции передана правильная строка PIN-кода, возвращается true, в противном случае возвращается false.</returns>
        public static bool ValidatePin(string pin)
        {
            var result = Regex.IsMatch(pin, @"^(\d{4,4}\z)$")
                  || Regex.IsMatch(pin, @"^(\d{6,6}\z)$");

            var result1 = Regex.IsMatch(pin, @"^(\d{6}|\d{4})\z");
            var result2 = Regex.IsMatch(pin, @"^(\d{2}){2,3}\z", RegexOptions.Multiline);
            var result3 = pin.All(n => char.IsDigit(n))
                && (pin.Length == 4 || pin.Length == 6);

            return result;
        }
    }
}
