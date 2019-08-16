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
        public string ID { set; get; }
        public string Nombre { set; get; }
        public string Direccion { set; get; }
        public string Colonia { set; get; }
        public string Clv_estado { set; get; }
        // ok entonces nos vamos sobre el modelo anterior

        
    }
}
