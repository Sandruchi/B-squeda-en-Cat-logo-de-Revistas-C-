using System;
using System.Collections.Generic;

class CatalogoRevistas
{
    static List<string> revistas = new List<string>()
    {
        "Ciencia Hoy",
        "Mundo Natural",
        "Tecnología Viva",
        "Historia Global",
        "Salud y Vida",
        "Revista Eco",
        "Cultura Latina",
        "Espacio y Tiempo",
        "Educación XXI",
        "Sociedad Abierta"
    };

    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n========= MENÚ =========");
            Console.WriteLine("1. Buscar título de revista");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    BuscarRevista();
                    break;
                case 0:
                    Console.WriteLine("Saliendo del catálogo...");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        } while (opcion != 0);
    }

    static void BuscarRevista()
    {
        Console.Write("\nIngrese el título a buscar: ");
        string titulo = Console.ReadLine();
        bool encontrado = false;

        // Búsqueda iterativa
        foreach (string revista in revistas)
        {
            if (revista.Equals(titulo, StringComparison.OrdinalIgnoreCase))
            {
                encontrado = true;
                break;
            }
        }

        if (encontrado)
            Console.WriteLine("Resultado: Encontrado");
        else
            Console.WriteLine("Resultado: No encontrado");
    }
}
