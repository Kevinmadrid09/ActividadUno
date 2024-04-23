using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculadora de Índice de Masa Corporal (IMC)");
        Console.WriteLine("Ingrese su peso en kilogramos:");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese su altura en metros:");
        double altura = Convert.ToDouble(Console.ReadLine());

        // Calculamos el IMC
        double imc = CalcularIMC(peso, altura);

        // Mostramos el resultado
        Console.WriteLine("Su Índice de Masa Corporal (IMC) es: " + imc.ToString("0.00"));

        // Interpretamos el resultado
        InterpretarIMC(imc);

        Console.ReadLine();
    }

    static double CalcularIMC(double peso, double altura)
    {
        // Fórmula del IMC: peso / (altura * altura)
        return peso / (altura * altura);
    }

    static void InterpretarIMC(double imc)
    {
        Console.WriteLine("Interpretación del IMC:");

        if (imc < 18.5)
        {
            Console.WriteLine("Bajo peso");
        }
        else if (imc >= 18.5 && imc < 25)
        {
            Console.WriteLine("Peso normal");
        }
        else if (imc >= 25 && imc < 30)
        {
            Console.WriteLine("Sobrepeso");
        }
        else if (imc >= 30 && imc < 35)
        {
            Console.WriteLine("Obesidad clase 1");
        }
        else if (imc >= 35 && imc < 40)
        {
            Console.WriteLine("Obesidad clase 2");
        }
        else
        {
            Console.WriteLine("Obesidad clase 3");
        }
    }
}
