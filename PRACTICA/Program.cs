class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, HashSet<string>> equiposTorneo =
            new Dictionary<string, HashSet<string>>(StringComparer.OrdinalIgnoreCase);

        int opcionMenu;

        do
        {
            Console.WriteLine("\n===== TORNEO DE FUTBOL =====");
            Console.WriteLine("1. Registrar equipo");
            Console.WriteLine("2. Agregar jugador a un equipo");
            Console.WriteLine("3. Mostrar equipos y jugadores");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcionMenu))
            {
                Console.WriteLine("Debe ingresar un número válido.");
                continue;
            }

            switch (opcionMenu)
            {
                case 1:
                    RegistrarEquipo(equiposTorneo);
                    break;

                case 2:
                    AgregarJugador(equiposTorneo);
                    break;

                case 3:
                    MostrarEquipos(equiposTorneo);
                    break;

                case 0:
                    Console.WriteLine("Programa finalizado.");
                    break;

                default:
                    Console.WriteLine("Opción incorrecta.");
                    break;
            }

        } while (opcionMenu != 0);
    }

    static void RegistrarEquipo(Dictionary<string, HashSet<string>> equipos)
    {
        Console.Write("Ingrese el nombre del equipo: ");
        string nombre = (Console.ReadLine() ?? "").Trim();

        if (string.IsNullOrWhiteSpace(nombre))
        {
            Console.WriteLine("El nombre del equipo no puede estar vacío.");
            return;
        }

        if (!equipos.ContainsKey(nombre))
        {
            equipos[nombre] = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            Console.WriteLine("Equipo registrado correctamente.");
        }
        else
        {
            Console.WriteLine("El equipo ya se encuentra registrado.");
        }
    }

    static void AgregarJugador(Dictionary<string, HashSet<string>> equipos)
    {
        Console.Write("Ingrese el nombre del equipo: ");
        string equipo = (Console.ReadLine() ?? "").Trim();

        if (!equipos.ContainsKey(equipo))
        {
            Console.WriteLine("El equipo no existe.");
            return;
        }

        Console.Write("Ingrese el nombre del jugador: ");
        string jugador = (Console.ReadLine() ?? "").Trim();

        if (string.IsNullOrWhiteSpace(jugador))
        {
            Console.WriteLine("El nombre del jugador no puede estar vacío.");
            return;
        }

        if (equipos[equipo].Add(jugador))
        {
            Console.WriteLine("Jugador agregado correctamente.");
        }
        else
        {
            Console.WriteLine("Ese jugador ya pertenece al equipo.");
        }
    }

    static void MostrarEquipos(Dictionary<string, HashSet<string>> equipos)
    {
        Console.WriteLine("\n===== LISTA DE EQUIPOS =====");

        if (equipos.Count == 0)
        {
            Console.WriteLine("No hay equipos registrados.");
            return;
        }

        foreach (var item in equipos)
        {
            Console.WriteLine("\nEquipo: " + item.Key);

            if (item.Value.Count == 0)
            {
                Console.WriteLine("  No tiene jugadores registrados.");
            }
            else
            {
                foreach (var jugador in item.Value)
                {
                    Console.WriteLine("  - " + jugador);
                }
            }
        }
    }
}