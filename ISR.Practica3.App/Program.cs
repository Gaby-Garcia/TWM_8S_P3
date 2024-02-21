using System;
using ISR.Practica3.Core.Entities;
using ISR.Practica3.Core.Managers;
using ISR.Practica3.Core.Services;

namespace ISR.Practica3.App;

public static class Program{
    public static void Main(String[] args ){

        decimal salary = 0;

        System.Console.Write("Ingresa tu salario bruto: ");
        Decimal.TryParse(System.Console.ReadLine(), out salary);

        //Instancia a clase Persona y Newton-weight
        var income = new Income{Salary = salary};
        var service = new IsrService();
        var managers = new IsrManager(service);

        Isr isr = managers.GetIsr(income);

        System.Console.WriteLine($"Tu ISR es: {isr.Index}");
    }
}
