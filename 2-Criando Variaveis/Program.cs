using System;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Projeto 2 - Criando variaveis");

        //atribuindo a idade um valor inteiro
        Console.WriteLine("Digite sua idade:");
        var idade = Console.ReadLine();
        idade = 21;
        Console.WriteLine(idade);
        idade = 21 - 5;
        Console.WriteLine(idade);
        idade = 5 * 2 - 6;
        Console.WriteLine(idade);


        Console.WriteLine("Tecle ENTER para fechar!");
        Console.ReadLine();
    }
}
