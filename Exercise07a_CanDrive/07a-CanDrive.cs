bool CanDrive(int age, bool hasLicense)
{
    return IsAdult(age) && hasLicense;
}

bool IsAdult(int age)
{
    return age >= 18;
}

int age = int.Parse(args.Length > 0 ? args[0] : "20");
bool hasLicense = bool.Parse(args.Length > 1 ? args[1] : "true");

Console.WriteLine($"¿Puede conducir ({age}, {hasLicense})? {CanDrive(age, hasLicense)}");