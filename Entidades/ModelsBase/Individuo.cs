﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ModelsBase
{
    public abstract class Individuo
    {
        public Individuo() { }
        public Individuo(int id, string nombre, string apellido, string domicilio, string telefono, string email )
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Domicilio = domicilio;
            Email = email;

        }
        public int Id { get; set; }

        public string Nombre { get; set; } 
        
        public string Apellido { get; set; }    

        public string Domicilio { get; set; }   

        public string Telefono { get; set; }   

        public string Email { get; set; }   
        


    }
}
