using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;

            Console.WriteLine("Hello World!");
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine($"Bem vindo {nome}");
            Console.ReadKey();
        }
    }
}
