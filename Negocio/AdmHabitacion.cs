using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades.ModelsBase;

namespace Negocio
{
    public static class AdmHabitacion
    {

       static List<Habitacion> habitaciones;

        public static List<Habitacion> Listar()
        {
            habitaciones = new List<Habitacion>();
            habitaciones.Add(new Habitacion() { Id = 0, Numero = 321, Estado = "VACIA" });
            habitaciones.Add(new Habitacion() { Id = 1, Numero = 211, Estado = "LLENA" });
            habitaciones.Add(new Habitacion() { Id = 2, Numero = 116, Estado = "DISPONIBLE" });
            habitaciones.Add(new Habitacion() { Id = 3, Numero = 110, Estado = "OFF" });
            return habitaciones;
        }

        public static List<Habitacion> Listar(string estado)
        {
            return null;
        }

        public static int Insertar(Habitacion habitacion)
        {
            return 0;
        }

        public static int Eliminar(int id)
        {
            return 0;
        }

        public static Habitacion TraerUno(int numero)
        {
            return null;
        }

    }
}