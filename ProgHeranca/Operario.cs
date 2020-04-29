using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHeranca
{
    class Operario : Colaborador
    {
        private double valorProducao;
        private double comissao;
        public Operario(string n, string e, string t) : base(n, e, t)
        {

        }

        public double ValorProducao
        {
            get { return valorProducao; }
            set { valorProducao = value; }
        }

        public double Comissao
        {
            get { return comissao; }
            set { comissao = value; }
        }

        public override double calcularSalario()
        {
            return base.calcularSalario() + Comissao;
        }
    }
}
