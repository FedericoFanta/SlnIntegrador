using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades.ModelsBase;

namespace Negocio
{
    public static class AdmPaciente
    {

        static List<Paciente> pacientes;

        public static List<Paciente> Listar()
        {
            pacientes = new List<Paciente>();
            pacientes.Add(new Paciente() { Id = 0, Nombre = "Jose", Apellido = "Benitez", Domicilio = "Mitre 2742", Telefono = "45642832", Email = "alvarobenitez@gmail.com", NroHistoriaClinica = "43242342" });
            pacientes.Add(new Paciente() { Id = 1, Nombre = "German", Apellido = "Edificios", Domicilio = "Chile 467", Telefono = "261735824", Email = "julioedificios@gmail.com", NroHistoriaClinica = "2343242" });
            pacientes.Add(new Paciente() { Id = 2, Nombre = "Jale", Apellido = "Bastian", Domicilio = "25 de mayo 27", Telefono = "351734789", Email = "jorgebastian@gmail.com", NroHistoriaClinica = "23423423" });
            pacientes.Add(new Paciente() { Id = 3, Nombre = "Fede", Apellido = "Gonzalez", Domicilio = "Perú 2328", Telefono = "2612453792", Email = "juliancapogonzalez214@gmail.com", NroHistoriaClinica = "3243242" });
            return pacientes;
        }

        public static int Insertar(Paciente paciente)
        {
            return 0;
        }

        public static  int Eliminar(int id)
        {
            return 0;
        }

        public static Paciente TraerUno(int nroHistoriaClinica)
        {
            return null;
        }

    }
}