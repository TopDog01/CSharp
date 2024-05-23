//Напишите программу, которая будет принимать на
//вход число и возвращать сумму его цифр.
//Указание
//Использовать рекурсию.
//Пример
//123 => 6
//63 => 9


int SumDigits(int num) 
{
    if (num == 0) return 0;
    return num % 10 + SumDigits(num / 10);
}

Console.WriteLine(SumDigits(123));