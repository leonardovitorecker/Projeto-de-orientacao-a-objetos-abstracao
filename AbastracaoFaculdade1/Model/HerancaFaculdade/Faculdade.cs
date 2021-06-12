using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbastracaoFaculdade1.Model
{
   public class Faculdade
    {
        private long Cod;
        private string Nome;
        private string Estado;
        private string Cidade;
        private Func<Faculdade> getFaculdade;

       

        public long getCod() { return Cod; }
        public void setCod(long Cod) { this.Cod = Cod; }

        public string getNome() { return Nome; }
        public void setNome(string Nome) { this.Nome = Nome; }

        public string getEstado() { return Estado; }
        public void setEstado(string Estado) { this.Estado = Estado; }

        public string getCidade() { return Cidade; }
        public void setCidade( string Cidade) { this.Cidade = Cidade; }
    }
}
