using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    internal class ItemTA:ItemBase
    {
        public ItemTA()
        {
        }

        public ItemTA(Articulo articulo, int cantidad) : base(articulo, cantidad)
        {

        }


        public string Telefono { get; set; }
        public string Compañia { get; set; }
        public decimal Comision { get; set; }

        public override void Imprimir()
        {
            Console.WriteLine($"{Id} {Nombre} precio:${Precio} cantidad:{Cantidad} subtotal:${SubTotal()}");
            Console.WriteLine($"Telefono{Telefono} compañia: {Compañia} comisión:${Comision}");
            Console.WriteLine($"Total:{Total()}\n");
        }

        public override decimal Total()
        {
            decimal total = SubTotal() + Comision;
            return total;
        }
    }
}
