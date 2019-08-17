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
    public class DetalleVentas : Conexion
    {
        public List<DetalleVenta> getDetalleVenta()
        {

            var query = from c in det_ven select c;
            return query.ToList();

        }

        public void insertarDetalleVenta(string venta_id, string videojuego_id, string almacen_id, string cantidad)
        {
            int pos, detalle_venta_id;
            using (var db = new Conexion())
            { 
                db.Insert(new DetalleVenta()
                {
                    Venta_id = venta_id,
                    Videojuego_id = videojuego_id,
                    Almacen_id = almacen_id,
                    Cantidad = cantidad
                });
                List<DetalleVenta> dt = getDetalleVenta();
                pos = dt.Count;
                pos--;
                detalle_venta_id = dt[pos].detalle_venta_id;
            }

        }
    }
}
