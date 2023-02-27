using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEstatus
{
    internal class Estatus
    {
        public Estatus()
        {
        }

        public Estatus(int id, string clave, string nombre)
        {
            Id = id;
            Clave = clave;
            Nombre = nombre;
        }

        public int Id { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
    }
}
