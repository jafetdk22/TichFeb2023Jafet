using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    public abstract class ItemBase
    {
        protected ItemBase(Articulo articulo, int cantidad)
        {
            Id =articulo.Id;
            Nombre = articulo.Nombre;
            Precio = articulo.Precio;
            Cantidad = cantidad;
        }

        protected ItemBase()
        {
        }

        public int Id { get; set; }
        public string Nombre{ get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }



        public virtual decimal SubTotal()
        {
            decimal subTotal;
            subTotal = Precio *  Cantidad;
            return subTotal;
        }

        public virtual decimal Total()
        {
            decimal total= Precio * Cantidad;
            return total;
        }
        public abstract void Imprimir();
    }

}
