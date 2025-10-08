void DemoBasicDataTypes()
{
    int age = 25;
    double price = 19.99;
    char initial = 'A';
    bool available = true;

    Console.WriteLine($"age: {age}");
    Console.WriteLine($"price: {price}");
    Console.WriteLine($"initial: {initial}");
    Console.WriteLine($"available: {available}");
}

void ShowDataTypeSizes()
{
    Console.WriteLine($"int: {sizeof(int)} bytes");
    Console.WriteLine($"double: {sizeof(double)} bytes");
    Console.WriteLine($"char: {sizeof(char)} bytes");
    Console.WriteLine($"bool: {sizeof(bool)} bytes");
}

DemoBasicDataTypes();
ShowDataTypeSizes();
