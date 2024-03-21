using GestionDeEmpleados.BSS;
using GestionDeEmpleados.Modelos;
using GestionDeEmpleados.VISTA.PersonaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeEmpleados.VISTA.EmpleadoVistas
{
    public partial class EmpleadoEditarVista : Form
    {
        
       
            int idempleado = 0;
        Empleado empl = new Empleado();
        EmpleadoBss bssem = new EmpleadoBss();
        public EmpleadoEditarVista(int id)
        {
            idempleado = id;
            InitializeComponent();
        }
        
        private void EmpleadoEditarVista_Load(object sender, EventArgs e)
        {
            empl = bssem.ObtenerEmpleadoIdBss(idempleado);
            textBox1.Text = empl.IdPersona.ToString();
            textBox2.Text = empl.Puesto;
            textBox3.Text = empl.Salario.ToString();
            dateTimePicker1.Value = empl.FechaContratacion;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            empl.IdPersona = IdPersonaSeleccionada;
            empl.Puesto = textBox2.Text;
            empl.Salario = Convert.ToDecimal(textBox3.Text);
            empl.FechaContratacion = dateTimePicker1.Value;
            bssem.EditarEmpleadoBss(empl);
            MessageBox.Show("Datos Editados");
        }

        public static int IdPersonaSeleccionada =0;
        PersonaBss bsspersona = new PersonaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bsspersona.ObtenerPersonaIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }
        }
    }
}
