 void PrintSquares (int limit)
 {
    int i = 1;
    while (i <= limit)
    {
        Console.WriteLine($"{i*i} ");
        i++;
    }
 }

 PrintSquares(5);
 PrintSquares(10);
 PrintSquares(15);