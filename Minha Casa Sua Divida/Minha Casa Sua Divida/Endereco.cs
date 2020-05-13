using System;

namespace Minha_Casa_Sua_Divida
{
    class Endereco
    {
        private string rua;
        private int numero;
        private string bairro;
        private int cep;
        private string cidade;

        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public int Cep { get; set; }
        public string Cidade { get; set; }

        public Endereco()
        {
            Rua = null;
            Numero = 0;
            Bairro = null;
            Cep = 0;
            Cidade = null;
        }

        public Endereco(string rua, int numero, string bairro, int cep, string cidade)
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cep = cep;
            Cidade = cidade;
        }

        public void lerDados()
        {
            Console.Write("Digite a rua do imóvel: ");
            Rua = Console.ReadLine();
            Console.Write("Digite o numero do endereço do imóvel: ");
            Numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o bairro do imóvel: ");
            Bairro = Console.ReadLine();
            Console.Write("Digite o cep do imóvel: ");
            Cep = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a cidade do imóvel: ");
            Cidade = Console.ReadLine();
            Console.Clear();
        }

        public string mostrarDados()
        {
            return $"Rua: {Rua}\nNumero: {Numero}\nBairro: {Bairro}\nCep: {Cep}\nCidade: {Cidade}";
        }
    }
}
