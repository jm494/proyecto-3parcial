using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_ventas.Models
{
    public class Consola
    {
        [PrimaryKey, Identity]
        public int consola_id { get; set; }
        public string Nombre { get; set; }

    }
}
