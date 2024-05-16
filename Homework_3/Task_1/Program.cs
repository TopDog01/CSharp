using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите целое число или 'q' для завершения:");
            string input = Console.ReadLine();

            if (input.ToLower() == "q")
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

            int number;
            if (int.TryParse(input, out number))
            {
                if (IsEvenSum(number))
                {
                    Console.WriteLine("Сумма цифр числа чётная. Программа завершена.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q' для завершения.");
            }
        }
    }

    static bool IsEvenSum(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum % 2 == 0;
    }
}
