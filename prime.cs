using System;

public class ddd
{
    public static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine()); 

        bool isPrime = true;

        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
        {
            Console.WriteLine(number + "jest");
        }
        else
        {
            Console.WriteLine(number + "nie jest");
        }
        Console.ReadLine();
    }
}
