using System;

class Program {
    static void Main(string[] args)
    {

        if (args.Length <= 1)
        {
            Console.WriteLine("sem argumentos.");
            return;
        }

        int main_length = args[0].Length;
        for (uint i = 1; i < args.Length-1; i++)
        {
            if (args[i].Length != main_length || args[i] != args[i + 1])
            {
                Console.WriteLine("algo diferente existe.");
                return;
            }
        }

        Console.WriteLine("Sao todos iguais.");
        return;
        
    }
}

