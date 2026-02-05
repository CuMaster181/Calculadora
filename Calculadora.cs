using System;

namespace CalculadoraPOO
{
    public class Calculadora
    {
        public double Sumar(double a, double b) => a + b;

        public double Restar(double a, double b) => a - b;

        public double Multiplicar(double a, double b) => a * b;

        public double Dividir(double a, double b)
        {
            if (b == 0)
                throw new Exception("No se puede dividir entre cero");

            return a / b;
        }
    }
}
