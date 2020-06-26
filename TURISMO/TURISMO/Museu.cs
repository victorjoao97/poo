using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TURISMO
{
    class Museu : PontoTuristico
    {
        Fundador fundador { get; set; }
        string dataFundacao { get; set; }
        double valorEntrada { get; set; }
        double horasFuncionamento { get; set; }

        public Museu() : base()
        {
            fundador = new Fundador();
            dataFundacao = null;
            valorEntrada = 0;
            horasFuncionamento = 0;
        }

        public override void calcularCustoManutencao()
        {
            const double TARIFA_MANUTENCAO = 25.5;
            const double DESPESAS_FIXAS = 1000;
            custoManutencao = TARIFA_MANUTENCAO * horasFuncionamento + DESPESAS_FIXAS;
        }

        public override void lerDados()
        {
            base.lerDados();
            try
            {
                fundador.lerDados();

                Console.WriteLine("------Cadastrando Museu-------");

                Console.Write("Digite a data da fundação: ");
                dataFundacao = Console.ReadLine();
                Console.Write("Digite o valor da entrada: ");
                valorEntrada = double.Parse(Console.ReadLine());
                Console.Write("Digite as horas de funcionamento: ");
                horasFuncionamento = double.Parse(Console.ReadLine());

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
            return $"{base.mostrarDados()}\n------Exibindo dados do Museu------\nData da fundação: {dataFundacao}\nValor da entrada: {valorEntrada}\nHoras de funcionamento: {horasFuncionamento}\n{fundador.mostrarDados()}";
        }
    }
}
