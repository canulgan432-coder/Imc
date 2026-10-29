using Imc.Models;
using System.Globalization;

Console.WriteLine("Calculadora de Indice de Masa Corporal");
Console.WriteLine();


decimal peso = ReadDecimal("Proporcione el peso de la persona en kilogramos:");
decimal estatura = ReadDecimal("proporcione la estatura de la persona en metros:");



var imc = CalculadoraImc.IndicedeMasaCorporal(peso, estatura);
Console.WriteLine($"El indice de masa corporal de la persona es {imc:F4}");
var situacionNutricional = CalculadoraImc.SituacionNutriional(imc);
Console.WriteLine($"El estado de la situacion nutricional de persona es {situacionNutricional}");
return 0;

 static decimal ReadDecimal(string indicacion)
{
    decimal valor;
    bool valorEsValido = false;
    do
    {
        Console.Write($"{indicacion}");
        var entrada = Console.ReadLine();
         valorEsValido = decimal.TryParse(entrada, out valor);
        if (!valorEsValido)
        {
            Console.WriteLine("el dato proporcionado debe ser numerico.");
        }


    } while (!valorEsValido);
    return valor;
}