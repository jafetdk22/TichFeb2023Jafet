using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    public class ItemDescuento : ItemBase
    {
        public ItemDescuento()
        {
        }

        public ItemDescuento(Articulo articulo, int cantidad):base(articulo,cantidad)
        {
        }

        public decimal Descuento { get; set; }
        public decimal ImpDescuento { get { return SubTotal() * (Descuento / 100); } }

        public override void Imprimir()
        {
            Console.WriteLine($"{Id} {Nombre} precio:${Precio} cantidad:{Cantidad} subtotal:${SubTotal()}");
            Console.WriteLine($"Descuento:{ImpDescuento} ({Descuento}%)");
            Console.WriteLine($"Total:${Total()}\n");

        }

        public override decimal Total()
        {
            decimal total = SubTotal() - ImpDescuento;
            return total;
        }

    }
}
