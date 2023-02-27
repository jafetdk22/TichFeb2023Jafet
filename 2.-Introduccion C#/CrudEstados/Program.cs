using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudEstados
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
                        Dictionary<int, Estado> DicEstado = objCrud.ConsultarTodos();
                        foreach (KeyValuePair<int, Estado> kvp in DicEstado)
                        {
                            Console.WriteLine($"id= {kvp.Key} nombre = {kvp.Value.Nombre}");
                        }

                        break;
                    case 2:
                        Console.WriteLine("Ingrese el id del objeto a consultar");
                        int id = int.Parse(Console.ReadLine());
                        Estado estado = objCrud.ConsultarSoloUno(id);
                        Console.WriteLine($"id= {estado.Id} nombre = {estado.Nombre}");

                        break;
                    case 3:
                        Estado estadoAgregar = new Estado();
                        Console.WriteLine("ingrese el id del estado");
                        estadoAgregar.Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese el Nombre del estado");
                        estadoAgregar.Nombre = Console.ReadLine();
                        objCrud.Agregar(estadoAgregar);
                        Console.WriteLine("¡Estado agregado Correctamente!");
                        break;
                    case 4:
                        estadoAgregar = new Estado();
                        Console.WriteLine("ingrese el id del estado");
                        estadoAgregar.Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese el Nombre del estado");
                        estadoAgregar.Nombre = Console.ReadLine();
                        objCrud.Actualizar(estadoAgregar);
                        Console.WriteLine("¡Estado Actualizado Correctamente!");
                        break;
                    case 5:
                        estadoAgregar = new Estado();
                        Console.WriteLine("ingrese el id del estado");
                        estadoAgregar.Id = int.Parse(Console.ReadLine());
                        objCrud.Eliminar(estadoAgregar);
                        Console.WriteLine("¡Estado Eliminado Correctamente!");
                        break;
                }

               // Console.Clear();
                Console.ReadLine();
            } while (opcion >= 1 && opcion <= 5);

        }
    }
}
