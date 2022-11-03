using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades.ModelsBase;

namespace Negocio
{
    public class AdmMedico
    {

        List<Medico> medicos;

        public List<Medico> Listar()
        {
            medicos = new List<Medico>();
            medicos.Add(new Medico() { Id=0, Nombre = "Dereck", Apellido = "Shepherd", Domicilio = "calle asd 123", Telefono = "32432432", Email = "algo@hotmail.com", Especialidad = "Cirujano", Matricula = "C423" });
            medicos.Add(new Medico() { Id = 1, Nombre = "Meredith", Apellido = "Grey", Domicilio = "calle 32 ", Telefono = "435435", Email = "algo@hotmail.com", Especialidad = "Clinico", Matricula = "F534" });
            medicos.Add(new Medico() { Id = 2, Nombre = "Izzie", Apellido = "Stevens", Domicilio = "calle siempreviva", Telefono = "767777", Email = "algo@hotmail.com", Especialidad = "Clinico", Matricula = "FG213" });
            medicos.Add(new Medico() { Id = 3, Nombre = "Miranda", Apellido = "Bailey", Domicilio = "calle lunar", Telefono = "34534543", Email = "lalgo@hotmail.com", Especialidad = "Jefe cardiologo", Matricula = "S2456" });
            return medicos;
        }

        public List<Medico> Listar(string especialidad)
        {
            
            List<Medico> tempMedicos = new List<Medico> { };
            foreach (Medico medico in medicos)
            {
                if (medico.Especialidad == especialidad)
                {
                    tempMedicos.Add(medico);
                }
            }
            return tempMedicos;
            
            
            //return medicos.FindAll(m => m.Especialidad.Equals( especialidad));
        }

        public int Insertar(Medico medico)
        {
            return 0;
        }

        public int Eliminar(int id)
        {
            return 0;
        }

        public Medico TraerUno(int id)
        {
            return null;
        }
    }
}