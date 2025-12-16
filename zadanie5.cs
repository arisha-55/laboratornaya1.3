using System;

class PowerCalculator
{
    static void Main()
    {
        Console.Write("Введите основание x: ");
        if (!double.TryParse(Console.ReadLine(), out double x))
        {
            Console.WriteLine("Некорректный ввод для x.");
            return;
        }

        Console.Write("Введите показатель степени n: ");
        if (!int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine("Некорректный ввод для n.");
            return;
        }

        double result = CalculatePower(x, n);
        Console.WriteLine($"\nРезультат {x}^{n} равен: {result}");
    }
    static double CalculatePower(double x, int n)
    {
        if (n == 0)
        {
            return 1;
        }

        double result = 1.0;
        for (int i = 0; i < Math.Abs(n); i++)
        {
            result *= x;
        }

        if (n < 0)
        {
            return 1.0 / result;
        }

        return result;
    }
}
