using ISR.Practica3.Core.Entities;
using ISR.Practica3.Core.Services;

namespace ISR.Practica3.Tests;

public class IncomeShould
{
    //identificar unit space, secciona muchas pruebas en una clase
    [Fact]
    public void ProcessIsr_CalculatesISRForGivenIncome()
    {
        // Arrange
        var isrService = new IsrService();
        var income = new Income { Salary = 13500m }; // Cambia el salario según sea necesario
        decimal expectedIsr = 517.46936m; // Cambia el valor esperado según corresponda al salario

        // Act
        Isr isr = isrService.ProcessIsr(income);

        // Assert
        Assert.Equal(expectedIsr, isr.Index);
    }
}