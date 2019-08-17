using LinqToDB;
using LinqToDB.Data;
using Punto_de_ventas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_ventas.Connection
{
    public class Conexion:DataConnection
    {
        public Conexion() : base("JOMV") { }
        public ITable<Almacen> almacen { get { return GetTable<Almacen>(); } }
        public ITable<DetalleVenta> det_ven { get { return GetTable<DetalleVenta>(); } }
        public ITable<Usuario> usuario { get { return GetTable<Usuario>(); } }
        public ITable<Consola> consola { get { return GetTable<Consola>(); } }
        public ITable<Proveedor> proveedor { get { return GetTable<Proveedor>(); } }
        public ITable<Categoria> categoria { get { return GetTable<Categoria>(); } }
        public ITable<Cliente> cliente { get { return GetTable<Cliente>(); } }
    }
}
