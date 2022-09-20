using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 2 - Criando Variáveis");

        int idade;
        idade = 19;

        double salario;
        salario = 2400.50;

        Console.WriteLine("Minha idade é " + idade + " e meu salário é " + salario);

        //Char é até 16 bits, guarda apenas caracteres da tabelas ascii
        //Char é sempre com aspas simples
        char letra = 'a';
        Console.WriteLine(letra);

        //Estou convertendo um número em um caracter da tabela ascii
        //65 é a letra A na tabela ascii
        char meiaCinco = (char)65;
        Console.WriteLine(meiaCinco);

        //Caracter 66 da tabela ascii "B"
        meiaCinco = (char)(65 + 1);
        Console.WriteLine(meiaCinco);

        //Frases
        //String é sempre com aspas duplas
        string primeiraFrase = "Passei no BTG";
        Console.WriteLine(primeiraFrase);

        //Lista
        string cursos = @"
            - CShar 
            - JS 
            - Java 
            - Testes 
            - Cypress";
        Console.WriteLine(cursos);



        Console.WriteLine("Tecle enter para fechar...");


        
    }
}