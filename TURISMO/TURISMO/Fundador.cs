using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TURISMO
{
    class Fundador
    {
        string nome { get; set; }
        string dataNasc { get; set; }
        string dataMorte { get; set; }
        string nacionalidade { get; set; }

        public Fundador()
        {
            nome = null;
            dataNasc = null;
            dataMorte = null;
            nacionalidade = null;
        }

        public void lerDados()
        {
            try
            {
                Console.WriteLine("------Cadastrando Fundador-------");
                Console.Write("Digite o nome: ");
                nome = Console.ReadLine();
                Console.Write("Digite a data de nascimento: ");
                dataNasc = Console.ReadLine();
                Console.Write("Digite a data da morte: ");
                dataMorte = Console.ReadLine();
                Console.Write("Digite a nacionalidade: ");
                nacionalidade = Console.ReadLine();

                Console.Clear();
            }catch(Exception excecao)
            {
                Console.WriteLine($"Digite os dados corretamente\nErro: {excecao.Message}");
            }
        }

        public string mostrarDados()
        {
            return $"------Exibindo dados do Fundador------\nNome: {nome}\nData de nascimento: {dataNasc}\nData da morte: {dataMorte}\nNascionalidade: {nacionalidade}\n";
        }
    }
}
