using System;
using System.Collections.Generic;
using System.Text;

namespace L14_JCAA_1227526
{
    internal class Producto
    {
        string nombre;
        decimal precio;
        int cantidad;
        public Producto(string nombre, decimal precio, int cantidad) { 
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }
        public void mostrarInformacion()
        {
            Console.WriteLine("El nombre del producto es: " + nombre + " \n El precio del producto es Q: " + precio + "\n La cantidad del producto es: " + cantidad);
        }
        public void vender(int cantidadVendida)
        {
            if (cantidad>=cantidadVendida)
            {
                cantidad -= cantidadVendida;
            }
            else
            {
                Console.WriteLine("No hay suficiente stock");

            }
        }
        public void reabastecer(int cantidadNueva)
        {
            cantidad += cantidadNueva;
        }
    }
}
