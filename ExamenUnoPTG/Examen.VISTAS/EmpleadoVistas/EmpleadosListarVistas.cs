using Examen.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen.VISTAS.EmpleadoVistas
{
    public partial class EmpleadosListarVistas : Form
    {
        public EmpleadosListarVistas()
        {
            InitializeComponent();
        }
        EmpleadosBss bss = new EmpleadosBss();
        private void EmpleadosListarVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarEmpleadosBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // PersonaVistas.PersonaListarVista.IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        /*private void button2_Click(object sender, EventArgs e)
        {
            int IdEmpleadoSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar a Este Empleado?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarEmpleadoBss(IdEmpleadoSeleccionada);
                dataGridView1.DataSource = bss.ListarEmpleadosBss();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmpleadoInsertarVista fr = new EmpleadoInsertarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarEmpleadosBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdEmpleadoSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            EmpleadoEditarVista fr = new EmpleadoEditarVista(IdEmpleadoSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarEmpleadosBss();
            }
        }*/
    }
}
