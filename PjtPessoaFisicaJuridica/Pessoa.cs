using System;
using System.Collections.Generic;
using System.Text;

namespace PjtPessoaFisicaJuridica
{
    class Pessoa
    {
        // declaração dos atributos
        private string nome;
        private string email;
        private string endereco;
        private string bairro;
        private string numero;
        private string cidade;
        private string uf;
        private string cep;

        protected string telefone;

        // Implementar o Construtor
        public Pessoa()
        {
            Console.WriteLine("\n Executando o construtor SEM parâmetros da Classe Pessoa");
            nome = null;
            email = null;
            endereco = null;
            bairro = null;
            numero = null;
            cidade = null;
            uf = null;
            cep = null;
            telefone = null;
        }

        // Sobrecarga do Construtor
        public Pessoa(string nome, string email, string endereco, string bairro,
            string numero, string cidade, string uf, string cep, string telefone)
        {
            Console.WriteLine("\n Executando o construtor COM  parâmetros da Classe Pessoa");
            this.nome = nome;
            this.email = email;
            this.endereco = endereco;
            this.bairro = bairro;
            this.numero = numero;
            this.cidade = cidade;
            this.uf = uf;
            this.cep = cep;
            this.telefone = telefone;
        }

        // implementar as propriedades
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        // Implementar do método
        // O método será sobrescrito nas classes Fisica e Juridica
        public virtual string VerDados()
        {
            return "\n Dados da Pessoa \n Nome: " + Nome +
                "\n E-mail:" + Email + "\n Rua: " + Endereco +
                "\n No.: " + Numero + "\n Bairro: " + Bairro +
                "\nCidade: " + Cidade + "\n Estado: " + Uf +
                "\n CEP: " + Cep + "\n Telefone: " + Telefone;
        }
    }
}
