float CalculateBMI(float weight, float height)
{
    return weight / (height * height);
}

float weight = float.Parse(args.Length > 0 ? args[0] : "70.0");
float height = float.Parse(args.Length > 1 ? args[1] : "1.75");

Console.WriteLine($"BMI: {CalculateBMI(weight, height)}");