//Считать строку с консоли, состоящую из латинских
//букв в нижнем регистре. Выяснить, сколько среди
//введённых букв гласных.
//Пример
//“hello” => 2
//“world” => 1

int CountVowels(string str)
{
    string vowels = "aeiouy";
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        for (int j = 0; j < vowels.Length; j++)
        {
            if (str[i] == vowels[j])
            {
                count++;
            }
        }
    }
    return count;
}

Console.WriteLine("Напишите слово: ");
string start = Console.ReadLine();
Console.WriteLine($"В слове {CountVowels(start)} гласных");