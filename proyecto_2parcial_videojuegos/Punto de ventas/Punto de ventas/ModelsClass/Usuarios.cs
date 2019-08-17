using LinqToDB;
using Punto_de_ventas.Connection;
using Punto_de_ventas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_ventas.ModelsClass
{
    public class Usuarios : Conexion
    {
        public List<Usuario> getUsuario()
        {
            var query = from c in usuario
                        select c;
            return query.ToList();
        }
        public void insertUsuario(string nombre, string apellido, string password)
        {
            int pos, idUsuario;
            using (var db = new Conexion())
            {
                db.Insert(new Usuario()
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Password = password
                });
                List<Usuario> usuario = getUsuario();
                pos = usuario.Count;
                pos--;
                idUsuario = usuario[pos].usuario_id;

            }
        }
    }
}
