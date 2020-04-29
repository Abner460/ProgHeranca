using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHeranca
{
    class Administrador : Colaborador
    {
        private double ajudaDeCusto;

        public Administrador(string anome, string aende, string atelef) : base(anome, aende, atelef)
        {

        }

        public double AjudaDeCusto
        {
            get { return ajudaDeCusto; }
            set { ajudaDeCusto = value; }
        }

        public override double calcularSalario()
        {
            return base.calcularSalario() + AjudaDeCusto;
        }
    }
}
