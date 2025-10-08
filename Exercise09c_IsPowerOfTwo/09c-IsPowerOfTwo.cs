using System;

bool IsPowerOfTwo(int number)
{
    return (number > 0) && ((number & (number - 1)) == 0);
}

// Obtener argumentos de línea de comandos
int number = args.Length > 0 ? int.Parse(args[0]) : 8;

// Probar la función
bool result = IsPowerOfTwo(number);

// Mostrar resultado
Console.WriteLine($"¿Es {number} potencia de dos? {result}");