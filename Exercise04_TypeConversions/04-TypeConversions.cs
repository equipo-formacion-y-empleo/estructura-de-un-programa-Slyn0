using System.Runtime;

double DemoImplicitConversions()
{
    double decimalNumber = 15.87; // Faltaba punto y coma

    int integerValue = (int)decimalNumber;

    Console.WriteLine($"Valor original (double): {decimalNumber}");
    Console.WriteLine($"Valor convertido (int): {integerValue}");

    int integerNumber = 42;

    double result = integerNumber + 0.5; // Había un carácter 'ç' erróneo

    Console.WriteLine($"Conversion implicita: {integerNumber} + 0.5 = {result}");
    
    return result;
}

int DemoExplicitConversions()
{
    decimal originalValue = decimal.Parse(args.Length > 0 ? args[0] : "23.89");
    int targetInt = int.Parse(args.Length > 1 ? args[1] : "17");
    
    Console.WriteLine($"Conversion explicita - originalValue: {originalValue}, targetInt: {targetInt}"); // Faltaba comilla doble al inicio de la cadena

    return targetInt;
}

Console.WriteLine($"Conversión explícita a int: {DemoExplicitConversions()}");
Console.WriteLine($"Conversión implícita a double: {DemoImplicitConversions()}");
