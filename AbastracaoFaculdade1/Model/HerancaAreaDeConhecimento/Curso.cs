using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbastracaoFaculdade1.Model
{
   public abstract class Curso :AreaDeConhecimento
    {
        private AreaDeConhecimento AreaDeConhecimento;
        private string TituloCurso;
        private long CodCurso;


    public string getTituloCurso() { return TituloCurso; }

    public void setTituloCurso(string TituloCurso) { this.TituloCurso = TituloCurso; }

    public long getCodCurso() { return CodCurso; }
    public void setCodCurso( long CodCurso) { this.CodCurso = CodCurso; }

        public AreaDeConhecimento getAreaDeConhecimento() { return AreaDeConhecimento; }
        public void setAreaDeConhecimento(AreaDeConhecimento AreaDeConhecimento) { this.AreaDeConhecimento = AreaDeConhecimento; }
    }
}
