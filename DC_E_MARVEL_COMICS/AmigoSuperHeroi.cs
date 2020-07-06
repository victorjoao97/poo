using System;
using System.Collections.Generic;
using System.Text;

namespace DC_E_MARVEL_COMICS
{
    class AmigoSuperHeroi : Pessoa
    {
        public string hobby { get; set; }
        public string atividadeProfissional { get; set; }

        public AmigoSuperHeroi() : base()
        {
            atividadeProfissional = hobby = null;
        }

        public override void lerDados()
        {
            base.lerDados();
            try
            {
                Console.WriteLine("------Cadastrando Amigo Super Herói------");
                Console.Write("Digite o hobby: ");
                hobby = Console.ReadLine();
                Console.Write("Digite a atividade profissional: ");
                atividadeProfissional = Console.ReadLine();

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
            return $"{base.mostrarDados()}------Exibindo dados do Amigo do Super Herói------\nHobby: {hobby}\nAtividade Profissional: {atividadeProfissional}\n";
        }

        public override void calcularIdade(int anoAtual)
        {
            try
            {
                Console.Write("Digite o ano de nascimento do amigo do super heroi: ");
                idade = anoAtual - int.Parse(Console.ReadLine());
            }
            catch (Exception excecao)
            {
                Console.WriteLine($"Digite os dados corretamente\nErro: {excecao.Message}");
            }
        }
    }
}
