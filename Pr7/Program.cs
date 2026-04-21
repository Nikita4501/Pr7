int result = Fibonacci(5);
Console.WriteLine(result);

/// <summary>
/// Вычисляет n-е число в последовательности Фибоначчи.
/// </summary>
/// <param name="n">Порядковый номер числа Фибоначчи (начиная с 0).</param>
/// <returns>n-е число Фибоначчи.</returns>
static int Fibonacci(int n)
{
    Console.WriteLine("The output is: ");
    int n1 = 0;
    int n2 = 1;
    int sum;

    for (int i = 2; i <= n; i++)
    {
        sum = n1 + n2;
        n1 = n2;
        n2 = sum;
    }

    return n == 0 ? n1 : n2;
}