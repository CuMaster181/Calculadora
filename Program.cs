using System;

namespace CalculadoraPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            Console.WriteLine("=== CALCULADORA POO ===");

            Console.Write("Ingresa el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nElige una opción:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.Write("Opción: ");

            int opcion = Convert.ToInt32(Console.ReadLine());
            double resultado = 0;

            try
            {
                switch (opcion)
                {
                    case 1:
                        resultado = calc.Sumar(num1, num2);
                        break;
                    case 2:
                        resultado = calc.Restar(num1, num2);
                        break;
                    case 3:
                        resultado = calc.Multiplicar(num1, num2);
                        break;
                    case 4:
                        resultado = calc.Dividir(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        return;
                }

                Console.WriteLine($"\nResultado: {resultado}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            Console.ReadKey();
        }
    }
}
