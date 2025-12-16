using System;

class HornerMethod
{
    static void Main()
    {
  
        double[] coefficients = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

        Console.Write("Введите значение x для вычисления: ");
        if (double.TryParse(Console.ReadLine(), out double x))
        {
            double result = EvaluatePolynomialHorner(coefficients, x);
            Console.WriteLine($"\nЗначение формулы при x = {x} равно: {result}");
        }
        else
        {
            Console.WriteLine("Некорректный ввод x.");
        }
    }

    static double EvaluatePolynomialHorner(double[] coeffs, double x)
    {
        double result = coeffs[0];

        for (int i = 1; i < coeffs.Length; i++)
        {
            result = result * x + coeffs[i];
        }

        return result;
    }
}
