//int n = 10;
int[] array = { 2, 5, 7, 9, 36, 3, 8, 1, 12, 22 };
int i = 0;

while (i < array.Length)
{
    if(array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i = i + 1;
}