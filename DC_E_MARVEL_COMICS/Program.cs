using System;

namespace DC_E_MARVEL_COMICS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Amigo do Super Herói");

            AmigoSuperHeroi amigoSuperHeroi = new AmigoSuperHeroi();
            amigoSuperHeroi.lerDados();
            Console.WriteLine(amigoSuperHeroi.mostrarDados());
            Console.ReadKey();

            Console.WriteLine("Vilão");

            Vilao vilao = new Vilao();
            vilao.lerDados();
            Console.WriteLine(vilao.mostrarDados());
            Console.ReadKey();

            Console.WriteLine("Super Herói");

            SuperHeroi superHeroi = new SuperHeroi();
            superHeroi.lerDados();
            Console.WriteLine(superHeroi.mostrarDados());

            Console.ReadKey();
        }
    }
}
