using System;
class Program
{
    static void Main()
    {
        //Ejercicio 1
        Console.WriteLine("Ejercicio 1");
        string nombre = "Goku";
        int nivel = 999;
        float puntos_de_vida = 999.99f;
        bool es_un_jefe = false;
        Console.WriteLine(nombre + " " + nivel + " " + puntos_de_vida + " " + es_un_jefe);
        Console.ReadLine();
        //Ejercicio 2
        Console.WriteLine("Ejercicio 2");
        int numeroEntero = 1500;
        long numeroLargo;
        numeroLargo = numeroEntero;
        Console.WriteLine(numeroLargo);
        Console.ReadLine();
        double numeroDecimal;
        numeroDecimal = numeroLargo;
        Console.WriteLine(numeroDecimal);
        //Ejercicio 3
        Console.WriteLine("Ejercicio 3");
        double precioExacto = 45.89;
        int precioRedondeado;
        precioRedondeado = (int)precioExacto;
        Console.WriteLine(precioExacto);
        Console.WriteLine(precioRedondeado);
        Console.WriteLine("Los decimales desaparecen y solo deja la parte entera");
        //Ejercicio 4
        Console.WriteLine("Ejercicio 4");
        //int numero;
        //Console.WriteLine("Ingresar un número: ");
        //numero = Console.ReadLine();
        //El codigo nos da error y esto es porque no se puede convertir un string a integer de forma implicita, sino que debe llevar un proceso.
        Console.WriteLine("Ingresar un número: ");
        string entradaUsuario = Console.ReadLine();
        int numero = int.Parse(entradaUsuario);
        numero = numero + 5;
        Console.WriteLine(numero);
        //Ejercicio 5
        Console.WriteLine("Ejercicio 5");
        string valorTexto = "true";
        bool valorBooleano = Convert.ToBoolean(valorTexto);
        Console.WriteLine(valorTexto);
        Console.WriteLine(valorBooleano);
        string valorDecimal = "25.5";
        double valorDouble = Convert.ToDouble(valorDecimal);
        Console.WriteLine(valorDecimal);
        Console.WriteLine(valorDouble);
        //Ejericio 6
        Console.WriteLine("Ejercicio 6");
        double pi = 3.14159265;
        string cadena = pi.ToString();
        Console.WriteLine(cadena);
        string cadena2decimales = pi.ToString("F2");
        Console.WriteLine(cadena2decimales);
        //Ejericio 7
        Console.WriteLine("Ejercicio 7");
        Console.WriteLine("Ingrese el precio del producto: ");
        string precio_producto = Console.ReadLine();
        double precio_pr = Convert.ToDouble(precio_producto);
        double iva = precio_pr * 0.21;
        double total = iva + precio_pr;
        int totalredondeado = (int)total;
        Console.WriteLine("El total a pagar es: "+totalredondeado);
    }
}