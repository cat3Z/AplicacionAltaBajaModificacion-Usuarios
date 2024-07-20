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
            string sql = $"INSERT INTO usuarios (nombre,apellido) VALUES('{this.Nombre}',{this.Apellido})";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();
        }

    }
}
