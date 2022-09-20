using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Condicionais com if");

        int idadeJoao = 16;
        bool acompanhado = true;

        if (idadeJoao >= 18)
        {
            Console.WriteLine("Pode entrar na festa");

        }
        else if (acompanhado == true)
        {
            Console.WriteLine("Pode entrar na festa");
        }
        else
        {
            Console.WriteLine("Não pode entrar na festa");
        }

        Console.WriteLine("Condicionais");

        int idadeDuda = 15;
        bool acompanhante = true;
        

        if (idadeDuda >= 18 || acompanhante)
        {
           
           Console.WriteLine("Pode entrar pois você é maior ou está acompanhado");
             
        } 
        else
        {
            Console.WriteLine("Não pode entrar");
        }

        Console.WriteLine("Digite enter para sair");
        Console.ReadLine();
    }
}
