using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            do
            {
                Console.Write("Digite seu nome: ");
                nome = Console.ReadLine();
                TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
                Console.WriteLine($"Bem vindo {myTI.ToTitleCase(nome)}");
            } while (nome.Length <= 0);
            Console.ReadKey();
        }
    }
}
