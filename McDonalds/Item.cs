using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds
{
    internal class Item
    {
        public String Nombre {get; set;}
        public int Precio {get; set;}

        public Item(string nombre, int precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }
}
