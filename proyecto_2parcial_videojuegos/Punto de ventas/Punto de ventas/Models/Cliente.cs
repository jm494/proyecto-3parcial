using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_ventas.Models
{
    public class Cliente
    {
        [PrimaryKey, Identity]
        public int cliente_id { set; get; }
        public string ID { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Direccion { set; get; }
        public string Telefono { set; get; }
    }
}
