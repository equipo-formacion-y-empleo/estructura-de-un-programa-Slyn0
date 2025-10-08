using System;

bool IsEvenBits(int number)
{
  return (number & 1) == 0;
}

// Obtener argumentos de línea de comandos
int number = args.Length > 0 ? int.Parse(args[0]) : 8;

// Probar la función
bool result = IsEvenBits(number);

// Mostrar resultado
Console.WriteLine($"¿Es {number} par usando bits? {result}");