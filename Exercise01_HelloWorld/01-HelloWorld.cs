const string GREETINGS = "Hello";

string ShowMessage(string name)
{
    return $"{GREETINGS}, {name}!";
}

Console.WriteLine("Hello World!");

Console.WriteLine(ShowMessage(args.Length > 0 ? args[0] : "Ana"));
Console.WriteLine(ShowMessage(args.Length > 1 ? args[1] : "Luis"));