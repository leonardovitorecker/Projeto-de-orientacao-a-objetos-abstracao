using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbastracaoFaculdade1.Model.HerancaPessoa
{
    public  class Aluno:Pessoa
    {
        private long Id;
        private string Email;

        public long getId() { return Id; }
        public void setId(long Id) { this.Id = Id; }

        public string getEmail() { return Email; }
        public void setEmail(string Email) { this.Email = Email; }
    }
}
