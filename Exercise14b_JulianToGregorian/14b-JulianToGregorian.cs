using System;

void JulianToGregorian(double julianDay)
{
    int a = (int)julianDay + 32044;
    int b = (4 * a + 3) / 146097;
    int c = a - (146097 * b) / 4;
    int d = (4 * c + 3) / 1461;
    int e = c - (1461 * d) / 4;
    int m = (5 * e + 2) / 153;

    int day = e - (153 * m + 2) / 5 + 1;
    int month = m + 3 - 12 * (m / 10);
    int year = 100 * b + d - 4800 + m / 10;

    Console.WriteLine($"Fecha juliana: {julianDay:F0}");
    Console.WriteLine($"Fecha gregoriana: {day}/{month}/{year}");
    // TODO: Implementar conversión y mostrar resultados:
    // Console.WriteLine($"Fecha juliana: {julianDay:F0}");
    // Console.WriteLine($"Fecha gregoriana: {day}/{month}/{year}");
}

// Obtener argumentos de línea de comandos
double julianDay = args.Length > 0 ? double.Parse(args[0]) : 2451545;

// Convertir fecha juliana a gregoriana
JulianToGregorian(julianDay);