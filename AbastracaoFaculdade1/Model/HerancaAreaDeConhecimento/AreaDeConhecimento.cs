using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbastracaoFaculdade1.Model
{
    public abstract class AreaDeConhecimento
    {
        private long Id;

        private string Titulo;


        public long getId() { return Id; }
        public void setTamanho(long Id) { this.Id = Id; }

        public string getTitulo() { return Titulo; }
        public void setTitulo(string Titulo) { this.Titulo = Titulo; }
    }
}
