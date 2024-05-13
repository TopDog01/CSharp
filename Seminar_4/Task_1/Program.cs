//Задайте одномерный массив, заполненный случайными
//числами. Определите количество простых чисел в этом массиве.
//Примеры
//[1 3 4 19 3] => 2
//[4 3 4 1 9 5 21 13] => 3

using System.Diagnostics;
using System.Runtime.CompilerServices;

int[] CreateArrayRndInt(int size, int min, int max)
{
    int [] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    
    return array;
}

void PrintArray(int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
       if (i < array.Length - 1)
       {
        Console.Write($"{array[i]}, ");
       }
       else
       {
        Console.Write($"{array[i]}");
       }
       
    }
    Console.Write("]");
}

int CountPrimeNumbers(int[] array)
{
    int count = 0;
//реализация
    for (int i = 0; i < array.Length; i++)
    {
        if(ISPrime(array[i]))
        {
            count++;
        }
    }

    return count;
}

bool ISPrime(int num)
{
    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0) 
        {
            return false;
        }
    }
    return true;
}

int[] arr = CreateArrayRndInt(10, 1, 100);
PrintArray(arr);

int countPrime = CountPrimeNumbers(arr);
Console.Write($" => {countPrime}");