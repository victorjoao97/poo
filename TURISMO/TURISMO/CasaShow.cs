using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TURISMO
{
    class CasaShow : PontoTuristico
    {
        string nome { get; set; }
        string horarioShow { get; set; }
        double valorIngresso { get; set; }
        int capacidadePessoas { get; set; }

        public CasaShow() : base()
        {
            nome = null;
            horarioShow = null;
            valorIngresso = 0;
            capacidadePessoas = 0;
        }
        public override void calcularCustoManutencao()
        {
            const double PORCENTAGEM_MANUTENCAO = 35;
            custoManutencao = valorIngresso * (PORCENTAGEM_MANUTENCAO / 100) * capacidadePessoas;
        }

        public override void lerDados()
        {
            base.lerDados();

            try
            {
                Console.WriteLine("------Cadastrando Casa de Show------");
                Console.Write("Digite o nome: ");
                nome = Console.ReadLine();
                Console.Write("Digite o horario do show: ");
                horarioShow = Console.ReadLine();
                Console.Write("Digite o valor do ingresso: ");
                valorIngresso = double.Parse(Console.ReadLine());
                Console.Write("Digite a capacidade de pessoas: ");
                capacidadePessoas = int.Parse(Console.ReadLine());

                Console.Clear();

                calcularCustoManutencao();
            }
            catch (Exception excecao)
            {

                Console.WriteLine($"Digite os dados corretamente\nErro: {excecao.Message}");
            }
        }

        public override string mostrarDados()
        {
            return $"{base.mostrarDados()}\n------Exibindo dados da Casa de Show------\nNome: {nome}\nHorario do Show: {horarioShow}\nValor do ingresso: {valorIngresso}\nCapacidade de pessoas: {capacidadePessoas}\n";
        }
    }
}
