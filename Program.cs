using System;

namespace CalculadoraPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            Console.WriteLine("=== CALCULADORA ===");

            Console.Write("Ingresa el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingresa el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nElige una opción:");
            Console.WriteLine("1. SUMA");
            Console.WriteLine("2. RESTA");
            Console.WriteLine("3. MULTIPLICACION");
            Console.WriteLine("4. DIVISION");
            Console.WriteLine("5. POTENCIA");
            Console.WriteLine("6. RAIZ CUADRADA (del primer número)");
            Console.WriteLine("7. LOGARITMO (del primer número)");
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
                    case 5:
                        resultado = Math.Pow(num1, num2);
                        break;
                    case 6:
                        resultado = Math.Sqrt(num1);
                        break;
                    case 7:
                        resultado = Math.Log(num1);
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        return;
                }

                Console.WriteLine($"\nResultado: {resultado}");
                Console.WriteLine("desea realizar otra operacion? (s/n)");
                string respuesta = Console.ReadLine();
                if (respuesta.ToLower() == "s")
                {
                    Main(args);
                }
                else if(respuesta.ToLower() == "n")
                {
                    Console.WriteLine("Gracias por usar la calculadora. ¡Hasta luego!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}
