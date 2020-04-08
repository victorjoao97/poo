using System;

namespace ProjetoAgenciaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            // Instaciar a classe Conta criando um objeto
            Conta minhaConta = new Conta();
            Agencia minhaAgencia = new Agencia();

            try
            {
                Console.WriteLine("\nDigite o numero da Conta: ");
                minhaConta.Numero = Console.ReadLine();
                Console.WriteLine("Digite o saldo inicial: ");
                minhaConta.Saldo = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o limite inicial: ");
                minhaConta.Limite = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o nome da Agencia: ");
                minhaAgencia.Nome = Console.ReadLine();
                Console.Write("Digite o numero da agencia: ");
                minhaAgencia.Numero = Console.ReadLine();
                Console.Write("Digite o endereco da agencia: ");
                minhaAgencia.Endereco = Console.ReadLine();

                minhaConta.Agencia = minhaAgencia;
            }
            catch (FormatException)
            {
                Erros("Digite um número válido");
            }
            catch (Exception e)
            {
                Erros($"\nErro! {e.Message}");
            }

            do
            {
                Console.WriteLine("\n\n-------Menu-------");
                Console.WriteLine("1 - Sacar\n2 - Depositar\n3 - Ver Saldo\n4 - Sair do programa");
                Console.Write("\nDigite sua opção: \n");
                try
                {
                    opcao = Convert.ToInt32(Console.ReadLine());
                    double valor;
                    switch (opcao)
                    {
                        case 1:
                            Console.Write("Digite o valor do saque: ");
                            valor = Convert.ToDouble(Console.ReadLine());
                            minhaConta.Saca(valor);
                            break;
                        case 2:
                            Console.Write("Digite o valor do Deposito: ");
                            valor = Convert.ToDouble(Console.ReadLine());
                            minhaConta.Deposita(valor);
                            break;
                        case 3:
                            Console.Write(minhaConta.VerSaldo());
                            break;
                        case 4:
                            Console.Write("Programa finalizado com sucesso");
                            break;
                        default:
                            Console.Write("Opção invalida");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Erros("Digite um número válido");
                }
                catch (Exception e)
                {
                    Erros($"\nErro! {e.Message}");
                }

            } while (opcao != 4);

            Conta conta1 = new Conta();

            conta1.Deposita(100);
            conta1.Saca(50);
            Console.WriteLine(conta1.VerSaldo());
        }


        static void Erros(string erros)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(erros);
            Console.ResetColor();
        }
    }
}
