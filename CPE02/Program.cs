using System;

namespace GestionAtraccion
{
    class Inicio
    {
        static void Main(string[] args)
        {
            ControlAtraccion control = new ControlAtraccion(30);
            string opcion;

            do
            {
                Console.WriteLine("\n=== ATRACCIÓN DEL PARQUE ===");
                Console.WriteLine("1. Agregar usuario a la fila");
                Console.WriteLine("2. Ver usuarios con asiento");
                Console.WriteLine("3. Ver estado de asientos");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el nombre del usuario: ");
                        string nombre = Console.ReadLine();
                        control.AgregarUsuario(nombre);
                        break;

                    case "2":
                        control.MostrarUsuarios();
                        break;

                    case "3":
                        control.MostrarEstado();
                        break;

                    case "4":
                        Console.WriteLine("Cerrando aplicación...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

            } while (opcion != "4");
        }
    }
}
