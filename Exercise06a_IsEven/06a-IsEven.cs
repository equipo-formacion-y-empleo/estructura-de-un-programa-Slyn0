bool IsEven(int number)
{
    return number % 2 == 0;
}

int number = int.Parse(args.Length > 0 ? args[0] : "4");

Console.WriteLine($"¿Es {number} un número par? {IsEven(number)}");
