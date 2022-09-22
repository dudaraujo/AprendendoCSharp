using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calcula Poupança");

        double investimento = 1000;
        int mes = 1;

        //Rendimento de 0.5% (0.005) ao mês

        //investimento = investimento + investimento * 000.5;

        while(mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine(investimento);
            mes++;
           
        }


        Console.WriteLine("Tecle para fechar");
        Console.ReadLine();
    }
}
