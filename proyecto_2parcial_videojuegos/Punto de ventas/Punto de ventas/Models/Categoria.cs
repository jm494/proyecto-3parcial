using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_ventas.Models
{
    public class Categoria
    {
        [PrimaryKey, Identity]
        public int categoria_id { set; get; }
        public string Nombre { set; get; }
        public string Clave { set; get; }
    }
}
