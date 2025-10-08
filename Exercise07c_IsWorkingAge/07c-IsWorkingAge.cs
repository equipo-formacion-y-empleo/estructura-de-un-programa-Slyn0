bool IsWorkingAge(int age)
{
    return age >= 16 && age <= 65;
}

int age = int.Parse(args.Length > 0 ? args[0] : "30");

// Mostrar resultado
Console.WriteLine($"¿Con {age} años se puede trabajar? {IsWorkingAge(age)}");