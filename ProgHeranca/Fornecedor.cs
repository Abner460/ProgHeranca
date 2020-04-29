using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHeranca
{
    public class Fornecedor : Pessoa
    {
        private double valorCredito;
        private double valorDivida;

        
        public Fornecedor(string nomef, string enderecof, string telefonef) : base(nomef, enderecof, telefonef)
        {
          
        }
       
        public double ValorCredito
        {
            get { return valorCredito; }
            set { valorCredito = value; }
        }

        public double ValorDivida
        {
            get { return valorDivida; }
            set { valorDivida = value; }
        }
        public double obterSaldo()
        {
            if(ValorCredito - ValorDivida >= 0)
            {
                return ValorCredito - ValorDivida;
            }
            return 0;
        }
    }
}
