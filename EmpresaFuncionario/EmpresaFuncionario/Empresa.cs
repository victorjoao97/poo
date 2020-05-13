using System;
using System.Collections.Generic;
using System.Text;

namespace EmpresaFuncionario
{
    class Empresa
    {
        private string nome, cnpj, endereco, email, funcionario, dataFundacao, patrimonio;

        public Empresa()
        {
            Nome = null;
            Cnpj = null;
            Endereco = null;
            Email = null;
            DataFundacao = null;
            Patrimonio = null;
        }

        public Empresa(string nome, string cnpj, string endereco, string email, string dataFundacao, string patrimonio)
        {
            this.Nome = nome;
            this.Cnpj = cnpj;
            this.Endereco = endereco;
            this.Email = email;
            this.DataFundacao = dataFundacao;
            this.Patrimonio = patrimonio;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Endereco { get => Endereco1; set => Endereco1 = value; }
        public string Endereco1 { get => endereco; set => endereco = value; }
        public string Email { get => email; set => email = value; }
        public string Funcionario { get => funcionario; set => funcionario = value; }
        public string DataFundacao { get => dataFundacao; set => dataFundacao = value; }
        public string Patrimonio { get => patrimonio; set => patrimonio = value; }

        public void LerDados()
        {
            try
            {
                Console.WriteLine("\n --- Dados da Empresa ----\n");
                Console.Write("Nome: ");
                Nome = Console.ReadLine();
                Console.Write("CNPJ: ");
                Cnpj = Console.ReadLine();
                Console.Write("Endereco: ");
                Endereco = Console.ReadLine();
                Console.Write("Email: ");
                Email = Console.ReadLine();
                Console.Write("Data fundação: ");
                DataFundacao = Console.ReadLine();
                Console.Write("Patrimonio: ");
                Patrimonio = Console.ReadLine();
            }catch(Exception err)
            {
                Console.WriteLine("erro");
            }
        }

        public void MostrarDados()
        {
            Console.WriteLine($"\n Nome empresa: {Nome}\n CNPJ: {Cnpj}\n Endereço: {Endereco}\n Email: {Email}\n Patrimonio: R$ {Patrimonio}");
        }
    }
}
