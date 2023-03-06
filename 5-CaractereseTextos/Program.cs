using System;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Projto 5 - Caracteres e Textos");

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        string firstPhrase = "Alura cursos de tecnologia ";
        Console.WriteLine(firstPhrase + 2023);

        string saudacao = "Olá, meu nome é ";
        string nome = "Rômulo ";
        string continuacao = "e minha idade é ";
        int idade = 100;
        Console.WriteLine(saudacao + nome + continuacao + idade);

        Console.WriteLine("Tecle ENTER para fechar!");
        Console.ReadLine();

    }
}
