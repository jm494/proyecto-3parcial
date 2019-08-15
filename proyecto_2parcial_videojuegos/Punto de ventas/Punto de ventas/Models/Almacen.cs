using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_ventas.Models
{
    public class Almacen
    {
        [PrimaryKey, Identity]
        public int almacen_id { set; get; }
        public string nombre { set; get; }
        public string direccion { set; get; }
        public string colonia { set; get; }
        public string clv_estado { set; get; }
        // ok entonces nos vamos sobre el modelo anterior

        
    }
}
