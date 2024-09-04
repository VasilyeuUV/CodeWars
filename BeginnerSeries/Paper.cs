namespace CodeWarsConsoleApp.BeginnerSeries;

public static class Paper
{
    /// <summary>
    /// Calculate the required number of blank sheets.
    /// </summary>
    /// <param name="n">Number of classmates.</param>
    /// <param name="m">Number of pages in paperwork.</param>
    /// <returns></returns>
    public static int Paperwork(int n, int m) 
        => n < 0 || m < 0 ? 0 : m * n;
}
