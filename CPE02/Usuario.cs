using System;

namespace GestionAtraccion
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public int TurnoAsignado { get; set; }

        public Usuario(string nombre, int turno)
        {
            Nombre = nombre;
            TurnoAsignado = turno;
        }

        public override string ToString()
        {
            return $"Turno {TurnoAsignado} - Usuario: {Nombre}";
        }
    }
}
