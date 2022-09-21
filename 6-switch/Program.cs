using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Usando Switch");
        //É uma solução para não ´recisarmos utilizar tanto ifs


        int diaSemana = 6;

        switch(diaSemana)
        {
            case 1:
                Console.WriteLine("Domingo");
                break;

            case 2:
                Console.WriteLine("Segunda");
                break;

            case 3:
                Console.WriteLine("Terça");
                break;

            case 4:
                Console.WriteLine("Quarta");
                break;

            case 5:
                Console.WriteLine("Quinta");
                break;

            case 6:
                Console.WriteLine("Sexta");
                break;

            case 7:
                Console.WriteLine("Sabado");
                break;

           default: 
                Console.WriteLine("Dia da semana invalido");
                break;

        }

        Console.WriteLine("Digite enter para sair");
        Console.ReadLine();
    }
}
