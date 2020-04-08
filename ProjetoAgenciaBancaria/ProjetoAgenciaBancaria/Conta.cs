using System;

namespace ProjetoAgenciaBancaria
{
    class Conta
    {
        /**
         * declarar os atributos da classe
         * */

        public string Numero { get; set; }
        public double Saldo { get; set; }
        public double Limite { get; set; }
        internal Agencia Agencia { get; set; }

        // Construtor

        public Conta()
        {
            Numero = null;
            Saldo = 0;
            Limite = 0;
            Agencia = new Agencia();
        }

        // implementar os metodos
        public void Saca(double valor)
        {
            if (valor <= (Saldo + Limite))
                Saldo -= valor;
            else
                Console.WriteLine("Saldo insuficiente");
        }

        public void Deposita(double valor)
        {
            Saldo += valor;
        }

        public string VerSaldo()
        {
            return $"No. da Conta: {Numero}\n Saldo R$ {Saldo}\nLimite R$ {Limite}\nTotal R$ {Saldo + Limite}\n----- Dados da sua agencia---- -\nNumero: { Agencia.Numero}\nNome:{Agencia.Nome}\nEndereço: {Agencia.Endereco}";
        }
    }
}
