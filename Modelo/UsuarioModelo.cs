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
        public static int globalId = 1;
        public void GuardarUsuario()
        {
            string sql = $"INSERT INTO usuarios (id,nombre,apellido) VALUES({this.Id},'{this.Nombre}','{this.Apellido}')";
            this.Comando.CommandText = sql;
            this.Comando.ExecuteNonQuery();
            //this.Id = ++globalId;
        }

    }
}
