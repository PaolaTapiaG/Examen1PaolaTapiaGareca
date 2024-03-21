using GestionDeEmpleados.BSS;
using GestionDeEmpleados.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionDeEmpleados.VISTA.PersonaVistas
{
    public partial class PersonaEditarVista : Form
    {
        int idpersona = 0;
        
        public PersonaEditarVista(int id)
        {
            idpersona = id;
            InitializeComponent();
        }
        Persona persona = new Persona();
        PersonaBss bss = new PersonaBss();
        private void PersonaEditarVista_Load(object sender, EventArgs e)
        {
            persona = bss.ObtenerPersonaIdBss(idpersona);
            textBox1.Text = persona.Nombre;
            textBox2.Text = persona.Apellido;
            textBox3.Text = persona.Estado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            persona.Nombre = textBox1.Text;
            persona.Apellido = textBox2.Text;
            persona.Estado = textBox3.Text;


            bss.EditarPersonaBss(persona);
            MessageBox.Show("Datos Editados Correctamente");
        }
    }
}
