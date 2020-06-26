using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TURISMO
{
    class Program
    {
        static void Main(string[] args)
        {
            Museu museu = new Museu();
            museu.lerDados();
            Console.WriteLine(museu.mostrarDados());

            CasaShow casaShow = new CasaShow();
            casaShow.lerDados();
            Console.WriteLine(casaShow.mostrarDados());

            Console.ReadKey();
        }
    }
}
