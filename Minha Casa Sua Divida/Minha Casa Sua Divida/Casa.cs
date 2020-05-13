using System;

namespace Minha_Casa_Sua_Divida
{
    class Casa: Imovel
    {
        private double areaConstruida;
        private int nroComodos;

        public double AreaConstruida { get; set; }
        public int NroComodos { get; set; }

        public Casa(): base()
        {
            AreaConstruida = 0;
            NroComodos = 0;
        }
        
        public Casa(double valor, double area, string estilo, Endereco endereco, double areaConstruida, int nroComodos): base(valor, area, estilo, endereco)
        {
            AreaConstruida = areaConstruida;
            NroComodos = nroComodos;
        }

        public override void lerDados()
        {
            base.lerDados();
            Console.Write("Digite a área construida da casa: ");
            AreaConstruida = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o número de cômodos da casa: ");
            NroComodos = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
        }

        public override string mostrarDados()
        {
            return $"{base.mostrarDados()}\nÁrea construída: {AreaConstruida}\nCômodos: {NroComodos}";
        }
    }
}
