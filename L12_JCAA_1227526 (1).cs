using System;
using System.Diagnostics.CodeAnalysis;
class Program
{
    static void Main()
    {
        //Problema 1
        int[,] matriz = new int[5, 5];
        llenar(ref matriz);
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j]+" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("La suma de la diagonal principal es: "+ sumard(matriz));
        Console.WriteLine("La suma de la diagonal secundaria es: " + sumards(matriz));
        Console.WriteLine() ;
        //Problema 2
        int[,] matriz2 = new int[4, 6];
        llenar(ref matriz2);
        for (int i = 0; i < matriz2.GetLength(0); i++)
        {
            for (int j = 0; j < matriz2.GetLength(1); j++)
            {
                Console.Write(matriz2[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("La cantidad de pares: " + pares(matriz2));
        Console.WriteLine("La cantidad de impares: " + impares(matriz2));
        //Problema 3
        int[,] matriz3 = new int[5, 4];
        Console.WriteLine();
        ingresar_notas(ref matriz3);
        for (int i = 0; i < matriz3.GetLength(0); i++)
        {
            for (int j = 0; j < matriz3.GetLength(1); j++)
            {
                Console.Write(matriz3[i, j] + " ");
            }
            double promedio = prom(matriz3, i);
            Console.WriteLine(" = promedio del estudiantes: "+ promedio + " El estudiante esta: "+ aprobado(promedio));
        }
        //Problema 4
        Console.WriteLine() ;
        int[,] matriz4 = new int[3, 3];
        llenar(ref matriz4);
        for (int i = 0; i < matriz4.GetLength(0); i++)
        {
            for (int j = 0; j < matriz4.GetLength(1); j++)
            {
                Console.Write(matriz4[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("La matriz es: "+simetria(matriz4)) ;
    }
    static void llenar(ref int[,] matriz)
    {
        Random rnd = new Random();
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = rnd.Next(1, 101);
            }
        }
    }
    static int sumard(int[,]matriz) {
      int sum = 0;
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            sum += matriz[j, j];
        }

        return sum;
    }
    static int sumards(int[,] matriz)
    {
        int sum = 0;
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            sum+=matriz[j, matriz.GetLength(1)-1-j];
        }

        return sum;
    }
    static int pares(int[,] matriz)
    {
        int cantidad = 0;
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i,j]%2==0)
                {
                    cantidad++;
                }
            }
        }

        return cantidad;
    }
    static int impares(int[,] matriz)
    {
        int cantidad = 0;
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] % 2 != 0)
                {
                    cantidad++;
                }
            }
        }

        return cantidad;
    }
    static void ingresar_notas(ref int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.WriteLine("Ingrese la nota del estudiante: "+(i+1) + " Nota no."+(j+1));
                matriz[i, j] = int.Parse(Console.ReadLine());

            }
        }
    }

    static double prom(int[,] matriz, int estudiante)
    {
        double cantidad = 0;
        for (int i = 0; i < matriz.GetLength(1); i++)
        {
            cantidad += matriz[estudiante, i];
        }

        return cantidad / matriz.GetLength(1);
    }
    static string aprobado(double promedio)
    {
        if (promedio>=61)
        {
            return "Aprobado";
        }
        else
        {
            return "Reprobado";
        }

    }
    static string simetria(int[,] matriz)
    {
        bool valor = true;
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            if (matriz[i, 0] != matriz[i, matriz.GetLength(1)-1])
            {
                valor = false;
            }
        }
        if (valor)
        {
            return "Simetrica"; 
        }
        else
        {
            return "No simetrica";
        }
    }

}