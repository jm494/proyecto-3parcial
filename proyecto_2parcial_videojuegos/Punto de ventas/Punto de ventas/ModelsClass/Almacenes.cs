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
    public class Almacenes:Conexion
    {
        public List<Almacen> getAlmacen()
        {
            var query = from c in almacen
                        select c;
            return query.ToList();
        }
        public void insertAlmacen(string id, string nombre, 
            string direccion, string colonia, string clve)
        {
            int pos, idAlmacen;
            using(var db=new Conexion())
            {
                db.Insert(new Almacen()
                {
                    ID=id,
                    Nombre=nombre,
                    Direccion=direccion,
                    Colonia=colonia,
                    Clv_estado=clve
                });
                List<Almacen> almacen = getAlmacen();
                pos = almacen.Count;
                pos--;
                idAlmacen = almacen[pos].almacen_id;

            }
        }
    }
}
