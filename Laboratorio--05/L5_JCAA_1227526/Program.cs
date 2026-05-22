//Desafio #1
Console.WriteLine("Desafio #1");
//Entrada: Un numero entero.
//Salida:  Si es un numero positivo, negativo o cero. 

//Proceso:
Console.WriteLine("Ingrese un numero entero");
string num = Console.ReadLine();
int num1 = int.Parse(num);
if (num1>0)
{
    Console.WriteLine("El numero es positivo");
}
else if (num1<0)
{
    Console.WriteLine("El numero es negativo");
}
else
{
    Console.WriteLine("El numero es cero");
}

//Desafio #2
Console.WriteLine("Desafio #2");
//Entrada: El año en un numero entero.
//Salida:  Si es un año bisiesto o no.

//Proceso:
Console.WriteLine("Ingrese el año");
string anio  = Console.ReadLine();
int an = int.Parse(anio);
if (((an%4==0)&&(an%100!=0))||an%400==0)
{
    Console.WriteLine("Es bisiesto el año: " + an);
}
else
{
    Console.WriteLine("No es bisiesto el año: "+an);
}

//Desafio #3
Console.WriteLine("Desafio #3");
//Entrada: Ingreso mensual como double y multa como boolean
//Salida:  Cantidad que contribuirá al ornato de la ciudad

//Proceso:
Console.WriteLine("Ingrese su ingreso mensual");
string ingreso = Console.ReadLine();
double ing = double.Parse(ingreso);
Console.WriteLine("Tiene multa(true/false)");
string multa  = Console.ReadLine();
bool mul = bool.Parse(multa);
double monto = 0;

if (ing>=500.01 && ing<=1000)
{
    monto = monto + 10;
    if (mul)
    {
        monto = monto + 10;
    }
}
else if (ing >= 1000.01 && ing <= 3000)
{
    monto = monto + 15;
    if (mul)
    {
        monto = monto + 15;
    }
}
else if (ing >= 3000.01 && ing <= 6000)
{
    monto = monto + 50;
    if (mul)
    {
        monto = monto + 50;
    }
}
else if (ing >= 6000.01 && ing <= 9000)
{
    monto = monto + 75;
    if (mul)
    {
        monto = monto + 75;
    }
}
else if (ing >= 9000.01 && ing <= 12000)
{
    monto = monto + 100;
    if (mul)
    {
        monto = monto + 100;
    }
}
else if (ing >= 12000.01)
{
    monto = monto + 150;
    if (mul)
    {
        monto = monto + 150;
    }
}
else
{
    monto = 0;
}
Console.WriteLine("La cantidad que contribuira al ornato de la ciudad es: " + monto + "Q");

//Desafio #4
Console.WriteLine("Desafio #4");
//Entrada: Ingreso de cantidad de horas estacionado y el monto con el que se realiza el pago.
//Salida:  Si el monto es menor muestra error, Si el monto es exacto muestra que no se requiere cambio y si el monto es mayor al cobro se muestra la cantidad de vuelto en billetes.

//Proceso:

Console.WriteLine("Ingrese la cantidad de horas estacionado como numero redondo");
string horas = Console.ReadLine();
int hora = int.Parse(horas);
int monto_a = hora * 10;
Console.WriteLine("Ingrese el monto con el que va a pagar en quetzales");
string monto_d = Console.ReadLine();
int montod = int.Parse(monto_d);
if (montod<monto_a)
{
    Console.WriteLine("Error, los fondos no son suficientes");
}
else if (montod==monto_a)
{
    Console.WriteLine("No se requiere cambio, ¡Feliz día!");
}
else if (montod>monto_a)
{
    int vuelto = montod - monto_a;
    int b100 = vuelto / 100;
    int b50 = (vuelto % 100) / 50;
    int b20 = (vuelto % 100%50)/20;
    int b10 = (vuelto % 100 % 50%20) / 10;
    int b5 = (vuelto % 100 % 50 % 20 % 10) / 5;
    int b1 = (vuelto % 100 % 50 % 20 % 10 % 5) / 1;
    Console.WriteLine("Cambio: Q"+vuelto);
    Console.WriteLine("Billetes de Q100: "+b100);
    Console.WriteLine("Billetes de Q50: " + b50);
    Console.WriteLine("Billetes de Q20: " + b20);
    Console.WriteLine("Billetes de Q10: " + b10);
    Console.WriteLine("Billetes de Q5: " + b5);
    Console.WriteLine("Billetes de Q1: " + b1);
}
