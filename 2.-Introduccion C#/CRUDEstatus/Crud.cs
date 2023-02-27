using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEstatus
{
    internal class Crud
    {
        private List<Estatus> _lsEstatus = new List<Estatus>();
        public List<Estatus> ConsultarTodos() => _lsEstatus;

        public Estatus  ConsultarSoloUno(int id)=>_lsEstatus.Find(i=> i.Id==id);

         
        public void Agregar(Estatus estatus)
        {
            _lsEstatus.Add(estatus);
        }
        public void Actualizar(Estatus estatus)
        {
            // Busca un registro por su ID
            Estatus estatusActualizar = _lsEstatus.Find(e => e.Id == estatus.Id);

            // Si se encuentra el registro, se actualizan sus propiedades
            if (estatusActualizar != null)
            {
                estatusActualizar.Id = estatus.Id;
                estatusActualizar.Clave = estatus.Clave;
                estatusActualizar.Nombre = estatus.Nombre;
                // ...
            }
        }
        public void Eliminar(Estatus estatus)
        {
            Estatus estatusBorrar = _lsEstatus.Find(e => e.Id == estatus.Id);
            if (estatusBorrar != null)
            { 
                _lsEstatus.Remove(estatusBorrar);
            }
        }

    }
}
