float CalculateHypotenuse(float side1, float side2)
{
    return (float)Math.Sqrt(side1 * side1 + side2 * side2);
}

float side1 = float.Parse(args.Length > 0 ? args[0] : "3,0");
float side2 = float.Parse(args.Length > 1 ? args[1] : "4,0");

Console.WriteLine($"Hypotenuse: {CalculateHypotenuse(side1, side2)}");