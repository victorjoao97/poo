using System;

namespace ProjetoAgenciaBancaria
{
    class Conta
    {
        /**
         * declarar os atributos da classe
         * */
        public string numero;
        public double saldo, limite;

        // Construtor

        public Conta()
        {
            numero = null;
            saldo = 0;
            limite = 0;
        }

        // implementar os metodos
        public void Saca(double valor)
        {
            if (valor <= (saldo + limite))
                saldo -= valor;
            else
                Console.WriteLine("Saldo insuficiente");
        }

        public void Deposita(double valor)
        {
            saldo += valor;
        }

        public string VerSaldo()
        {
            return $"No. da Conta: {numero}\n Saldo R$ {saldo}\nLimite R$ {limite}\nTotal R$ {saldo + limite}";
        }
    }
}
