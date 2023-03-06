using System;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Projeto 2 - Criando variaveis");
        Console.WriteLine("====================");
        Console.WriteLine("Digite o seu nome:");
        string nome = Console.ReadLine();
        Console.WriteLine($"Olá {nome}, qual sua idade?");
        int idade = Convert.ToInt32(Console.ReadLine());
        if(idade > 18)
        {
            Console.WriteLine($"{nome} sua idade é {idade}, você já pode tirar carta");
        }
        else
        {
            Console.WriteLine($"{nome} sua idade é {idade}, infelizmente você ainda não pode tirar carta!");
        }

        Console.WriteLine("Tecle ENTER para fechar!");
        Console.ReadLine();
    }
}
