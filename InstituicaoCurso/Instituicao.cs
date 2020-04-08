using System;
using System.Collections.Generic;
using System.Text;

namespace InstituicaoCurso
{
    class Instituicao
    {
        private string nome;
        private string dataFundacao;
        private string areaAtuacao;
        private int qtdCursos;
        private int qtdAnosExistencia;

        // implementar o construtor
        public Instituicao()
        {
            nome = null;
            areaAtuacao = null;
            dataFundacao = null;
            qtdCursos = 0;
            qtdAnosExistencia = 0;
        }

        // sobrecarregar o construtor
        public Instituicao(string nome, string areaAtuacao, string dataFundacao, int qtdAnosExistencia, int qtdCursos)
        {
            this.nome = nome;
            this.areaAtuacao = areaAtuacao;
            this.dataFundacao = dataFundacao;
            this.qtdAnosExistencia = qtdAnosExistencia;
            this.qtdCursos = qtdCursos;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string AreaAtuacao
        {
            get { return areaAtuacao; }
            set { areaAtuacao = value; }
        }
        public string DataFundacao
        {
            get { return dataFundacao; }
            set { dataFundacao = value; }
        }
        public int QtdCursos
        {
            get { return qtdCursos; }
            set { qtdCursos = value; }
        }
        public int QtdAnosExistencia
        {
            get { return qtdAnosExistencia; }
            set { qtdAnosExistencia = value; }
        }

        public void MostrarDados()
        {
            Console.WriteLine($"------Dados da instituicao-----\nNome da instituicao: {Nome}\n" +
             $"Data de fundação: {DataFundacao}\nAnos de existência: {QtdAnosExistencia}\nQuantidade de cursos: {QtdCursos}");
        }
    }
}
