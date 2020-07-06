using System;
using System.Collections.Generic;
using System.Text;

namespace DC_E_MARVEL_COMICS
{
    class SuperHeroi : Pessoa
    {
        string nomeHeroi { get; set; }
        string planetaOrigem { get; set; }
        string atividadeProfissional { get; set; }
        string superPoder { get; set; }
        string parceiro { get; set; }
        string grupo { get; set; }

        public SuperHeroi() : base()
        {
            nomeHeroi = planetaOrigem = atividadeProfissional = parceiro = superPoder = grupo = null;
        }

        public override void lerDados()
        {
            base.lerDados();
            try
            {
                Console.WriteLine("------Cadastrando Super Herói------");
                Console.Write("Digite o nome do Super Herói: ");
                nomeHeroi = Console.ReadLine();
                Console.Write("Digite o nome do planeta de origem: ");
                planetaOrigem = Console.ReadLine();
                Console.Write("Digite a atividade profissional: ");
                atividadeProfissional = Console.ReadLine();
                Console.Write("Digite o nome do parceiro(namorado/namorada): ");
                parceiro = Console.ReadLine();
                Console.Write("Digite o super poder: ");
                superPoder = Console.ReadLine();
                Console.Write("Digite o grupo do herói: ");
                grupo = Console.ReadLine();

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
            return $"{base.mostrarDados()}------Exibindo dados do Super Herói------\nNome do super herói: {nomeHeroi}\nPlaneta de origem: {planetaOrigem}\nParceiro: {parceiro}\nAtividade Profissional: {atividadeProfissional}\nSuper Poder: {superPoder}\nGrupo do herói: {grupo}\n";
        }

        public override void calcularIdade(int anoAtual)
        {
            try
            {
                Console.Write("Digite o ano de nascimento do Super Herói: ");
                idade = anoAtual - int.Parse(Console.ReadLine());
            }
            catch (Exception excecao)
            {
                Console.WriteLine($"Digite os dados corretamente\nErro: {excecao.Message}");
            }
        }
    }
}
