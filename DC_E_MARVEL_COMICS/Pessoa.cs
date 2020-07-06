using System;
using System.Collections.Generic;
using System.Text;

namespace DC_E_MARVEL_COMICS
{
    abstract class Pessoa
    {
        int idPessoa { get; set; }
        string nomePessoa { get; set; }
        public int idade { get; set; }
        string email { get; set; }

        public virtual void lerDados()
        {
            try
            {
                Console.WriteLine("------Cadastrando Pessoa------");
                Console.Write("Digite o id da pessoa: ");
                idPessoa = int.Parse(Console.ReadLine());
                Console.Write("Digite o nome da pessoa: ");
                nomePessoa = Console.ReadLine();
                Console.Write("Digite o email: ");
                email = Console.ReadLine();
            }
            catch (Exception excecao)
            {
                Console.WriteLine($"Digite os dados corretamente\nErro: {excecao.Message}");
            }
        }

        public virtual string mostrarDados()
        {
            return $"------Exibindo dados da Pessoa------\nId Pessoa: {idPessoa}\nNome da pessoa: {nomePessoa}\nIdade: {idade}\nEmail: {email}\n";
        }

        abstract public void calcularIdade(int anoAtual);
    }
}
