using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Laço for");

        double investimento = 1000;
        //int mes = 1;

        for(int mes = 1; mes <= 12; mes++ )
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine(investimento);
        }

          


        Console.WriteLine("Tecle para fechar");
        Console.ReadLine();
    }
}

