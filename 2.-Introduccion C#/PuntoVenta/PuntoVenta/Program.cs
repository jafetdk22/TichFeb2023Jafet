using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    internal class Program
    {

        static void Main(string[] args)
        {

            CargarArticulos c = new CargarArticulos();
            c.CargarList();

            // List<Articulo> _CarritoCompras = new List<Articulo>();
            List<object> recibos = new List<object>();

            Console.WriteLine("TICH \n");
            Console.WriteLine("(V) INICIAR UNA NUEVA VENTA.");
            Console.WriteLine("(T) TERMINAR");
            string opcion = Console.ReadLine().ToLower();

            do
            {
                switch (opcion)
                {
                    case "v":
                        Console.WriteLine("Ingrese el id del producto");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la cantidad de productos a vender");
                        int cantidad = int.Parse(Console.ReadLine());
                        Articulo producto = c.buscarArticulos(id);

                        if (producto.Tipo == 1)
                        {
                            Item item = new Item(producto, cantidad);
                            recibos.Add(item);

                            // item.Imprimir();

                        }
                        else if (producto.Tipo == 2)
                        {
                            Console.WriteLine("Proporcione el % Descuento");
                            decimal descuento = int.Parse(Console.ReadLine());
                            ItemDescuento Idescuento = new ItemDescuento(producto, cantidad);
                            Idescuento.Descuento = descuento;

                            recibos.Add(Idescuento);

                            //Idescuento.Imprimir();

                        }
                        else if (producto.Tipo == 3)
                        {
                            Console.WriteLine("Proporcione el Teléfono");
                            string telefono = Console.ReadLine();
                            Console.WriteLine("Proporcione la compañía");
                            string compañia = Console.ReadLine();
                            Console.WriteLine("Proporcione la comisión");
                            decimal comision = Convert.ToDecimal(Console.ReadLine());
                            ItemTA itemTA = new ItemTA(producto, cantidad);
                            itemTA.Telefono = telefono;
                            itemTA.Compañia = compañia;
                            itemTA.Comision = comision;
                            recibos.Add(itemTA);

                            // _CarritoCompras.Add(new Articulo(producto.Id,producto.Nombre,producto.Precio,producto.Tipo));

                            //itemTA.Imprimir();
                        }

                        break;
                    case "t":
                        break;
                }
                Console.WriteLine("presiona V para otra venta y T para cerrar venta");
                opcion = Console.ReadLine();
            } while (opcion != "t");
            Console.WriteLine("Recibos:");
            decimal total = 0;
            foreach (object recibo in recibos)
            {
                if (recibo is Item item)
                {
                    item.Imprimir();
                    total += item.Total();
                }
                else if (recibo is ItemDescuento itemDescuento)
                {
                    itemDescuento.Imprimir();
                    total += itemDescuento.Total();
                }
                else if (recibo is ItemTA itemTA)
                {
                    itemTA.Imprimir();
                    total += itemTA.Total();
                }
            }
            Console.WriteLine($"Total de la venta: ${total} pesos\n");

            Console.ReadKey();
        }
    }
}
