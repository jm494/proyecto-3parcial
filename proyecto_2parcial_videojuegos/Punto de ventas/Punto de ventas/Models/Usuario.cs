using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_ventas.Models
{
    public class Usuario
    {
        [PrimaryKey, Identity]
        public int usuario_id { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Password { set; get; }
    }
}
