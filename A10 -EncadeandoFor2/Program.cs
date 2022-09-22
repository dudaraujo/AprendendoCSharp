using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Encadeando For 2");

        for(int linha = 0; linha < 10; linha++)
        {
            for (int coluna = 0; coluna < 10; coluna++)
            {
                Console.Write("*");
                if(coluna >= linha)
                break;
                
               
            }
            Console.WriteLine();

        }
       


        Console.WriteLine("Tecle para fechar");
        Console.ReadLine();
    }
}