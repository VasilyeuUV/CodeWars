using System.Numerics;

namespace CodeWarsConsoleApp.Bests;

/// <summary>
/// Классические решения для числовых значений.
/// </summary>
public static class NumberClassic
{
    //#########################################################################################################
    #region ФИББОНАЧИ

    /// <summary>
    /// Вернуть последовательность Фиббоначи.
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static long GetFibbonachi(int n)
    {
        Func<int, int>? fib = null;
        fib = (x) => x > 1 
            ? fib!(x - 1) + fib(x - 2) 
            : x;
        return fib(n);
    }


    /// <summary>
    /// Быстрая генерация числа Фиббоначи 
    /// </summary>
    /// <param name="sequenceLength"></param>
    /// <returns></returns>
    public static ulong[] GeneratFibbonachi(uint sequenceLength)
    {
        ulong[] fibonacci = new ulong[sequenceLength];
        fibonacci[0] = 0;
        fibonacci[1] = 1;
        for (int index = 2; index < sequenceLength; index++)
        {
            fibonacci[index] = fibonacci[index - 2] + fibonacci[index - 1];
        }
        return fibonacci;
    }


    /// <summary>
    /// Вернуть конкретное число Фиббоначи для указанного положительного значения.
    /// </summary>
    /// <param name="n">Значение, для которого рассичтывается число Фиббоначи</param>
    /// <returns></returns>
    public static ulong GetCurrentPositiveFibonachiRecursive(uint n) 
        => n == 0 || n == 1
            ? n
            : GetCurrentPositiveFibonachiRecursive(n - 1) + GetCurrentPositiveFibonachiRecursive(n - 2);


    #endregion // ФИББОНАЧИ



    //#########################################################################################################
    #region ФАКТОРИАЛ

    /// <summary>
    /// Вернуть Факториал для указанного положительного значения.
    /// </summary>
    /// <param name="n">Значение, для которого рассичтывается значение Факториала</param>
    /// <returns></returns>
    public static ulong GetCurrentPositiveFactorialRecursive(uint n) 
        => n == 1
            ? n
            : n * GetCurrentPositiveFactorialRecursive(n - 1);

    #endregion // ФАКТОРИАЛ
}
