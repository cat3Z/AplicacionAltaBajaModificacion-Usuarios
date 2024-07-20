using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class UsuarioControlador
    {
        public static void Alta(string id, string nombre, string apellido)
        {
            UsuarioModelo usuario = new UsuarioModelo();
            usuario.Id = Int32.Parse(id);
            usuario.Nombre = nombre;
            usuario.Apellido = apellido;

            usuario.GuardarUsuario();

        }

        public static void Eliminar(string id)
        {
            UsuarioModelo usuario = new UsuarioModelo();
            usuario.Id = Int32.Parse(id);
            usuario.BorrarUsuario();
        }


        public static DataTable Listar()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id", typeof(int));
            tabla.Columns.Add("Nombre", typeof(string));
            tabla.Columns.Add("Apellido", typeof(string));


            UsuarioModelo pizza = new UsuarioModelo();
            foreach (UsuarioModelo u in pizza.ObtenerTodos())
            {
                DataRow fila = tabla.NewRow();
                fila["Id"] = u.Id;
                fila["Nombre"] = u.Nombre;
                fila["Precio"] = u.Apellido;
                tabla.Rows.Add(fila);
            }

            return tabla;

        }



    }
}