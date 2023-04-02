// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Introduceti un numar cu 5 cifre: ");
        int number = int.Parse(System.Console.ReadLine());

        if (IsPalindrome(number))
        {
            System.Console.WriteLine("Este palindrom");
        }
        else
        {
            System.Console.WriteLine("Nu este palindrom");
        }
    }

    static bool IsPalindrome(int number)
    {
        string strNumber = number.ToString();
        for (int i = 0; i < strNumber.Length / 2; i++)
        {
            if (strNumber[i] != strNumber[strNumber.Length - i - 1])
            {
                return false;
            }           
        }
        return true;
    }
}