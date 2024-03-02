using System;

class Program
{
    static void Main(string[] args)
    {
        // Pedir nombre del usuario
        Console.WriteLine("Ingrese su nombre:");
        string nombre = Console.ReadLine();

        // Pedir ingresos de los últimos 3 meses
        Console.WriteLine("Ingrese los ingresos del mes 1:");
        double ingresosMes1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese los ingresos del mes 2:");
        double ingresosMes2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese los ingresos del mes 3:");
        double ingresosMes3 = double.Parse(Console.ReadLine());

        // Calcular la suma de los ingresos
        double sumaIngresos = ingresosMes1 + ingresosMes2 + ingresosMes3;

        // Calcular el promedio de los ingresos
        double promedioIngresos = sumaIngresos / 3;

        // Mostrar mensaje con los resultados
        Console.WriteLine($"Hola {nombre}, en total ganaste {sumaIngresos} y promediaste {promedioIngresos}.");
    }
}
