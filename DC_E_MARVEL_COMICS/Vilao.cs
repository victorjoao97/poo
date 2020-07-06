using System;
using System.Collections.Generic;
using System.Text;

namespace DC_E_MARVEL_COMICS
{
    class Vilao:Pessoa
    {
        string nomeVilao { get; set; }
        string planetaOrigem { get; set; }
        string parceiro { get; set; }
        string superPoder { get; set; }

        public Vilao() : base()
        {
            nomeVilao = planetaOrigem = parceiro = superPoder = null;
        }

        public override void lerDados()
        {
            base.lerDados();
            try
            {
                Console.WriteLine("------Cadastrando Vilão------");
                Console.Write("Digite o nome do Vilão: ");
                nomeVilao = Console.ReadLine();
                Console.Write("Digite o nome do planeta de origem: ");
                planetaOrigem = Console.ReadLine();
                Console.Write("Digite o nome do parceiro(namorado/namorada): ");
                parceiro = Console.ReadLine();
                Console.Write("Digite o super poder: ");
                superPoder = Console.ReadLine();

                int anoAtual = DateTime.Now.Year;
                calcularIdade(anoAtual);
            }
            catch (Exception excecao)
            {
                Console.WriteLine($"Digite os dados corretamente\nErro: {excecao.Message}");
            }
        }

        public override string mostrarDados()
        {
            return $"{base.mostrarDados()}------Exibindo dados do Vilão------\nNome do vilão: {nomeVilao}\nPlaneta de origem: {planetaOrigem}\nParceiro: {parceiro}\nSuper Poder: {superPoder}\n";
        }

        public override void calcularIdade(int anoAtual)
        {
            try
            {
                Console.Write("Digite o ano de nascimento do vilão: ");
                idade = anoAtual - int.Parse(Console.ReadLine());
            }
            catch (Exception excecao)
            {
                Console.WriteLine($"Digite os dados corretamente\nErro: {excecao.Message}");
            }
        }
    }
}
