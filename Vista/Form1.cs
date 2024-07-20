using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonBaja_Click(object sender, EventArgs e)
        {
            string id = tablaDeDatos.SelectedRows[0].Cells["id"].Value.ToString();
                UsuarioControlador.Eliminar(id);
                refrescarTablaDeDatos();
                MessageBox.Show("Pizza eliminada");

        }
        private void refrescarTablaDeDatos()
        {
            tablaDeDatos.Refresh();
            tablaDeDatos.DataSource = UsuarioControlador.Listar();
        }

        private void tablaDeDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textId.Text = tablaDeDatos.SelectedRows[0].Cells["id"].Value.ToString();
            textNombre.Text = tablaDeDatos.SelectedRows[0].Cells["nombre"].Value.ToString();
            textApellido.Text = tablaDeDatos.SelectedRows[0].Cells["apellido"].Value.ToString();
        }
    }
}
