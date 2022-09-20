
using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Conversão de variáveis e outros tipos de números");

        //Convertendo double em int
        double salario;
        salario = 3000.15;


        int salarioInteiro;
        //utilizando casting
        salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);

        //Usanod long para número inteiros muito grandes (c# não aceita int muito grande)
        //64 bits
        long grande;
        grande = 2000000000000000;
        Console.WriteLine(grande);


        //Variáveis do tipo short armazrnam números muito pequenos
        short pequeno;
        pequeno = 15000;
        Console.WriteLine(pequeno);


        //Float é para precisão maior em número com virgula 
        //Utilizar f no final do número
        float pi = 3.1415926f;
        Console.WriteLine(pi);


        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();

       


    }
}