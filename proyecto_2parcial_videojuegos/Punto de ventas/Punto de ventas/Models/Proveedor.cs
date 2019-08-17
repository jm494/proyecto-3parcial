using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_ventas.Models
{
    public class Proveedor
    {
        [PrimaryKey, Identity]
        public int proveedor_id { get; set; }
        public string ID { get; set; }
        public string Razon_social { get; set; }
        public string Rfc { get; set; }
    }
}
