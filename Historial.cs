using System;
using System.Collections.Generic;

namespace CalculadoraPOO
{
    public class Historial
    {
        public List<string> Operaciones { get; } = new List<string>();

        public void Agregar(string operacion)
        {
            Operaciones.Add(operacion);
        }

        public void Mostrar()
        {
            Console.WriteLine("\n--- Historial ---");
            foreach (var op in Operaciones)
            {
                Console.WriteLine(op);
            }
        }
    }
}
