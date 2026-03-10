using System;
class Program
{
    static void Main()
    {
        DateTime nascimento = new DateTime(2007, 01, 13);
        DateTime hoje = DateTime.Today;

        int diff_dias = (hoje - nascimento).Days;
        int meses = 0, anos = 0;

        anos = diff_dias / 365;
        diff_dias -= anos * 365;

        meses = diff_dias / 30;
        diff_dias -= meses * 30;

        Console.WriteLine("Nome: Henrique de Figueiredo Reinaldi");
        Console.WriteLine("Minha idade (dias, meses, anos): {0}/{1}/{2}", diff_dias.ToString("D2"), meses.ToString("D2"), anos.ToString("D4"));

    }
}