using System;
using System.Collections.Generic;
using System.Text;

namespace PjtPessoaFisicaJuridica
{
    // A classe Juridica está herdando a classe Pessoa ( : significa herança)
    class Juridica: Pessoa
    {
        // declaração dos atributos
        private string cpf;
        private string cnpj;

        // Implementar o Construtor
        public Juridica() : base()
        {
            Console.WriteLine("\n Executando o construtor SEM  parâmetros da Classe Juridica");
            cpf = null;
            cnpj = null;
        }

        // Sobrecarga do Construtor
        public Juridica(string nome, string email, string endereco, string bairro,
            string numero, string cidade, string uf, string cep, string telefone,
            string cpf, string cnpj)
            : base(nome, email, endereco, bairro, numero, cidade, uf, cep, telefone)
        {
            Console.WriteLine("\n Executando o construtor COM  parâmetros da Classe Fisica");
            this.cpf = cpf;
            this.cnpj = cnpj;
        }

        // Implementar as Propriedades
        public string CPf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string CnpJ
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        // Implementar o Método
        public override string VerDados()
        {
            return base.VerDados() +
                "\n\n Dados da Pessoa Júridica" +
                "\n No. CPF: " + CPf +
                "\n No. RG: " + CnpJ;
        }
    }
}
