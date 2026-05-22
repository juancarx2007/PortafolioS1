using L14_JCAA_1227526;
using System;
using System.Timers;
class Program
{
    static void Main()
    {
       //Problema 1
       CuentaBancaria cuenta1 = new CuentaBancaria("Juan Carlos Alarcon","12345678",978.50m);//La m sirve para decirle a C# que es decimal, si no tira error. 
       CuentaBancaria cuenta2 = new CuentaBancaria("Maria Granados", "87654321", 1000m);
        cuenta1.mostrarInformacion();
        cuenta2.mostrarInformacion();
        Console.WriteLine("Depositos");
        cuenta1.depositar(100m);
        cuenta2.depositar(50.50m);
        Console.WriteLine("Dinero despues de depositos");
        cuenta1.mostrarInformacion();
        cuenta2.mostrarInformacion();
        Console.WriteLine("retiros");
        cuenta1.retirar(50.50m);
        cuenta2.retirar(100);
        Console.WriteLine("Dinero despues de retiros");
        cuenta1.mostrarInformacion();
        cuenta2.mostrarInformacion();
        Console.WriteLine();
        Console.WriteLine();

        //Problema 2
        Producto producto1 = new Producto("Shampoo",80.90m,5);
        Producto producto2 = new Producto("Play5", 999.99m, 15);
        producto1.mostrarInformacion();
        producto2.mostrarInformacion();
        Console.WriteLine();
        Console.WriteLine("Ventas");

        producto1.vender(5);
        producto2.vender(10);
        producto1.mostrarInformacion();
        producto2.mostrarInformacion();
        Console.WriteLine();
        Console.WriteLine("Reabastecimiento");

        producto1.reabastecer(10);
        producto2.reabastecer(5);
        producto1.mostrarInformacion();
        producto2.mostrarInformacion();    
        
        Console.WriteLine();
        Console.WriteLine();
        //Problema 3
        decimal[] notas1 = { 80, 80, 100 };
        decimal[] notas2 = { 40, 20, 50 };
        Estudiante estudiante1 = new Estudiante("Juan Carlos Alarcon", 19, "C6",notas1);
        Estudiante estudiante2 = new Estudiante("Daniel Rodriguez", 18, "C4", notas2);
        Console.WriteLine("El promedio del 1 es:"+estudiante1.calcularPromedio());
        Console.WriteLine("El promedio del 2 es:" + estudiante2.calcularPromedio());
        estudiante1.mostrarInformacion();
        estudiante2.mostrarInformacion();
        estudiante1.aprobar();
        estudiante2.aprobar();
        Console.WriteLine("El nuevo promedio del 1 es: "+estudiante1.agregarNota(88.5m));
        Console.WriteLine("El nuevo promedio del 2 es: " + estudiante2.agregarNota(99.9m));

    }
}