using System;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Projto 6 - Atribuições de Variáveis");

        int idade = 30;
        int idadeAna = idade;

        Console.WriteLine(idadeAna);

        idade = 25;

        string parcela_1 = "10";
        string parcela_2 = "20";

        Console.WriteLine(parcela_1 + parcela_2);

        Console.WriteLine("Tecle ENTER para fechar!");
        Console.ReadLine();

    }
}
