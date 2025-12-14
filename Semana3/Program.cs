using System;

// Clase Estudiante con sus atributos
class Estudiante
{
    public int Id;
    public string Nombres;
    public string Apellidos;
    public string Direccion;
    public string[] Telefonos = new string[3]; // Array de 3 teléfonos

    // Método para mostrar todos los datos del estudiante
    public void MostrarDatos()
    {
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Nombres: " + Nombres);
        Console.WriteLine("Apellidos: " + Apellidos);
        Console.WriteLine("Dirección: " + Direccion);
        Console.WriteLine("Teléfonos:");
        foreach (string telefono in Telefonos)
        {
            Console.WriteLine("- " + telefono);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear un objeto de tipo Estudiante
        Estudiante estudiante = new Estudiante();

        // Asignar valores a sus atributos
        estudiante.Id = 1;
        estudiante.Nombres = "Diana Estefania ";
        estudiante.Apellidos = "Ramon Ramon";
        estudiante.Direccion = "Av. Nueve de Octubre";

        // Asignar valores al array de teléfonos
        estudiante.Telefonos[0] = "0982932348";
        estudiante.Telefonos[1] = "0987344321";
        estudiante.Telefonos[2] = "0977722334";

        // Llamar al método para mostrar los datos
        estudiante.MostrarDatos();
    }
}