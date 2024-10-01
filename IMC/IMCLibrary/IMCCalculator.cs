using System;

namespace IMCLibrary;

public class IMCCalculator
{
    public double CalculateIMC(double weight, double height)
    {
        if (height <= 0 || weight <= 0)
            throw new ArgumentException("El peso y la altura deben ser positivos.");

        return weight / (height * height);
    }

    public string GetClassification(double imc)
    {
        if (imc < 18.5)
            return "Bajo peso";
        else if (imc < 24.9)
            return "Peso normal";
        else if (imc < 29.9)
            return "Sobrepeso";
        else
            return "Obesidad";
    }
}
