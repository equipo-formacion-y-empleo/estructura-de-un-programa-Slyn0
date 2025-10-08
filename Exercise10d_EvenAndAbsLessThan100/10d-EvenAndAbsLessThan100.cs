using System;

bool EvenAndAbsLessThan100(double number)
{
    return (number % 2 == 0) && (Math.Abs(number) < 100);
}

// Obtener argumentos de línea de comandos
double number = args.Length > 0 ? double.Parse(args[0]) : 50.0;

// Probar la función
bool result = EvenAndAbsLessThan100(number);

// Mostrar resultado
Console.WriteLine($"¿{number} es par y |valor| < 100? {result}");