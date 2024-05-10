//Напишите программу, которая на вход принимает натуральное число N, 
//а на выходе показывает его цифры через запятую.

Console.WriteLine("Введите натуральное число N:");
string input = Console.ReadLine();

if (Int64.TryParse(input, out long number))
{
    Console.WriteLine("Цифры числа N через запятую:");
    Console.WriteLine(String.Join(",", input.ToCharArray()));
}
else
{
    Console.WriteLine("Введено не натуральное число.");
}