using IMCLibrary;
using System;
using Xunit;

namespace IMCLibrary.Tests;

public class IMCCalculatorTests
{
    private readonly IMCCalculator _calculator = new IMCCalculator();

    [Fact]
    public void CalculateIMC_ValidInput_ReturnsCorrectIMC()
    {
        double weight = 70;
        double height = 1.75;
        double expectedIMC = 22.86;

        double result = _calculator.CalculateIMC(weight, height);

        Assert.Equal(expectedIMC, Math.Round(result, 2));
    }

    [Theory]
    [InlineData(0, 1.75)]
    [InlineData(70, 0)]
    public void CalculateIMC_NonPositiveValues_ThrowsArgumentException(double weight, double height)
    {
        Assert.Throws<ArgumentException>(() => _calculator.CalculateIMC(weight, height));
    }

    [Theory]
    [InlineData(18.4, "Bajo peso")]
    [InlineData(22.0, "Peso normal")]
    [InlineData(25.0, "Sobrepeso")]
    [InlineData(30.0, "Obesidad")]
    public void GetClassification_ValidIMC_ReturnsCorrectClassification(double imc, string expectedClassification)
    {
        string result = _calculator.GetClassification(imc);
        Assert.Equal(expectedClassification, result);
    }
}
