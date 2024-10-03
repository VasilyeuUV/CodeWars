using CodeWarsConsoleApp.BeginnerSeries;

namespace CodeWarsConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [1, 2, 3, 1, 2, 1, 2, 3];
            string[] d = ["n", "s", "n", "s", "n", "s", "n", "s", "n", "s"];
            var a = Arrays.ArrayDiff(arr, arr);

            var t = Dtg.Past(0, 1, 1);

            var c = Operations.QueueTime([10, 2, 3, 3], 2);

            var s = Strings.ExpandedForm(70);
            Console.WriteLine("Hello, World!");
        }
    }
}
