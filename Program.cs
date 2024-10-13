using CodeWarsConsoleApp.BeginnerSeries;

namespace CodeWarsConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [1, 2, 3, 1, 2, 1, 2, 3];
            string[] d = ["n", "s", "n", "s", "n", "s", "n", "s", "n", "s"];
            var a = Arrays.Comp(arr, arr);

            var t = Dtg.Past(0, 1, 1);

            var c = Operations.ProductFib(714);

            var s = Strings.TowerBuilder(3);

            var r = Numbers.IsEven(4);

            Console.WriteLine("Hello, World!");
        }
    }
}
