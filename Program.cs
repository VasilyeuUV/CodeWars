using CodeWarsConsoleApp.BeginnerSeries;

namespace CodeWarsConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15];
            var a = Arrays.SumArray(arr);

            var t = Dtg.Past(0, 1, 1);
            Console.WriteLine("Hello, World!");
        }
    }
}
