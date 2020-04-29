using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHeranca
{
    class Colaborador : Pessoa
    {
        private int codSetor;
        private double salarioBase;
        private int impostos;

        public Colaborador(string nomec, string endec, string telec) : base(nomec, endec, telec)
        {

        }

        public int CodSetor
        {
            get { return codSetor; }
            set { codSetor = value; }
        }

        public double SalarioBase
        {
            get { return salarioBase; }
            set { salarioBase = value; }
        }

        public int Impostos
        {
            get { return impostos; }
            set { this.impostos = value; }
        }

        public virtual double calcularSalario()
        {
            return SalarioBase - Impostos;
        }

    }
}
