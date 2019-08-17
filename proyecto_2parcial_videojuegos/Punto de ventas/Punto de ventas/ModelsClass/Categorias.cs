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
    public class Categorias : Conexion
    {
        public List<Categoria> getCategoria()
        {
            var query = from c in categoria
                        select c;
            return query.ToList();
        }
        public void insertCategoria(string nombre, string clave)
        {
            int pos, idCategoria;
            using (var db = new Conexion())
            {
                db.Insert(new Categoria()
                {
                    Nombre = nombre,
                    Clave=clave
                });
                List<Categoria> categoria = getCategoria();
                pos = categoria.Count;
                pos--;
                idCategoria = categoria[pos].categoria_id;

            }
        }
    }
}
