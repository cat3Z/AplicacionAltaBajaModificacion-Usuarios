using System;
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
    }
}
