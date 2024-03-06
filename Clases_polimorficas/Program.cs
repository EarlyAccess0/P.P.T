using System;
using System.Runtime.InteropServices;


Random random = new Random();
Console.WriteLine("Escribe una opcion);");
Console.WriteLine("0. Piedra");
Console.WriteLine("1. Tijera");
Console.WriteLine("2. Papel");
string? input = Console.ReadLine();

string[] valoresElegir =  ["Piedra", "Tijera", "Papel"];

int randvalue=random.Next(0, 2);
int? opcion = int.Parse(input);

switch (opcion)
{
    case 0:
        Console.WriteLine("Has elegido Piedra");
        break;
    case 1:
        Console.WriteLine("Has elegido Tijera");
        break;
    case 2:
        Console.WriteLine("Has elegido Papel");
        break;
    default:
        Console.WriteLine("Opción inválida");
        break;

}

string v=valoresElegir[randvalue];

if  (v == opcion);


Console.WriteLine(valoresElegir[randvalue]);