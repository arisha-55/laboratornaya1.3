using System;

class AmicableNumbersFinderSimple
{
    static void Main()
    {
        Console.Write("Введите начало отрезка: ");
        if (!int.TryParse(Console.ReadLine(), out int a) || a < 1)
        {
            Console.WriteLine("Некорректный ввод для 'a'. Введите натуральное число.");
            return;
        }

        Console.Write("Введите конец отрезка: ");
        if (!int.TryParse(Console.ReadLine(), out int b) || b < a)
        {
            Console.WriteLine("Некорректный ввод для 'b'. Введите число больше или равное 'a'.");
            return;
        }

        Console.WriteLine($"\nДружественные пары чисел на отрезке [{a}, {b}]:");

        
        FindAndPrintAmicablePairsSimple(a, b);
    }

    static void FindAndPrintAmicablePairsSimple(int start, int end)
    {
        for (int m = start; m <= end; m++)
        {
            int n = SumOfProperDivisors(m);

            if (n >= start && n <= end && n != m && m < n)
            {
                int sumOfN = SumOfProperDivisors(n);

                if (sumOfN == m)
                {
                    Console.WriteLine($"{m} и {n}");
                }
            }
        }
    }
    static int SumOfProperDivisors(int n)
    {
        if (n <= 1) return 0;

        int sum = 1;
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                sum += i;
                if (i * i != n)
                {
                    sum += n / i;
                }
            }
        }
        return sum;
    }
}
