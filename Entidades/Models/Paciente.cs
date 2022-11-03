using Entidades.ModelsBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente : Individuo

    {
        public Paciente()
        {
        }

        public Paciente(int id, string nombre, string apellido, string domicilio, string telefono, string email) : base(id, nombre, apellido, domicilio, telefono, email)
        {

        }

        public string NroHistoriaClinica { get; set; }  
        
    }
}
