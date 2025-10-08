double ConvertTemperatures(double celsius)
{
    return (celsius * 9.0 / 5.0) + 32;
}

double celsius = double.Parse(args.Length > 0 ? args[0] : "25");

Console.WriteLine($"{ConvertTemperatures(celsius):F2}°F");