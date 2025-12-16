using System;

class DoubleFactorialCalculator
{
    static void Main()
    {
        Console.Write("Введите четное число n: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0 && n % 2 == 0)
        {
            long result = CalculateDoubleFactorial(n);
            Console.WriteLine($"Двойной факториал {n} равен: {result}");
        }
        else
        {
            Console.WriteLine("Некорректный ввод, введите четное натуральное число.");
        }
    }

    static long CalculateDoubleFactorial(int n)
    {
        long factorial = 1;
        for (int i = 2; i <= n; i += 2)
        {
            factorial *= i;
        }
        return factorial;
    }
}