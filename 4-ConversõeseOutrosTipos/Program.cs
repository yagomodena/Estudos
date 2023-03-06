using System;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Projto 4 - Conversões e Outros Tipos");

        double salario = 3000.15;
        Console.WriteLine(salario);

        int salariointerio = (int)salario;
        Console.WriteLine(salariointerio);

        //LONG é um tipo de variavel de 64 bits
        long x = 20000000000000;
        Console.WriteLine(x);

        short y = 15000;
        Console.WriteLine(y);

        float altura = 1.71f;
        Console.WriteLine(altura);

        Console.WriteLine("Tecle ENTER para fechar!");
        Console.ReadLine();

    }
}
