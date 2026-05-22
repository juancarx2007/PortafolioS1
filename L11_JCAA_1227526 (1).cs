using System;
class Program
{
    static void Main()
    {
        //Problema 1
        Console.WriteLine("Ingrese una palabra");
        string palabra = Console.ReadLine().ToLower();
        bool palindro = true;
        for (int i = palabra.Length - 1; i >= 0; i--)
        {
            if (!(palabra[i] == palabra[palabra.Length - 1 - i]))
            {
                palindro = false;
            }
        }
        Console.WriteLine(palindro);
        //Problema 2
        string[] español = ["rojo", "azul", "amarillo", "blanco", "verde"];
        string[] ingles = ["red", "blue", "yellow", "white", "green"];
        string[] italiano = ["rosso", "blu", "giallo", "bianco", "verde"];
        bool condicion = true;
        while (condicion) {
            Console.WriteLine("Elija una opcion: 1. Practicar lección 2. Terminar lección");
            int opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                Console.WriteLine("Ingrese una palabra en español");
                string esp = Console.ReadLine().ToLower();
                for (int i = 0; i < 5; i++)
                {
                    if (esp == español[i])
                    {
                        Console.WriteLine(español[i] + " " + ingles[i] + " " + italiano[i]);
                    }
                }
            } else if (opcion == 2)
            {
                Console.WriteLine("Cerrar el programa");
                condicion = false;
            }
            else
            {
                Console.WriteLine("Ingrese una opción valida");
            }
        }
        //Problema 3
        Random random = new Random();
        int[] arreglo = new int[10];
        for (int i = 0; i < 10; i++)
        {
            arreglo[i] = random.Next(50, 101);
        }
        bool menu = true;
        while (menu)
        {
            Console.WriteLine("Ingrese la opcion del menu: 1. Reporte de rendimiento. 2. Estadísticas. 3. Salir");
            int opcionmenu = int.Parse(Console.ReadLine());
            if (opcionmenu==1)
            {
                for (int i = 0; i < arreglo.Length; i++)
                {
                    if (arreglo[i]>=50 && arreglo[i] <= 64)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;

                    } else if (arreglo[i] >= 65 && arreglo[i] <= 79)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }

                    Console.Write(arreglo[i] + " ");
                }
                Console.ResetColor();

            }
            else if (opcionmenu == 2)
            {
                double suma = 0;
                int mayor = arreglo[0];
                int menor = arreglo[0];
                for (int i = 0; i < arreglo.Length; i++)
                {
                    suma += arreglo[i];
                    if (arreglo[i] > mayor)
                        mayor = arreglo[i];

                    if (arreglo[i] < menor)
                        menor = arreglo[i];
                }
                double prom = suma/arreglo.Length;
                Console.WriteLine("Estadisticas:");
                Console.WriteLine("Promedio: "+prom);
                Console.WriteLine("Calificación alta: "+mayor);
                Console.WriteLine("Calificación baja: "+menor);
            }
            else if (opcionmenu==3)
            { 
                Console.WriteLine("Cerrar el programa");
                menu = false;
            }
            else
            {
                Console.WriteLine("Opcion invalida");
            }
        }
        //Problema 4
        string[] nombres = ["Ana", "Mario", "Saúl", "Karla", "María", "José"];
        double[] salario_x_hora = [100, 125.50,98.65 ,125 ,132.50 ,102.50 ];
        double[] horas_laboradas = new double[6];

        for (int i = 0; i < nombres.Length; i++)
        {
            Console.WriteLine("Ingrese horas trabajadas de " + nombres[i]);
            horas_laboradas[i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine("Pagos:");
        for (int i = 0; i < nombres.Length; i++)
        {
            double pago;
            if (horas_laboradas[i]<=40)
            {
                pago = horas_laboradas[i] * salario_x_hora[i];
            }
            else
            {
                double horasExtras = horas_laboradas[i] - 40;
                pago = (40 * salario_x_hora[i]) + (horasExtras * salario_x_hora[i] * 1.5);
            }
            Console.WriteLine("El trabajador "+nombres[i] + " salario: Q"+pago);
        }

    }
}