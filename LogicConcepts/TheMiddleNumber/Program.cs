using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.WriteLine("Ingrese 3 número diferentes");
    var a = ConsoleExtension.GetInt("Ingrese primer número: ");
    var b = ConsoleExtension.GetInt("Ingrese segundo número: ");
    if (a == b)
    {
        Console.WriteLine("Los números son iguales");
        continue;
    }
    var c = ConsoleExtension.GetInt("Ingrese tercer número: ");
    if (a ==c || b == c)
    {
        Console.WriteLine("Los números son iguales");
        continue;
    }

    if (a > b && b > c)
    {
        Console.WriteLine($"El número mayor es: {a}, el número del medio es: {b} y el número menor es {c}");
    }
    else if (a > c && c > b)
    {
        Console.WriteLine($"El número mayor es: {a}, el número del medio es: {c} y el número menor es {b}");
    }
    else if (b > a && a > b)
    {
        Console.WriteLine($"El número mayor es: {a}, el número del medio es: {b} y el número menor es {c}");
    }
    else if (b > c && c > a)
    {
        Console.WriteLine($"El número mayor es: {b}, el número del medio es: {c} y el número menor es {a}");
    }
    else if (c > a && a > b)
    {
        Console.WriteLine($"El número mayor es: {c}, el número del medio es: {a} y el número menor es {b}");
    }
    else if (c > b && b > a)
    {
        Console.WriteLine($"El número mayor es: {c}, el número del medio es: {b} y el número menor es {c}");
    }
    do
    {
        answer = ConsoleExtension.GetValidOptions("Deseas continuar? [s]i, [n]o: ", options);

    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));



} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

