using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    public class Item : ItemBase
    {
        public Item(Articulo articulo, int cantidad) : base(articulo, cantidad)
        {

        }

        public override void Imprimir()
        {
            Console.WriteLine($"{Id}  {Nombre} precio:${Precio} cantidad: {Cantidad} subtotal:${SubTotal()}");
            Console.WriteLine($"Total:${Total()}\n");
        }
    }
}
