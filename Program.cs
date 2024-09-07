using CodeWarsConsoleApp.BeginnerSeries;

namespace CodeWarsConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15];
            var a = Arrays.FindEvenIndex(arr);

            var t = Dtg.Past(0, 1, 1);

            var c = Operations.SquareDigits(9119);

            var s = Strings.MakeComplement("ATTGC");
            Console.WriteLine("Hello, World!");
        }
    }
}
