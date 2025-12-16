using System;

class SeriesSumCalculator
{
    static void Main()
    {
        Console.Write("Введите число n: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            long totalSum = CalculateSeriesSum(n);
            Console.WriteLine($"Сумма ряда при n={n} равна: {totalSum}");
        }
        else
        {
            Console.WriteLine("Некорректный ввод, введите натуральное число.");
        }
    }
    static long CalculateSeriesSum(int n)
    {
        long totalSum = 0;
        for (int i = 1; i <= n; i++)
        {
            long currentProduct = 1;
            for (int j = i; j <= 2 * i; j++)
            {
                currentProduct *= j;
            }
            totalSum += currentProduct;
        }
        return totalSum;
    }
}