using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHeranca
{
    public class Pessoa
    {
        private string nome;
        private string endereco;
        private string telefone;

        public Pessoa(string pnome, string pendereco, string ptelefone)
        {
            this.nome = pnome;
            this.endereco = pendereco;
            this.telefone = ptelefone;
        }

        public string Nome
        {
            get { return this.nome; }
            set { nome = value; }
        }

        public string Endereco
        {
            get { return this.endereco; }
            set { endereco = value; }
        }

        public string Telefone
        {
            get { return this.telefone; }
            set { telefone = value; }
        }

    }
}
