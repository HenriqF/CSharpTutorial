using System.ComponentModel.DataAnnotations;
using System.Drawing;

class program
{
    static void Main(string[] args)
    {
        if (args.Length != 1)
        {
            Console.Write("Apenas um argumento.");
            return;
        }

        string pass = args[0];
        int strength = 100;


        if (pass.Length < 20) strength -= 20-pass.Length;


        int l=0, d=0, p=0;
        for (int i = 0 ; i < pass.Length; i++)
        {
            if (char.IsLetter(pass[i]))l++;   
            if (char.IsDigit(pass[i]))d++;
            if (char.IsPunctuation(pass[i]))p++;
        }
        int diff = Math.Max(l,Math.Max(d,p))-Math.Min(l,Math.Min(d,p));
        strength -= 80 * (diff/pass.Length);


        Console.WriteLine("Força: {0}", strength);
    }
}