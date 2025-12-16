using System;

class FibonacciCalculator
{
    static void Main()
    {
        Console.Write("Введите порядковый номер n : ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {

            
            long fibonacciNumber = CalculateNthFibonacci(n);
            Console.WriteLine($"\n{n}-е число Фибоначчи: {fibonacciNumber}");
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите натуральное число.");
        }
    }

    static long CalculateNthFibonacci(int n)
    {
        if (n == 1 || n == 2)
        {
            return 1;
        }

        long f_i_minus_2 = 1;
        long f_i_minus_1 = 1;
        long f_i = 0;

        for (int i = 3; i <= n; i++)
        {
            f_i = f_i_minus_1 + f_i_minus_2;
            f_i_minus_2 = f_i_minus_1;
            f_i_minus_1 = f_i;
        }

        return f_i;
    }
}
