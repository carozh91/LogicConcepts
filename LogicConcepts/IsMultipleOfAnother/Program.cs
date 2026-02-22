using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.WriteLine("Ingrese 2 números: ");
    var a = ConsoleExtension.GetInt("Ingrese primer número: ");
    if (a == 0)
    {
        Console.WriteLine("El número debe ser diferente de 0");
        continue;
    }
    var b = ConsoleExtension.GetInt("Ingrese segundo número: ");
    if (b % a == 0)
    {
        Console.WriteLine($"{b} es múltiplo de {a}");
    }
    else
    {
        Console.WriteLine($"{b} no es múltiplo de {a}");
    }
    
    do
    {
        answer = ConsoleExtension.GetValidOptions("Deseas continuar? [s]i, [n]o: ", options);

    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));



} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
