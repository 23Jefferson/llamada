using System;

class Program
{
    static void Main()
    {
        // Definición de la tabla de precios por zona
        int[] claves = { 12, 15, 18, 19, 23 };
        string[] zonas = { "América del norte", "América central", "América del sur", "Europa", "Asia" };
        double[] precios = { 2.0, 2.2, 4.5, 3.5, 6.0 };

        // Pedir la clave de zona al usuario
        Console.Write("Ingrese la clave de la zona (12, 15, 18, 19 o 23): ");
        if (!int.TryParse(Console.ReadLine(), out int claveZona) || Array.IndexOf(claves, claveZona) == -1)
        {
            Console.WriteLine("Clave de zona no válida. Por favor, ingrese una clave válida.");
            return;
        }

        // Pedir el número de minutos hablados al usuario
        Console.Write("Ingrese el número de minutos hablados: ");
        if (!double.TryParse(Console.ReadLine(), out double minutosHablados))
        {
            Console.WriteLine("Número de minutos no válido. Por favor, ingrese un número válido.");
            return;
        }

        // Encontrar el índice correspondiente a la clave de zona
        int indice = Array.IndexOf(claves, claveZona);

        // Calcular el costo de la llamada
        double costo = precios[indice] * minutosHablados;
        Console.WriteLine($"El costo de la llamada a {zonas[indice]} es: ${costo}");
    }
}