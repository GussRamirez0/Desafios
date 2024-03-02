using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int suma = SumarDosValores();
            Console.WriteLine($"La suma de los dos valores es: {suma}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("El programa ha finalizado.");
        }
    }

    static int SumarDosValores()
    {
        Console.WriteLine("Ingrese el primer valor:");
        string input1 = Console.ReadLine();
        Console.WriteLine("Ingrese el segundo valor:");
        string input2 = Console.ReadLine();

        int valor1, valor2;
        try
        {
            valor1 = int.Parse(input1);
            valor2 = int.Parse(input2);
        }
        catch (FormatException)
        {
            throw new Exception("Error: Uno de los valores ingresados no es un número válido.");
        }
        catch (ArgumentNullException)
        {
            throw new Exception("Error: Uno de los valores ingresados está en blanco.");
        }

        return valor1 + valor2;
    }
}
