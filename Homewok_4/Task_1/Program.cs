//Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
using System;

class Program
{
    static void Main()
    {
        // Задаем двумерный массив символов
        char[,] charArray = new char[,]
        {
            {'H', 'e', 'l', 'l', 'o'},
            {'W', 'o', 'r', 'l', 'd'}
        };

        // Формируем строку из символов массива
        string result = ConvertCharArrayToString(charArray);
        
        // Выводим строку
        Console.WriteLine(result);
    }

    static string ConvertCharArrayToString(char[,] charArray)
    {
        int rows = charArray.GetLength(0);
        int cols = charArray.GetLength(1);
        
        char[] chars = new char[rows * cols];
        int index = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                chars[index] = charArray[i, j];
                index++;
            }
        }

        return new string(chars);
    }
}
