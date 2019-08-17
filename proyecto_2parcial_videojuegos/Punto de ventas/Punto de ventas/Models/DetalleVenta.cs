using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_ventas.Models
{
    public class DetalleVenta
    {
        [PrimaryKey, Identity]
        public int detalle_venta_id { set; get; }
        public string Venta_id { set; get; }
        public string Videojuego_id { set; get; }
        public string Almacen_id { set; get; }
        public string Cantidad { set; get; }

    }
}
