void ZeroEvenElemets(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}

void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.WriteLine($"{e} ");
    }
}

int[] array = { 1, 2, 3, 4, 5 };
ZeroEvenElemets(array);
PrintArray(array);