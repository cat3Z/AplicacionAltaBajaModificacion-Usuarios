using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class UsuarioModelo : Modelo
    {
        public int Id;
        public string Nombre;
        public string Apellido;


        public void GuardarUsuario()
        {
            string sql = $"INSERT INTO usuarios (id,nombre,apellido) VALUES({this.Id},'{this.Nombre}','{this.Apellido}')";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();
        }

        public void BorrarUsuario()
        {
            string sql = $"UPDATE usuarios SET eliminado = true WHERE id ='{this.Id}'";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();
        }

        public List<UsuarioModelo> ObtenerTodos()
        {
            List<UsuarioModelo> usuarios = new List<UsuarioModelo>();

            string sql = $"SELECT * FROM usuarios WHERE eliminado = false";
            this.Comando.CommandText = sql;
            this.Lector = this.Comando.ExecuteReader();

            while (this.Lector.Read())
            {
                UsuarioModelo usuario = new UsuarioModelo();
                usuario.Id = Int32.Parse(this.Lector["Id"].ToString());
                usuario.Nombre = this.Lector["Nombre"].ToString();
                usuario.Nombre = this.Lector["Apellido"].ToString();
                usuarios.Add(usuario);
            }
            return usuarios;

        }


    }
}
