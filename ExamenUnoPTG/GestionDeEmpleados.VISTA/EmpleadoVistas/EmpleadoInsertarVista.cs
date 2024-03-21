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
    public partial class EmpleadoInsertarVista : Form
    {
        public EmpleadoInsertarVista()
        {
            InitializeComponent();
        }
        EmpleadoBss bssempleado = new EmpleadoBss();
        private void button2_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.IdPersona = IdPersonaSeleccionada;
            empleado.Puesto = textBox2.Text;
            empleado.Salario = Convert.ToDecimal(textBox3.Text);
            empleado.FechaContratacion = dateTimePicker1.Value;

            bssempleado.InsertarEmpleadoBss(empleado);
            MessageBox.Show("Se guardo satisfactoriamente a Empleado");
        }
        public static int IdPersonaSeleccionada = 0;
        PersonaBss bss = new PersonaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bss.ObtenerPersonaIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }
        }
    }
}
