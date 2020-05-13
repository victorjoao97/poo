using System;

namespace Minha_Casa_Sua_Divida
{
    class Imovel
    {
        private double valor;
        private double area;
        private string estilo;
        private Endereco endereco;

        public double Valor { get; set; }
        public double Area { get; set; }
        public string Estilo { get; set; }
        public Endereco Endereco { get; set; }

        public Imovel()
        {
            Valor = 0;
            Estilo = null;
            Area = 0.0;
            Endereco = new Endereco();
        }

        public Imovel(double valor, double area, string estilo, Endereco endereco)
        {
            Valor = valor;
            Area = area;
            Estilo = estilo;
            Endereco = endereco;
        }

        public virtual void lerDados()
        {
            Console.Write("Digite o valor do imóvel: ");
            Valor = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o estilo do imóvel: ");
            Estilo = Console.ReadLine();
            Console.Write("Digite a area do imóvel: ");
            Area = Convert.ToDouble(Console.ReadLine());
            Endereco endereco = new Endereco();
            Console.Clear();
            endereco.lerDados();
            Endereco = endereco;
        }

        public virtual string mostrarDados()
        {
            return $"Valor: {Valor}\nEstilo: {Estilo}\nÁrea: {Area}\n{Endereco.mostrarDados()}";
        }
    }
}
