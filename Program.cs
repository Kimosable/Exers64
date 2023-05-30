// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от M до N.
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение M: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());

        PrintNumbers(m, n);
    }

    static void PrintNumbers(int start, int end)
    {
        if (start <= end)
        {
            Console.Write(start + " ");
            PrintNumbers(start + 1, end);
        }
    }
}