using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Entidades.ModelsBase;
using Negocio;




namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {

        /*AdmMedico admMedicos = new AdmMedico();
        AdmPaciente admPacientes = new AdmPaciente();
        AdmHabitacion admHabitaciones = new AdmHabitacion();
        */

        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerMedicos_Click(object sender, EventArgs e)
        {
            gridDatos.DataSource = AdmMedico.Listar();

            lstMedicosClinicos.Items.Clear();
            foreach (Medico medico in AdmMedico.Listar("Clinico"))
            {
                lstMedicosClinicos.Items.Add(medico.Nombre + " " + medico.Apellido);
            }
        }

        private void btnVerPacientes_Click(object sender, EventArgs e)
        {
            gridDatos.DataSource = AdmPaciente.Listar();

            foreach (Habitacion habitacion in AdmHabitacion.Listar())
            {
                lstHabitaciones.Items.Add("Número: " + habitacion.Numero + ", estado: " + habitacion.Estado);
            }
        }


    }
}