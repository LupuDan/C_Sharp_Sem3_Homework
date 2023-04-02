// Напишите программу,
// которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Введите координаты первой точки: ");
        System.Console.Write("X1: ");
        double x1 = double.Parse(System.Console.ReadLine());
        System.Console.Write("Y1: ");
        double y1 = double.Parse(System.Console.ReadLine());
        System.Console.Write("Z1: ");
        double z1 = double.Parse(System.Console.ReadLine());

        System.Console.WriteLine("Введите координаты второй точки: ");
        System.Console.Write("X2: ");
        double x2 = double.Parse(System.Console.ReadLine());
        System.Console.Write("Y2: ");
        double y2 = double.Parse(System.Console.ReadLine());
        System.Console.Write("Z2: ");
        double z2 = double.Parse(System.Console.ReadLine());

        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
        System.Console.WriteLine($"Растояние между точками: {distance:F2}");
    }
}