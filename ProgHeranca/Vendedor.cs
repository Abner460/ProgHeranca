using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHeranca
{
    class Vendedor : Colaborador
    {
        private double valorVendas;
        private double comissao;
        public Vendedor(string nomev, string endev, string telev) : base(nomev, endev, telev)
        {

        }

        public double ValorVendas
        {
            get { return valorVendas; }
            set { valorVendas = value; }
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
