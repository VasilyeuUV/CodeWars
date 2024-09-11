using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsConsoleApp.BeginnerSeries
{
    /// <summary>
    /// Бинарные операции.
    /// </summary>
    internal class Binary
    {
        /// <summary>
        /// складывает два числа и возвращает их сумму в двоичном виде. 
        /// <code>
        /// 1, 1 --> "10" (1 + 1 = 2 in decimal or 10 in binary)
        /// 5, 9 --> "1110" (5 + 9 = 14 in decimal or 1110 in binary)
        /// </code>>
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Возвращаемое двоичное число должно быть строкой.</returns>
        public static string AddBinary(int a, int b)
        {
            var result = Convert.ToString(a + b, 2);

            return result;
        }
    }
}
