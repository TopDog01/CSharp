// Напишите программу, которая принимает на вход трёхзначное целое число и на выходе показывает
// сумму первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999)
// if (num > 99 && num < 1000)
{
    int firstDigit = num / 100; // 456 / 10 = 4.56
    int lastDigit = num % 10; // 456 % 10 = 450 + 6

    int result = firstDigit + lastDigit;

    Console.WriteLine($"Сумма первой и последней цифры трехзначного числа = {result}");
}
else
{
    Console.WriteLine("Ошибка! Число не трехзначное.");
}
