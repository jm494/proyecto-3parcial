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
    public class Proveedores : Conexion
    {
        public List<Proveedor> getProveedor()
        {
            var query = from c in proveedor
                        select c;
            return query.ToList();
        }
        public void insertProveedor(string id, string razon_social, string rfc)
        {
            int pos, idProveedor;
            using (var db = new Conexion())
            {
                db.Insert(new Proveedor()
                {
                    ID=id,
                    Razon_social = razon_social,
                    Rfc = rfc
                });
                List<Proveedor> proveedor = getProveedor();
                pos = proveedor.Count;
                pos--;
                idProveedor = proveedor[pos].proveedor_id;

            }
        }
    }
}
