//Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение M: ");
        int M = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Введите значение N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        
        PrintNumbersInRange(M, N);
    }
    
    static void PrintNumbersInRange(int start, int end)
    {
        if (start <= end)
        {
            Console.WriteLine(start);
            PrintNumbersInRange(start + 1, end);
        }
    }
}