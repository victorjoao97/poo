using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TURISMO
{
    abstract class PontoTuristico
    {
        string cidade { get; set; }
        string estado { get; set; }
        string rua { get; set; }
        string bairro { get; set; }
        int numero { get; set; }
        protected double custoManutencao { get; set; }

        public virtual void lerDados()
        {
            try
            {
                Console.WriteLine("------Cadastrando Ponto Turistico------");
                Console.Write("Digite a cidade: ");
                cidade = Console.ReadLine();
                Console.Write("Digite o estado: ");
                estado = Console.ReadLine();
                Console.Write("Digite a rua: ");
                rua = Console.ReadLine();
                Console.Write("Digite o bairro: ");
                bairro = Console.ReadLine();
                Console.Write("Digite o numero: ");
                numero = int.Parse(Console.ReadLine());

                Console.Clear();
            }
            catch (Exception excecao)
            {

                Console.WriteLine($"Digite os dados corretamente\nErro: {excecao.Message}");
            }
        }

        public virtual string mostrarDados()
        {
            return $"------Exibindo dados do Ponto Turistico------\nCidade: {cidade}\nEstado: {estado}\nRua: {rua}\nBairro: {bairro}\nNúmero: {numero}\nCusto da manutenção: {custoManutencao}";
        }

        public abstract void calcularCustoManutencao();
    }
}
