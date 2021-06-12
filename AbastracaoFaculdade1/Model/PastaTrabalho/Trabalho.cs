using AbastracaoFaculdade1.Model.HerancaPessoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbastracaoFaculdade1.Model
{
    public   class Trabalho
    {
        private long Id;
        private string TituloTrabalho;
        private Faculdade Faculdade;
        private DateTime DataConclusao;
        private Aluno Aluno;
        private Orientador Orientador;
        private Curso Curso;
        private string LocalArquivo;
        private int Score;
        private int QuantidadeDeVotos;

        public  long getId() { return Id; }
        public void setId(long Id) { this.Id = Id; }

        public string getTituloTrabalho() { return TituloTrabalho; }
        public void setTituloTrabalho(string TituloTrabalho) { this.TituloTrabalho = TituloTrabalho; }

        public DateTime getDataConclusao() { return DataConclusao; }
        public void setDataConclusao(DateTime DataConclusao) { this.DataConclusao = DataConclusao; }

        public Faculdade  getFaculdade() { return Faculdade; }
        public  void  setFaculdade(Faculdade Faculdade) { this.Faculdade = Faculdade;  }

        public Aluno getAluno() { return Aluno; }
        public void setAluno(Aluno Aluno) { this.Aluno = Aluno; }
        
      
        public Orientador getOrientador() { return Orientador; }
        public void setOrientador(Orientador Orientador) { this.Orientador = Orientador; }

        public Curso getCurso() { return Curso; }
        public void setCurso(Curso Curso) { this.Curso = Curso; }

        public string getLocalArquivo() { return LocalArquivo; }
        public void setLocalArquivo(string LocalArquivo) { this.LocalArquivo = LocalArquivo; }

        public int getScore() { return Score; }
        public void setScore(int Score) { this.Score = Score; }

        public int getQuantidadeDeVotos() { return QuantidadeDeVotos; }
        public void setQuantidadeDeVotos(int QuantidadeDeVotos) { this.QuantidadeDeVotos = QuantidadeDeVotos; }




    }
    
}
