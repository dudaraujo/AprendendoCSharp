using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Múltiplos de 3");

    

        for(int numero = 1; numero <= 100; numero++)
        {
            if(numero % 3 == 0)
            {
                Console.WriteLine(numero);
            }

        }
       


        Console.WriteLine("Tecle para fechar");
        Console.ReadLine();
    }
}
