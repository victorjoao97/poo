using System;

namespace PjtPessoaFisicaJuridica
{
    class Program
    {
        static void Main(string[] args)
        {
            Fisica pessoafisica1 = new Fisica();
            Fisica pessoafisica2 = new Fisica("Valéria", "vmvolpe", "Rua A", "Boa Vista",
                "1234F", "Rio Preto", "SP", "15030-400", "4323232", "123.456.789-19", "123.456-3");
            Juridica pessoajuridica1 = new Juridica();
            Juridica pessoajuridica2 = new Juridica("Vitor", "vtrsouza", "Rua Argentina", "Santa Eliza",
                "4334", "Votuporanga", "SP", "155505-190", " ", "123.456.789-19", "12.456/1234-79");
            Console.ReadKey();


            try
            {
                Console.Write("\n Leitura dos dados da Pessoa Física \n");
                Console.Write("\n Nome: ");
                pessoafisica1.Nome = Console.ReadLine();

                Console.Write("\n E-mail: ");
                pessoafisica1.Email = Console.ReadLine();

                Console.Write("\n Rua: ");
                pessoafisica1.Endereco = Console.ReadLine();

                Console.Write("\n No.: ");
                pessoafisica1.Numero = Console.ReadLine();

                Console.Write("\n Bairro: ");
                pessoafisica1.Bairro = Console.ReadLine();

                Console.Write("\n Cidade: ");
                pessoafisica1.Cidade = Console.ReadLine();

                Console.Write("\n Estado: ");
                pessoafisica1.Uf = Console.ReadLine();

                Console.Write("\n CEP: ");
                pessoafisica1.Cep = Console.ReadLine();

                Console.Write("\n No. CPF: ");
                pessoafisica1.Cpf = Console.ReadLine();

                Console.Write("\n Leitura dos dados da Pessoa Júridica \n");

                Console.Write("\n Nome: ");
                pessoajuridica1.Nome = Console.ReadLine();

                Console.Write("\n E-mail: ");
                pessoajuridica1.Email = Console.ReadLine();


                Console.Write("\n CEP: ");
                pessoajuridica1.Cep = Console.ReadLine();

                
                Console.Write("\n No. CNPJ: ");
                pessoajuridica1.CnpJ = Console.ReadLine();
                

                Console.Clear(); // Limpa a Console

                Console.WriteLine("\n Dados da Pessoa Física 1");
                Console.WriteLine(pessoafisica1.VerDados());
                Console.WriteLine("\n Dados da Pessoa Júridica 1");
                Console.WriteLine(pessoajuridica1.VerDados());

                Console.WriteLine("\n\n Dados da Pessoa Física 2");
                Console.WriteLine(pessoafisica2.VerDados());
                Console.WriteLine("\n\n Dados da Pessoa Júridica 2");
                Console.WriteLine(pessoajuridica2.VerDados());

            }
            catch (Exception ex)
            {
                Console.Write("\n Erro " + ex);
            }
        }
    }
}




