using System;
class Program
{
    static void Main()
    {
        // Problema 1
        Console.WriteLine("Problema 1");
        double menor = Double.MaxValue;//Sirve para poner el numero maximo que puede ponerse con un double, para que asi siempre reconozca al menor
        double promedio = 0;
        double mayor = double.MinValue;//Sirve para poner el numero minimo que puede ponerse con double, para que asi siempre reconozca al mayor
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("Ingrese el numero");
            
            double num = int.Parse(Console.ReadLine());
            promedio += num;
            if (num>mayor)
            {
                mayor = num;
            }
            if (num<menor)
            {
                menor = num;
            }

        }
        promedio = promedio / 20;
        Console.WriteLine("El mayor es: " + mayor);
        Console.WriteLine("El menor es: " + menor);
        Console.WriteLine("El promedio es: " + promedio);

        // Problema 2
        Console.WriteLine();
        Console.WriteLine("Problema 2");
        for (int i2 = 1; i2 <= 100; i2++)
        {
            if (i2%2==0 && i2%7==0)
            {
                Console.WriteLine("ParSiete");
            }else if (i2 % 2 == 0)
            {
                Console.WriteLine("Par");
            } else if (i2 % 7 == 0)
            {
                Console.WriteLine("Siete");
            }
            else
            {
                Console.WriteLine(i2);
            }

        }

        // Problema 3
        Console.WriteLine();
        Console.WriteLine("Problema 3");
        int cantidadd = 0;
        double totalv = 0;
       
        for (int i3 = 0; i3 < 10; i3++)
        {
            Console.WriteLine("Ingrese el monto de compra");
            double compra = double.Parse(Console.ReadLine());
            
            if (compra>700)
            {
                compra = compra - (compra * 5 / 100);
                cantidadd++;
            }
            else if(compra>300)
            {
                compra = compra - (compra * 12 / 100);
                cantidadd++;
            }

            totalv += compra;
            Console.WriteLine("El total de la compra del cliente es: " + compra);
        }
        Console.WriteLine("Reporte final:");
        Console.WriteLine("El total de descuentos es: " + cantidadd);
        Console.WriteLine("El total de ventas es: " + totalv);

        // Problema 4
        Console.WriteLine();
        Console.WriteLine("Problema 4");
        Console.WriteLine("Ingresa un numero entero");
        int entero = int.Parse(Console.ReadLine());
        Console.WriteLine("Elige ahora una opcion: \n 1.Mostrar los numeros desde el numero ingresado hasta 1 \n 2. Mostrar los multiplos de 3 hasta el numero ingresado \n 3. Mostrar los multiplos de 5 hasta el numero ingresado");
        int opcion = int.Parse(Console.ReadLine());
        Console.WriteLine("Respuesta:");
        switch (opcion)
        {
            case 1:
                while (entero>=1)
                {
                    Console.WriteLine(entero);
                    entero--;
                }
                break;
            case 2:
                for (int i = 1; i <= entero; i++)
                {
                    if (i%3==0)
                    {
                        Console.WriteLine(i);
                    }
                }
                break;
            case 3:
                for (int i = 1; i <= entero; i++)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                break;
        }
        // Problema 5
        Console.WriteLine();
        Console.WriteLine("Problema 5");
        Console.WriteLine("Ingrese el numero de filas para el triangulo de asteriscos");
        int filas = int.Parse(Console.ReadLine());
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }            Console.WriteLine();
        }
    }
}
