using System;

namespace Minha_Casa_Sua_Divida
{
    class Apartamento : Imovel
    {
        private int nroVagasGaragem;
        private int nroQuartos;

        public int NroVagasGaragem { get; set; }
        public int NroQuartos { get; set; }

        public Apartamento() : base()
        {
            NroVagasGaragem = 0;
            NroQuartos = 0;
        }

        public Apartamento(double valor, double area, string estilo, Endereco endereco, int nroVagasGaragem, int nroQuartos) : base(valor, area, estilo, endereco)
        {
            NroVagasGaragem = nroVagasGaragem;
            NroQuartos = nroQuartos;
        }

        public override void lerDados()
        {
            base.lerDados();
            Console.Write("Digite o número de vagas de garagem do apartamento: ");
            NroVagasGaragem = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o número de quartos do apartamento: ");
            NroQuartos = Convert.ToInt32(Console.ReadLine());
        }

        public override string mostrarDados()
        {
            return $"{base.mostrarDados()}\nVagas de garagem: {NroVagasGaragem}\nQuartos: {NroQuartos}";
        }
    }
}
