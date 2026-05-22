using System.Linq.Expressions;
using System.Numerics;

Console.WriteLine("Ingrese su tipo de sangre");
string tipos  = Console.ReadLine();

switch (tipos)
{
    case "AB" :
        Console.WriteLine("Es compatible con O-, O+, B-, B+, A-, A+, AB-, AB+");
    break;
    case "AB-":
        Console.WriteLine("Es compatible con O-, B-, A-, AB-");
        break;
    case "A+":
        Console.WriteLine("Es compatible con O-, O+, A-, A+");
        break;
    case "A-":
        Console.WriteLine("Es compatible con O-, A-");
        break;
    case "B+":
        Console.WriteLine("Es compatible con O-, O+, B-, B+");
        break;
    case "B-":
        Console.WriteLine("Es compatible con O-, B-");
        break;
    case "O+":
        Console.WriteLine("Es compatible con O-, O+");
        break;
    case "O-":
        Console.WriteLine("Es compatible con O-");
        break;
    default: 
        Console.WriteLine("No puso ningun tipo de sangre o no lo puso en mayusculas");
        break;
}

//PROBLEMA 4

Console.WriteLine("Ingrese el tipo de cliente todo minusculas, solo el tipo sin la palabra cliente");
string tipo = Console.ReadLine();
Console.WriteLine("Ingrese la cantidad de unidades");
int cant = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el monto de la compra");
double monto = double.Parse(Console.ReadLine());
if ((cant > 100) || (tipo == "mayorista"))
{
    double total = monto - (monto * 15 / 100);
    Console.WriteLine("El resultado del monto es: " + total);
} else if (tipo == "vip")
{
    double total = monto - (monto * 10 / 100);
    Console.WriteLine("El resultado del monto es: " + total);
}
else if (tipo == "regular")
{
    double total = monto - (monto * 5 / 100);
    Console.WriteLine("El resultado del monto es: " + total);
}
else
{
    double total = monto;
    Console.WriteLine("El resultado del monto es: " + total);
}

