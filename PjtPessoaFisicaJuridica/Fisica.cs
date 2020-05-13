using System;
using System.Collections.Generic;
using System.Text;

namespace PjtPessoaFisicaJuridica
{
    // A classe Fisica está herdando a classe Pessoa ( : significa herança)
    class Fisica : Pessoa
    {
        // declaração dos atributos
        private string cpf;
        private string rg;

        // Implementar o Construtor
        public Fisica() : base()
        {
            Console.WriteLine("\n Executando o construtor SEM  parâmetros da Classe Fisica");
            cpf = null;
            rg = null;
        }

        // Sobrecarga do Construtor
        public Fisica(string nome, string email, string endereco, string bairro,
            string numero, string cidade, string uf, string cep, string telefone, 
            string cpf, string rg) 
            : base(nome, email, endereco, bairro,numero, cidade, uf, cep, telefone)
        {
            Console.WriteLine("\n Executando o construtor COM  parâmetros da Classe Fisica");
            this.cpf = cpf;
            this.rg = rg;
        }

        // Implementar as Propriedades
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        // Implementar o Método
        public override string VerDados()
        {
            return base.VerDados() + 
                "\n\n Dados da Pessoa Física" + 
                "\n No. CPF: " + Cpf +
                "\n No. RG: " + Rg;
        }
    }
}
