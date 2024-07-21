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
    public partial class Interfaz : Form
    {
        public Interfaz()
        {
            InitializeComponent();
        }

        private void refrescarTablaDeDatos()
        {
            tablaDeDatos.Refresh();
            tablaDeDatos.DataSource = UsuarioControlador.Listar();
        }

        private void botonAlta_Click(object sender, EventArgs e)
        {
            UsuarioControlador.Alta(textId.Text, textNombre.Text, textApellido.Text);
            MessageBox.Show($"Has dado de alta el usuario {textNombre.Text} {textApellido.Text}.");
            textId.Text = (Int32.Parse(textId.Text) + 1).ToString();
            refrescarTablaDeDatos();
            textNombre.Text = "";
            textApellido.Text = "";
        }

        private void botonBaja_Click(object sender, EventArgs e)
        {
                        string id = tablaDeDatos.SelectedRows[0].Cells["id"].Value.ToString();
            DialogResult resultado = MessageBox.Show(
                $"Esta seguro de eliminar {id}?",
                "Esta seguro?",
                MessageBoxButtons.YesNo);

            if (resultado.ToString() == "Yes")
            {
                UsuarioControlador.Eliminar(id);
                refrescarTablaDeDatos();
                MessageBox.Show("Pizza eliminada");
            }
        }
    }
}
