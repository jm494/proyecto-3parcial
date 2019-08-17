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
    public class Consolas:Conexion
    {
        public List<Consola> getConsola()
        {
            var query = from c in consola
                        select c;
            return query.ToList();
        }
        public void insertConsola(string nombre)
        {
            int pos, idConsola;
            using (var db = new Conexion())
            {
                db.Insert(new Consola()
                {
                    Nombre = nombre
                });
                List<Consola> consola = getConsola();
                pos = consola.Count;
                pos--;
                idConsola = consola[pos].consola_id;

            }
        }
    }
}
