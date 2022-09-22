using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Encadeando For");

        double fatorRendimento = 1.005;
        double investimento = 100;

        for(int anos = 1; anos <= 5; anos++)
        {
            for(int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorRendimento;
            }
            fatorRendimento += 0.001; 
            
        }

        Console.WriteLine("Depois de 5vanos vc terá R$ " + investimento);


        Console.WriteLine("Tecle para fechar");
        Console.ReadLine();
    }
}

