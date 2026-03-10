using System;

class Program
{

    static float getNum(int i)
    {
        while (true) {
            Console.Write("Digite o {0}º número --> ", i + 1);
            string input = Console.ReadLine();

            if (float.TryParse(input, out float number))
            {
                return float.Parse(input);
            }
            else
            {
                Console.WriteLine("Não é número.");
            }
        }   
    }

    static char getOp()
    {
        char c;
        while (true)
        {
            char[] sinal = new char[4] { '+', '-', '*', '/' };
            Console.Write("Operador (+, -, /, *) --> ");
            c = Console.ReadKey().KeyChar;

            if (!sinal.Contains(c))
            {
                Console.WriteLine("\nOperador invalido");
                continue;
            }
            Console.Write("\r\n");
            break;
        }
        return c;
    }

    static void Main()
    {
        float[] numeros = new float[2] { 0, 0 };
        float resultado = 0;


        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = getNum(i);
        }
        char c = getOp();

        switch (c)
        {
            case '+':
                resultado = numeros[0] + numeros[1];
                break;
            case '-':
                resultado = numeros[0] - numeros[1];
                break;
            case '/':
                resultado = numeros[0] / numeros[1];
                break;
            case '*':
                resultado = numeros[0] * numeros[1];
                break;
        }

        Console.WriteLine("Resultado de {0} {1} {2} = {3}", numeros[0], c, numeros[1], resultado);

    }

}