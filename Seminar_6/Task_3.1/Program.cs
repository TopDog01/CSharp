int CountVowels(string str)
{
    string vowels = "aeiouy";
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (vowels.Contains(str[i]))
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Напишите слово: ");
string start = Console.ReadLine();
Console.WriteLine($"В слове {CountVowels(start)} гласных");