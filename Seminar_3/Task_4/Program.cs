//Дано натуральное трёхзначное число. Создайте массив, состоящий из цифр этого числа. Младший разряд
//числа должен располагаться на 0- м индексе массива, старший – на 2-м.
//Пример
//456 => [6 5 4]
//781 => [1 8 7]

int num;
Console.Write("Введите трехзначное число: ");
num = Convert.ToInt32(Console.ReadLine());

int numCopy = num;
int count = 0;

// счетает количество цифр в числе
while (numCopy != 0)
{
    numCopy /= 10;
    count++;
}


int[] arr = new int[count]; // создаем массив на количество цифр
int index = 0; // индекс последнего элемента
while (num != 0)
{
    arr[index] = num % 10;
    num /= 10; // num = num / 10;
    index++;
}
Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]} ");
}
Console.Write("]");