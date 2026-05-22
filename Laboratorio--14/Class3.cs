using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace L14_JCAA_1227526
{
    internal class Estudiante
    {
        string nombre;
        int edad;
        string grado;
        decimal[] notas;

        public Estudiante(string nombre, int edad, string grado, decimal[] notas) {
        this.nombre = nombre;
        this.edad = edad;  
        this.grado = grado;
        this.notas = notas;
        }
        public decimal calcularPromedio()
        {
            decimal promedio = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                promedio += notas[i];
            }
            promedio = promedio / notas.Length;
            return Math.Round(promedio,2);
        }
        public void mostrarInformacion()
        {
            Console.WriteLine("El nombre es: "+nombre);
            Console.WriteLine("La edad es: " + edad);
            Console.WriteLine("El grado es: " + grado);
            Console.WriteLine("Las notas son: ");
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write(notas[i]+", ");
            }
            Console.WriteLine("El promedio es: "+calcularPromedio());
        }
        public void aprobar()
        {
            decimal prom = calcularPromedio();
            if (prom>=61)
            {
                Console.WriteLine("Aprobo");
            }
            else
            {
                Console.WriteLine("Reprobo");
            }
        }
        public decimal agregarNota(decimal nuevaNota)
        {
            decimal[] nuevasNotas = new decimal[notas.Length + 1];

            for (int i = 0; i < notas.Length; i++)
            {
                nuevasNotas[i] = notas[i];
            }

            nuevasNotas[notas.Length] = nuevaNota;

            notas = nuevasNotas;
            return calcularPromedio() ;
        }
    }
}
