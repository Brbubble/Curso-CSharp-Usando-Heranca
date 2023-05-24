using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Usando_Heranca_Desafios.Calculadora
{
    public class Calculadora
    {
        public double numero1 { get; set; }
        public double numero2 { get; set; }

        public Calculadora(double num1, double num2)
        {
            numero1 = num1;
            numero2 = num2;
        }
        public double Somar()
        {
            return numero1 + numero2;
        }

        public double Subtrair()
        {
            return numero1 - numero2;
        }

        public double Multiplicar()
        {
            return numero1 * numero2;
        }
        public double Dividir()
        {
            if (numero2 != 0)
                return numero1 / numero2;
            else
                throw new DivideByZeroException("Não é possivel dividir por Zero");
        }
    }
}
