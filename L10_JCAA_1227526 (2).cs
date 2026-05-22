using System;
class Program
{
    static void Main()
    {
        //Problema 1
        Console.WriteLine("Ingrese un numero:");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("La suma de los digitos es: " + sumadigitos(num));

        //Problema 2
        Console.WriteLine("Ingrese su primer nombre: ");
        string nom1 = Console.ReadLine();
        Console.WriteLine("Ingrese su segundo nombre: ");
        string nom2 = Console.ReadLine();
        Console.WriteLine("Ingrese su primer apellido: ");
        string ape1 = Console.ReadLine();
        Console.WriteLine("Ingrese su segundo apellido: ");
        string ape2 = Console.ReadLine();
        Console.WriteLine("El correo es: " + correo(nom1, nom2, ape1, ape2));

        //Problema 3
        double fahrenheit = 0;
        Console.WriteLine("Ingrese el valor de grados celsius (ej: C = 25)");
        string celcius = Console.ReadLine();
        Console.WriteLine(conversion(celcius, ref fahrenheit));
        Console.WriteLine("Valor guardado: "+ fahrenheit);

        //Problema 4
        Console.WriteLine("Pruebas funcionalidad:");
        int puntos = 0;
        quitarPuntos(ref puntos);
        Console.WriteLine(puntos);
        Console.WriteLine(obtenerNivel(puntos));
        agregarPuntos(ref puntos);
        Console.WriteLine(puntos);
        Console.WriteLine(evaluarEstado(puntos));
        agregarPuntos(ref puntos);
        Console.WriteLine(puntos);
        agregarPuntos(ref puntos);
        Console.WriteLine(puntos);
        agregarPuntos(ref puntos);
        Console.WriteLine(puntos);
        agregarPuntos(ref puntos);
        Console.WriteLine(puntos);
        agregarPuntos(ref puntos);
        Console.WriteLine(puntos);
        agregarPuntos(ref puntos);
        Console.WriteLine(puntos);
        Console.WriteLine(obtenerNivel(puntos));
        Console.WriteLine(evaluarEstado(puntos));
        agregarPuntos(ref puntos);
        Console.WriteLine(puntos);
        agregarPuntos(ref puntos);
        Console.WriteLine(puntos);
        agregarPuntos(ref puntos);
        Console.WriteLine(puntos);
        agregarPuntos(ref puntos);
        Console.WriteLine(puntos);
        Console.WriteLine(obtenerNivel(puntos));
        Console.WriteLine(evaluarEstado(puntos));
        quitarPuntos(ref puntos);
        Console.WriteLine(puntos);

    }

    //Funcion 1
    static int sumadigitos(int num)
    {
        int suma = 0;
        while (num>0){
            suma = suma + num % 10;
            num = num / 10;
       
        }
        return suma;
    }
    //Funcion 2
    static string correo(string n1, string n2, string ap1, string ap2)
    {
        string correo;
        correo = n1.Substring(0,1).ToLower() + n2.Substring(0,1).ToLower() + ap1.ToLower() + ap2.Substring(0,1).ToLower() + "@correo.url.edu.gt";
        return correo;
    }

    //Funcion 3
    static string conversion(string cel, ref double fah)
    {
        fah = (double.Parse(cel.Substring(4))*9/5)+32;
        string resultado = "F = " + fah;
        return resultado;
    }
    //Funciones problema 4
    static int agregarPuntos(ref int puntos)
    {
        if (puntos<100)
        {
            puntos += 10;
        }
        return puntos;

    }
    static int quitarPuntos(ref int puntos)
    {
        if (puntos > 0)
        {
            puntos -= 7;
        }
        return puntos;

    }
    static string obtenerNivel(int puntos)
    {
        string nivel = "";
        if (puntos <= 100 && puntos>=80)
        {
            nivel = "Avanzado";
        } else if (puntos <= 79 && puntos >= 50)
        {
            nivel = "Intermedio";
        }else if (puntos <= 49 && puntos >= 0)
        {
            nivel = "Básico";
        }
        return nivel;

    }
    static string evaluarEstado(int puntos)
    {
        string estado = "";
        if (puntos == 100)
        {
            estado = "Excelente";
        }
        else if (puntos <= 99 && puntos >= 70)
        {
            estado = "Aprobado";
        }
        else if (puntos <= 69 && puntos >= 1)
        {
            estado = "Reprobado";
        }
        return estado;

    }
}