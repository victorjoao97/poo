using System;
using System.Collections.Generic;
using System.Text;

namespace InstituicaoCurso
{
    class Curso
    {
        private int qtdAnos;
        private int qtdSemestres;
        private int cargaHoraria;
        private Instituicao instituicao;

        public Curso()
        {
            Nome = null;
            qtdAnos = 0;
            qtdSemestres = 0;
            cargaHoraria = 0;
            instituicao = new Instituicao();
        }

        public Curso(string nome, int qtdAnos, int qtdSemestres, int cargaHoraria, string instNome, string instAreaAtuacao, string instDataFundacao, int instQtdAnosExistencia, int intCursos)
        {
            this.Nome = nome;
            this.qtdAnos = qtdAnos;
            this.qtdSemestres = qtdSemestres;
            this.cargaHoraria = cargaHoraria;
            this.instituicao = new Instituicao(instNome, instAreaAtuacao, instDataFundacao, instQtdAnosExistencia, intCursos);
        }

        public void MostrarDados()
        {
            Console.WriteLine($"------Dados do curso-----\nNome do curso: {Nome}\n" +
             $"Data de anos: {QtdAnos}\nQuantidade de semestres: {QtdSemestres}\nCarga horaria: {CargaHoraria}");
        }

        public string Nome { get; set; }
        public int QtdAnos { get => qtdAnos; set => qtdAnos = value; }
        public int QtdSemestres { get => qtdSemestres; set => qtdSemestres = value; }
        public int CargaHoraria { get => cargaHoraria; set => cargaHoraria = value; }
        internal Instituicao Instituicao { get => instituicao; set => instituicao = value; }
    }
}
