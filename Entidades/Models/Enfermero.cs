using Entidades.ModelsBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Enfermero : Individuo
    {
        public Enfermero(int id, string nombre, string apellido, string domicilio, string telefono, string email,int cuil) : base(id, nombre, apellido, domicilio, telefono, email)
        {
            CUIL= cuil;
        }

        public int CUIL { get; set; }
    }
}
