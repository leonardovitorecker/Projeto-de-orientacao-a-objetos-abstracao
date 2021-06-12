using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbastracaoFaculdade1.Model
{
    public abstract class Pessoa
    {
        private string Nome;
        private DateTime DataNascimento;
        private long Cpf;



        public string getNome() { return Nome; }
        public void setNome(string Nome) { this.Nome = Nome; }

        public DateTime getDataNascimento() { return DataNascimento; }
        public void setDataNascimento(DateTime DataNascimento) { this.DataNascimento = DataNascimento; }

        public long getCpf() { return Cpf; }
        public void setCpf(long Cpf) { this.Cpf = Cpf; }

    }
}
