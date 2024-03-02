using System;

class Calculadora
{
    public int Sumar(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Restar(int num1, int num2)
    {
        return num1 - num2;
    }

    public int Multiplicar(int num1, int num2)
    {
        return num1 * num2;
    }

    public int Dividir(int num1, int num2)
    {
        if (num2 == 0)
        {
            throw new ArgumentException("No se puede dividir entre cero.");
        }
        return num1 / num2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculadora calculadora = new Calculadora();

        // Pedir dos números al usuario
        Console.WriteLine("Ingrese el primer número:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        int num2 = int.Parse(Console.ReadLine());

        // Realizar las operaciones y mostrar los resultados
        Console.WriteLine($"Suma: {calculadora.Sumar(num1, num2)}");
        Console.WriteLine($"Resta: {calculadora.Restar(num1, num2)}");
        Console.WriteLine($"Multiplicación: {calculadora.Multiplicar(num1, num2)}");
        try
        {
            Console.WriteLine($"División: {calculadora.Dividir(num1, num2)}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
