//Найдите произведения пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
//второй и предпоследний и т.д. Результат запишите в новый массив.
//Пример
//[1 3 2 4 2 3] => [3 6 8]
//[2 3 1 7 5 6 3] => [6 18 5]

int[] array = { 2, 3, 1, 7, 5, 6, 3 };
int[] arrayResult = new int[array.Length / 2];

int left = 0;
int right = array.Length - 1;

while (left < right)
{
    arrayResult[left] = array[left] * array[right];
    left++;
    right--;
}

for (int i = 0; i < arrayResult.Length; i++)
{
    Console.WriteLine(arrayResult[i] + " ");
}