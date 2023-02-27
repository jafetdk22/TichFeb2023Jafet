using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEstatus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Crud objCrud = new Crud();
            int opcion = 0;
            do
            {
                Console.WriteLine("Seleccione una opcion\r\n1. Consultar Todos\r\n2. Consultar Solo uno\r\n3. Agregar\r\n4. Actualizar\r\n5. Eliminar\r\n6. Terminar");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        List<Estatus> lisEstatus = objCrud.ConsultarTodos();

                        foreach (Estatus item in  lisEstatus)
                        {
                           Console.WriteLine($"id= {item.Id} clave= {item.Clave} nombre = {item.Nombre}");
                        }
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el id del registro a consultar");
                        int id = int.Parse(Console.ReadLine());
                        Estatus estatus = objCrud.ConsultarSoloUno(id);
                        Console.WriteLine($"id= {estatus.Id} clave= {estatus.Clave} nombre = {estatus.Nombre}");
                        break;
                    case 3:
                        Estatus estatusAgregar = new Estatus();
                        Console.WriteLine("ingrese el id del Estatus");
                        estatusAgregar.Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese la Clave del Estatus");
                        estatusAgregar.Clave = Console.ReadLine();
                        Console.WriteLine("ingrese el Nombre del Estatus");
                        estatusAgregar.Nombre = Console.ReadLine();
                        objCrud.Agregar(estatusAgregar);
                        Console.WriteLine("¡Estatus agregado Correctamente!");
                        break;
                    case 4:
                        estatusAgregar = new Estatus();
                        Console.WriteLine("ingrese el id del Estatus");
                        estatusAgregar.Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese la Clave del estatus");
                        estatusAgregar.Clave = Console.ReadLine();
                        Console.WriteLine("ingrese el Nombre del estatus");
                        estatusAgregar.Nombre = Console.ReadLine();
                        objCrud.Actualizar(estatusAgregar);
                        Console.WriteLine("¡Estado agregado Correctamente!");
                        break;
                    case 5:
                        estatusAgregar = new Estatus();
                        Console.WriteLine("ingrese el id del estado");
                        estatusAgregar.Id = int.Parse(Console.ReadLine());
                        objCrud.Eliminar(estatusAgregar);
                        Console.WriteLine("¡Estado Eliminado Correctamente!");

                        break;
                }

                // Console.Clear();
                Console.ReadLine();
            } while (opcion >= 1 && opcion <= 5);
        }
    }
}
