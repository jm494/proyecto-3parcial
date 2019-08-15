using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_ventas.Models
{
    class Categoria
    {
      private  int categoria_id;
      private  string nombre;


        public string getNombre(){
            return nombre;
        }

        public void setNombre(string nombre) {
            this.nombre = nombre;
        }

        public int getCategoria_id() {
            return categoria_id;


        }
        public void setCategorid_id(int cat)
        {
            categoria_id = cat;
        }





    }
}
