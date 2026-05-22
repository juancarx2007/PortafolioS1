using System;
class Program
{
    static void Main()
    {
        //Problema 1
        Console.WriteLine("Problema 1");
        Console.WriteLine("Ingrese el string para saber su cantidad de caracteres.");
        string entrada = Console.ReadLine();
        cantidad(entrada);
        //Problema 2
        Console.WriteLine("Problema 2");
        Console.WriteLine("Ingrese la primera variable entera");
        int variable1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la segunda variable entera");
        int variable2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Valor de la primera variable: " + variable1);
        Console.WriteLine("Valor de la segunda variable: " + variable2);
        cambio(ref variable1, ref variable2);
        Console.WriteLine("Valor de la primera variable: " + variable1);
        Console.WriteLine("Valor de la segunda variable: " + variable2);
        //Problema 3
        Console.WriteLine("Problema 3");
        Console.WriteLine("Ingrese el precio del boleto");
        float precio = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el porcentade de descuento(ejemplo: 15% ingrese 0.15)");
        float descuento = float.Parse(Console.ReadLine());
        Console.WriteLine("Precio boleto antes del descuento: "+precio);
        descuentofun(ref precio, descuento);
        Console.WriteLine("Precio boleto despues del descuento: " + precio);
        //Problema 4
        Console.WriteLine("Problema 4");
        int puntosSalud = 15;
        mostrarSalud(puntosSalud);
        recibirDaño(ref puntosSalud);
        mostrarSalud(puntosSalud);
        recibirDaño(ref puntosSalud);
        mostrarSalud(puntosSalud);
        curar(ref puntosSalud);
        mostrarSalud(puntosSalud);
        calificarDesempeño(puntosSalud);

    }

    static void cantidad(string cadena)
    {
        Console.WriteLine("La cantidad de caracteres es: " + cadena.Length);
    }

    static void cambio(ref int v1, ref int v2){
        int temporal = v1;
        v1 = v2;
        v2 = temporal;
    }
    static void descuentofun(ref float pre,float des)
    {
        pre = pre - (pre * des);
    }

    static void mostrarSalud(int puntosSalud)
    {
        if (puntosSalud <= 15 && puntosSalud >= 11)
        {
            Console.ForegroundColor = ConsoleColor.Green;
           
        } else if (puntosSalud <= 10 && puntosSalud >= 6)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }else if (puntosSalud <= 5 && puntosSalud >= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        Console.WriteLine("La salud del jugador es: "+puntosSalud);
        Console.ResetColor();
    }
    static void recibirDaño(ref int puntosSalud)
    {
        if (puntosSalud<=0)
        {
            puntosSalud = 0; // Como no puede ser menor a 0, entonces le asignamos 0, porque asi no baja mas
        } else
        {
            puntosSalud -= 5;
        }
    }
   static void curar(ref int puntosSalud) {
        if (puntosSalud >= 15)
        {
            puntosSalud = 15; // Como no puede ser mayor a 15, entonces le asignamos 15, porque asi no sube mas
        }
        else
        {
            puntosSalud += 5;
        }
    }
    static void calificarDesempeño(int puntosSalud)
    {
        if (puntosSalud == 15)
        {
            Console.WriteLine("Calificación S");
        }
        else if (puntosSalud <= 14 && puntosSalud >= 11)
        {
            Console.WriteLine("Calificación A");
        }
        else if (puntosSalud <= 10 && puntosSalud >= 6)
        {
            Console.WriteLine("Calificación B");
        }
        else if (puntosSalud <= 5 && puntosSalud >= 0)
        {
            Console.WriteLine("Calificación C");
        }
    }
}