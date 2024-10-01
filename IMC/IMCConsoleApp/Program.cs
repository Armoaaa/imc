using System;
using IMCLibrary;

namespace IMCConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        IMCCalculator calculator = new IMCCalculator();

        Console.WriteLine("Ingrese su peso en kg:");
        string weightInput = Console.ReadLine();
        Console.WriteLine("Ingrese su altura en metros:");
        string heightInput = Console.ReadLine();

        if (!double.TryParse(weightInput, out double weight) || !double.TryParse(heightInput, out double height))
        {
            Console.WriteLine("El valor ingresado es incorrecto");
            return;
        }

        try
        {
            double imc = calculator.CalculateIMC(weight, height);
            string classification = calculator.GetClassification(imc);
            Console.WriteLine($"Su IMC es: {Math.Round(imc, 2)}");
            Console.WriteLine($"Clasificación: {classification}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
