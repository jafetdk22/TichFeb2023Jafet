using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudEstados
{
    internal class Crud
    {
        private Dictionary<int, Estado> _DicEstados = new Dictionary<int, Estado>();
        public Dictionary<int, Estado> ConsultarTodos() => _DicEstados;

        public Estado ConsultarSoloUno(int id)
        {
            Estado estado = new Estado();
            if (!_DicEstados.ContainsKey(id))
            {
                estado = _DicEstados[id];
            }
            return estado;
        }
        public void Agregar(Estado estado)
        {
            try
            {
                _DicEstados.Add(estado.Id, estado);
            }
            catch
            {
                throw;
            }
        }
        public void Actualizar(Estado estado)
        {
            if (!_DicEstados.ContainsKey(estado.Id))
            {
                _DicEstados[estado.Id] = estado;

            }
        }
        public void Eliminar(Estado estado)
        {
            _DicEstados.Remove(estado.Id);
        }
    
    }
}
