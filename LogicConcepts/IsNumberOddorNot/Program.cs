
using Shared;

var numberString = string.Empty;
do
{
    var number = ConsoleExtension.GetInt("Ingresa un número entero: ");
    if(number == 0)
    {
        continue;
    }
    if (number % 2 == 0)
        {
            Console.WriteLine($"El número {number} es par");
        }
    else
        {
            Console.WriteLine($"El número {number} es impar");
        }
    

   
}while (true);
