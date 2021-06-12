using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbastracaoFaculdade1.Model.PastaUsuario
{
   public abstract  class Usuario

    {
        private long Id;
        private string Login;
        private string Senha;

        public long getId() { return Id; }
        public void setId(long Id) { this.Id = Id; }

        public string getLogin() { return Login; }
        public void setLogin(string Login) { this.Login = Login; }

        public string getSenha() { return Senha; }
        public void setSenha(string Senha) { this.Senha = Senha; }

    }
}
