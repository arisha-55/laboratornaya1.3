using System;

class ArmstrongFinder
{
    static void Main()
    {
        Console.Write("Введите начало отрезка: ");
        if (!int.TryParse(Console.ReadLine(), out int a))
        {
            Console.WriteLine("Некорректный ввод для 'a'.");
            return;
        }

        Console.Write("Введите конец отрезка: ");
        if (!int.TryParse(Console.ReadLine(), out int b))
        {
            Console.WriteLine("Некорректный ввод для 'b'.");
            return;
        }

        Console.WriteLine($"\nЧисла Армстронга на отрезке [{a}, {b}]:");
        FindArmstrongNumbers(a, b);
    }
    static void FindArmstrongNumbers(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            if (IsArmstrong(i))
            {
                Console.WriteLine(i);
            }
        }
    }
    static bool IsArmstrong(int number)
    {
        int originalNumber = number;
        int sum = 0;

        if (number <= 0) return false;

        while (number > 0)
        {
            int digit = number % 10;
            sum += digit * digit * digit;
            number /= 10;
        }

        return originalNumber == sum;
    }
}