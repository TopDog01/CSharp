//Напишите программу, которая выводит третью слева
//цифру заданного числа или сообщает, что третьей
//цифры нет.
//456 => 6
//7812 => 1
//91 => Третьей цифры нет

Console.WriteLine("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 || num <= -100)
{
   while (num > 999 || num < -999)
   {
    num = num / 10;
   } 
   int result = num % 10;
   Console.WriteLine("Третья цифра слева: " + result);
}
else
{
    Console.WriteLine("Третьей цифры нет!");
}

