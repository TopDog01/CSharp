//Напишите программу, которая принимает на вход трёхзначное
//число и возводит вторую цифру этого числа в степень, равную
//третьей цифре.

//Примеры

//487 => 8^7 = 2 097 152
//254 => 5^4 = 625
//617 => 1

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999)
{
    int secondDigit = num / 10 % 10;
    int thirdDigit = num % 10;

    int result = secondDigit;

    int count = 1;
    while (count < thirdDigit)
    {
        result = result * secondDigit; // result *= secondDigit
        count++;
    }

    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Ошибка ввода!");
}

