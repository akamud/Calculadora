using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculadora
    {
        public double Soma(double valor1, double valor2) => valor1 + valor2;

        public double Divide(double valor1, double valor2)
        {
            if (valor2 == 0)
                return double.NaN;

            return valor1 / valor2;
        }
    }
}
