using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;


namespace PuntoVenta
{
    public class CargarArticulos
    {
        public List<Articulo> _lsArticulos = new List<Articulo>();
        public List<Articulo> _tablaArticulo = new List<Articulo>();

        public void CargarList()
        {
            /*~ es para referenciar rutas dentro del proyecto NOTA PARA PONER LA VIRGULILLA ES ALT + 126*/
            StreamReader archivo = new StreamReader(@"..\..\datos\Articulos.json");
            string datosArticulos = archivo.ReadToEnd();
            archivo.Close();
            _tablaArticulo = JsonConvert.DeserializeObject<List<Articulo>>(datosArticulos);
        }
        public Articulo buscarArticulos(int id)
        {
            Articulo articulo = _tablaArticulo.Find(x => x.Id == id);
            return articulo;
        }

    }
}
