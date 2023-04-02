// Напишите программу,
// которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Введите число N: ");
        int N = int.Parse(System.Console.ReadLine());

        System.Console.WriteLine("Таблица кубов: ");
        for (int i = 1; i <= N; i++)
        {
            System.Console.WriteLine($"{i}^3 = {Math.Pow(i, 3)}");
        }
    }
}