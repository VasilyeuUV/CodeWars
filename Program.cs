using CodeWarsConsoleApp.BeginnerSeries;

namespace CodeWarsConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [1, 2, 3, 1, 2, 1, 2, 3];
            string[] d = ["n", "s", "n", "s", "n", "s", "n", "s", "n", "s"];
            var a = Arrays.comp(arr, arr);

            var t = Dtg.Past(0, 1, 1);

            var c = Operations.ProductFib(714);

            var s = Strings.Correct("");

            var r = Numbers.IntPower(4, 5);

            Console.WriteLine("Hello, World!");
        }
    }
}
