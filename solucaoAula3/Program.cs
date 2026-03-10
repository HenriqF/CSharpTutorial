using System;

class Program
{

    static int parseInt()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                return number;
            }

        }
    }

    static void Main()
    {

        int maior = parseInt();

        for (int i = 0; i < 4; i++)
        {
            maior = Math.Max(parseInt(), maior);
        }

        Console.WriteLine("Maior: {0}", maior);
        

    }

}