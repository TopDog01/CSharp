//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

using System;

class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }

    static void Main()
    {
        int m = 2;
        int n = 3;

        int result = Ackermann(n, m);
        Console.WriteLine($"Ackermann({m}, {n}) = {result}");
    }
}

//using System;

//class MainClass
//{
//    public static void Main(string[] args)
//    {
//        int m = 2;
//        int n = 3;
//        int result = Ackermann(n, m);
//        Console.WriteLine("Ackermann(" + m + ", " + n + ") = " + result);
//    }
//
//    public static int Ackermann(int m, int n)
//    {
//        if (m == 0)
//        {
//            return n + 1;
//        }
//        else if (m > 0 && n == 0)
//        {
//            return Ackermann(m - 1, 1);
//        }
//        else
//        {
//            return Ackermann(m - 1, Ackermann(m, n - 1));
//        }
//    }
//}