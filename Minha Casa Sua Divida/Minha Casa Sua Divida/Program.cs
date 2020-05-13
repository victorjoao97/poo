using System;

namespace Minha_Casa_Sua_Divida
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Cadastrando uma casa -----");
            Casa casa = new Casa();
            casa.lerDados();

            Console.WriteLine("----- Cadastrando um apartamento -----");
            Apartamento apartamento = new Apartamento();
            apartamento.lerDados();

            Console.WriteLine("----- Mostrando dados da casa -----");
            Console.WriteLine(casa.mostrarDados());
            Console.WriteLine("----- Mostrando dados do apartamento -----");
            Console.WriteLine(apartamento.mostrarDados());
        }
    }
}
