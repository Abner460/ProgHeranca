using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Fornecedor f1 = new Fornecedor("Rodrigo", "Elói Mendes", "(35) 3264-1111");
            f1.ValorCredito = 1000.00;
            f1.ValorDivida = 316.12;
            Console.WriteLine("Fornecedor, saldo de : " + f1.obterSaldo());

            Colaborador c = new Colaborador("Jonny", "Belém do pará", "(91) 3206-9600");
            c.CodSetor = 40;
            c.SalarioBase = 816.12;
            c.Impostos = 2;
            Console.WriteLine("Colaborador, salário : " + c.calcularSalario());

            Administrador a = new Administrador("André", "Alfenas", "(35) 3271-9600");
            a.CodSetor = 30;
            a.SalarioBase = 926.12;
            a.Impostos = 2;
            a.AjudaDeCusto = 215.32;
            Console.WriteLine("Administrador, salário : " + a.calcularSalario());

            Operario o = new Operario("Emerson", "Alfenas", "(35) 3214-4560");
            o.CodSetor = 30;
            o.SalarioBase = 926.12;
            o.Impostos = 2;
            o.ValorProducao = 217.50;
            o.Comissao = 3;
            Console.WriteLine("Operário, salário : " + o.calcularSalario());

            Vendedor v = new Vendedor("Rodrigo", "Elói Mendes", "(35) 3214-2125");
            v.CodSetor = 30;
            v.SalarioBase = 926.12;
            v.Impostos = 2;
            v.ValorVendas = 523.12;
            v.Comissao = 5;
            Console.WriteLine("Vendedor, salário : " + v.calcularSalario());

            Console.ReadKey();
        }
    }
}
