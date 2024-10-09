using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsConsoleApp.BeginnerSeries
{
    internal class Geometrics
    {
        /// <summary>
        /// Вычислить объем кубоида.
        /// </summary>
        /// <param name="length">длиной</param>
        /// <param name="width">ширина</param>
        /// <param name="height">высота</param>
        /// <returns></returns>
        public static double GetVolumeOfCuboid(double length, double width, double height)
            => length * width * height;


        /// <summary>
        /// Вам даны два внутренних угла (в градусах) треугольника. Напишите функцию, возвращающую 3-й угол.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static int OtherAngle(int a, int b)
            => 180 - a - b;


        /// <summary>
        /// Можно ли построить треугольник.
        /// </summary>
        /// <param name="a">длина стороны треугольника</param>
        /// <param name="b">длина стороны треугольника</param>
        /// <param name="c">длина стороны треугольника</param>
        /// <returns></returns>
        public static bool IsTriangle(int a, int b, int c)
        {
            var arr = new int[] { a, b, c }.OrderBy(n => n);
            var result = arr.Take(2).Sum() > arr.Last();

            var result1 = a > 0 && b > 0 && c > 0 
                && a + b > c && a + c > b && b + c > a;
            var result2 = (a + b > c && b + c > a && a + c > b);

            return result;
        }


        /// <summary>
        /// Многоугольник может быть либо прямоугольником, либо квадратом.<br/>
        /// Если это квадрат, верните его площадь..<br/>
        /// Если это прямоугольник, верните его периметр.
        /// </summary>
        /// <param name="l">длина четырёхстороннего многоугольника</param>
        /// <param name="w">ширина четырёхстороннего многоугольника</param>
        /// <returns></returns>
        public static int AreaOrPerimeter(int l, int w)
        {
            var result = l == w ? l * w : (l + w) * 2;
            var result1 = 2 * (l + w);

            return result;
        }
    }
}
