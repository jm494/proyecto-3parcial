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
    public class Clientes:Conexion
    {
        public List<Cliente> getCliente()
        {
            var query = from c in cliente
                        select c;
            return query.ToList();
        }
        public void insertCliente(string id, string nombre,
            string apellido, string direccion, string telefono)
        {
            int pos, idCliente;
            using (var db = new Conexion())
            {
                db.Insert(new Cliente()
                {
                    ID = id,
                    Nombre = nombre,
                    Apellido=apellido,
                    Direccion = direccion,
                    Telefono=telefono
                });
                List<Cliente> cliente = getCliente();
                pos = cliente.Count;
                pos--;
                idCliente = cliente[pos].cliente_id;

            }
        }
    }
}
