using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Задача 1: Написать рекурсивный метод для вычисления: x^n / n!, где x - некоторое действительное число, а n - натуральное
namespace Mikheev_Kruglov_Recursion_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите значение N: ");
            int n = int.Parse(Console.ReadLine());

            double result = CalculateExpression(x, n);
            Console.WriteLine($"{x}^{n} / {n}! = {result}");
            Console.ReadLine();
        }

        static double CalculateExpression(double x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return (Math.Pow(x, n) / Factorial(n)) + CalculateExpression(x, n - 1);
            }
        }

        static double Factorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            else
            {
                return num * Factorial(num - 1);
            }
        }
    }
}