using System;

namespace CalculadoraPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculadora();
            var historial = new Historial();
            string respuesta = ""; // Inicializada para evitar CS0165

            do
            {
                Console.WriteLine("=== CALCULADORA ===");

                Console.Write("Ingresa el primer número: ");
                var num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingresa el segundo número: ");
                var num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nElige una opción:");
                Console.WriteLine("1. SUMA");
                Console.WriteLine("2. RESTA");
                Console.WriteLine("3. MULTIPLICACION");
                Console.WriteLine("4. DIVISION");
                Console.WriteLine("5. POTENCIA");
                Console.WriteLine("6. RAIZ CUADRADA (del primer número)");
                Console.WriteLine("7. LOGARITMO (del primer número)");
                Console.Write("Opción: ");

                var opcion = Convert.ToInt32(Console.ReadLine());
                double resultado = 0;
                string operacion = "";

                try
                {
                    switch (opcion)
                    {
                        case 1:
                            resultado = calc.Sumar(num1, num2);
                            operacion = $"{num1} + {num2} = {resultado}";
                            break;
                        case 2:
                            resultado = calc.Restar(num1, num2);
                            operacion = $"{num1} - {num2} = {resultado}";
                            break;
                        case 3:
                            resultado = calc.Multiplicar(num1, num2);
                            operacion = $"{num1} * {num2} = {resultado}";
                            break;
                        case 4:
                            resultado = calc.Dividir(num1, num2);
                            operacion = $"{num1} / {num2} = {resultado}";
                            break;
                        case 5:
                            resultado = Math.Pow(num1, num2);
                            operacion = $"{num1} ^ {num2} = {resultado}";
                            break;
                        case 6:
                            resultado = Math.Sqrt(num1);
                            operacion = $"√{num1} = {resultado}";
                            break;
                        case 7:
                            resultado = Math.Log(num1);
                            operacion = $"log({num1}) = {resultado}";
                            break;
                        default:
                            Console.WriteLine("Opción no válida");
                            continue;
                    }

                    Console.WriteLine("\n" + operacion);
                    historial.Agregar(operacion);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                historial.Mostrar();

                Console.WriteLine("\n¿Desea realizar otra operación? (s/n)");
                respuesta = Console.ReadLine()?.ToLower();

            } 
            while (respuesta == "s");

            Console.WriteLine("¡Hasta luego!");
            Console.ReadKey();
        }
    }
}