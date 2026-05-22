using System;
class Program
{
    static void Main()
    {
        //Problema 1
        Console.WriteLine("Problema 1");
        string nombre = "Juan Carlos Alarcon Amado";
        int carnet = 1227526;
        int indice = 1;
        Console.WriteLine("Nombre: "+ nombre + " Carnet: " + carnet.ToString());
        while (indice <= 20)
        {
            if (indice%2==0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.WriteLine(indice);
            indice = indice + 1;
        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.ReadLine();

        //Problema 2
        Console.WriteLine("Problema 2");
        Console.WriteLine("Ingrese un numero entero positivo");
        int enterop = int.Parse(Console.ReadLine());
        string acu = "Los divisores son: ";
        int i = enterop;
        do 
        {
            if (enterop%i==0)
            {
              acu = acu + i.ToString() + ", ";  
            }
            i = i - 1;
        } while (i > 0);
        Console.WriteLine(acu);

        //Problema 3
        Console.WriteLine("Problema 3");
        Console.WriteLine("Ingrese el numero entero para la serie de fibonnacci.");
        int ns = int.Parse(Console.ReadLine()) ;
        int pos1 = 0;
        int pos2 = 1;
        int acuf = 0;
        string serie = "0, 1";
        for (int j = 0; j < ns-2 ; j++) // se le resta 2, porque ya tenemos afuera pos1 y pos2 iniciales
        {
            acuf = pos1 + pos2;
            pos1 = pos2;
            pos2 = acuf;
            serie = serie + ", "+ acuf.ToString();
        }
        Console.WriteLine("La serie es: " + serie);
        Console.ReadLine();
        //Problema 4
        Console.WriteLine("Problema 4");
        for (int j = 1; j <= 12; j++)
        {
            for (int k = 1; k <= 10; k++)
            {
                Console.WriteLine("Tabla del "+j.ToString());
                Console.WriteLine(j.ToString() + " x " + k.ToString() + " = " + (j*k).ToString());
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    } 
}
