//Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.Write("Введите целое число от 10 до 99: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10 && number <= 99)
{
    int maxDigit = 0;

    while (number > 0)
    {
        int digit = number % 10;
        if (digit > maxDigit)
        {
            maxDigit = digit;
        }

        number /= 10;
    }

    Console.WriteLine("Наибольшая цифра: {0}", maxDigit);
}
else
{
    Console.WriteLine("Число должно быть от 10 до 99 включительно.");
}