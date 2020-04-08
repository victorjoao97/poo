using System;

namespace InstituicaoCurso
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso curso1 = new Curso();
            Curso curso2 = new Curso("Ciencias da computacao", 4, 8, 3600, "UNIRP", "Educacao Superior", "1965", 55, 40);

            try
            {
                Instituicao instituicao = new Instituicao();
                Console.WriteLine("------Cadastro dos dados da instituicao -----");
                Console.Write("Nome: ");
                instituicao.Nome = Console.ReadLine();
                Console.Write("Area de atuacao: ");
                instituicao.AreaAtuacao = Console.ReadLine();
                Console.Write("Data de fundacao: ");
                instituicao.DataFundacao = Console.ReadLine();
                Console.Write("Anos de existência: ");
                instituicao.QtdAnosExistencia = Convert.ToInt32(Console.ReadLine());
                Console.Write("Quantidade de cursos: ");
                instituicao.QtdCursos = Convert.ToInt32(Console.ReadLine());

                curso1.Instituicao = instituicao;

                Console.WriteLine("------Cadastro dos dados do Cursoi -----");
                Console.Write("Nome: ");
                curso1.Nome = Console.ReadLine();
                Console.Write("Anos: ");
                curso1.QtdAnos = Convert.ToInt32(Console.ReadLine());
                curso1.QtdSemestres = curso1.QtdAnos * 2;
                Console.Write("Carga horária: ");
                curso1.CargaHoraria = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                curso1.MostrarDados();

                Console.WriteLine("-----------------------------------");

                curso2.MostrarDados();
            }catch(Exception ex)
            {
                Console.WriteLine($"erro de digitacao: ", ex.Message);
            }

            Console.ReadKey();
        }
    }
}
