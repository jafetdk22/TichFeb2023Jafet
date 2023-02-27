using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LINQ
{
    internal class OperacionesLINQ
    {
        private List<Alumno> _lsAlumnos = new List<Alumno>();
        private List<Estado> _lsEstados = new List<Estado>();
        private List<Estatus> _lsEstatus = new List<Estatus>();
        private List<ItemISR> _TablaISR = new List<ItemISR>();
        public void CargarLists()
        {
            string archivoAlumnos = File.ReadAllText(@"C:\Users\jafet SG\Desktop\Alumnos.json");
            List<Alumno> alumnos = JsonConvert.DeserializeObject<List<Alumno>>(archivoAlumnos);

            string archivoEstados = File.ReadAllText(@"C:\Users\jafet SG\Desktop\Estados.json");
            List<Estado> estados = JsonConvert.DeserializeObject<List<Estado>>(archivoEstados);

            string archivoEstatus = File.ReadAllText(@"C:\Users\jafet SG\Desktop\Estatus.json");
            List<Estatus> estatus = JsonConvert.DeserializeObject<List<Estatus>>(archivoEstatus);

            /*Cargar el archivo csv*/
            // Cargar el archivo CSV
            List<ItemISR> TablaISR = new List<ItemISR>();

            using (StreamReader archivo = new StreamReader(@"C:\Users\jafet SG\Desktop\tabla.csv"))
            {
                while (!archivo.EndOfStream)
                {
                    string linea = archivo.ReadLine();
                    string[] campos = linea.Split(',');

                    ItemISR item = new ItemISR();
                    item.LimInf = decimal.Parse(campos[0]);
                    item.LimSup = decimal.Parse(campos[1]);
                    item.CuotaFija = decimal.Parse(campos[2]);
                    item.ProExceded = decimal.Parse(campos[3]);
                    item.Subsidio= decimal.Parse(campos[4]);


                    TablaISR.Add(item);
                }
            }

        }
        public void Consultas()

        {
            /*7.2.1.1. De la lista de estados, obtener el estado que tiene el id = 5*/
            Estado estado = _lsEstados.FirstOrDefault(e => e.Id == 5);
            Console.WriteLine($"El estado con id = 5 es: {estado.Name}");
            /*7.2.1.2. De la lista de alumnos obtener a los alumnos cuyo idEstado es 29 y 13, ordenado por nombre*/
            var alumnos2913 = _lsAlumnos.Where(a => a.IdEstado == 29 || a.IdEstado == 13).OrderBy(a => a.Nombre);
            Console.WriteLine("Alumnos con idEstado 29 o 13, ordenados por nombre:");
            foreach (var alumno in alumnos2913)
            {
                Console.WriteLine($"{alumno.Nombre}, estado {estado.Name}");
            }
            /*7.2.1.3. De la lista de alumnos obtener los alumnos que son IdEstado 19 y 20 y además de que estén en el estatus 4 o 5*/
            var alumnos1920 = _lsAlumnos.Where(a => (a.IdEstado == 19 || a.IdEstado == 20)
                                        && (a.IdEstatus == 4 || a.IdEstatus == 5));
            Console.WriteLine("Alumnos con idEstado 19 o 20 y en estatus 4 o 5:");
            foreach (var alumno in alumnos1920)
            {
                Console.WriteLine($"{alumno.Nombre}, estado {alumno.IdEstado}, estatus {alumno.IdEstatus}");
            }
            /*7.2.1.4. Obtener una lista de los alumnos que tienen calificación aprobatoria, considerando esta como 6 o mayor,
             * ordenado por calificación del mayor al menor*/
            var alumnosAprobatorios = _lsAlumnos.Where(a => a.Calificacion >= 6)
                                    .OrderByDescending(a => a.Calificacion);

            Console.WriteLine("Alumnos con calificación aprobatoria, ordenados de mayor a menor:");
            foreach (var alumno in alumnosAprobatorios)
            {
                Console.WriteLine($"{alumno.Nombre}, calificación {alumno.Calificacion}");
            }
            /*7.2.1.5. Obtener la calificación promedio de los alumnos*/
            decimal calificacionPromedio = _lsAlumnos.Average(a => a.Calificacion);
            Console.WriteLine($"La calificación promedio de los alumnos es: {calificacionPromedio}");

            /*7.2.1.6. En caso de que ningún alumno tenga 10, sumarles un punto de calificación, 
             * y en caso de que todos estén entre 6 y 7 sumarles dos puntos.*/
            decimal calificacionMaxima = _lsAlumnos.Max(a => a.Calificacion);
            if (calificacionMaxima < 10)
            {
                var alumnosSinDiez = _lsAlumnos.Where(a => a.Calificacion < 10);
                foreach (var alumno in alumnosSinDiez)
                {
                    alumno.Calificacion++;
                }
            }

            bool todosEntre6y7 = _lsAlumnos.All(a => a.Calificacion >= 6 && a.Calificacion <= 7);
            if (todosEntre6y7)
            {
                foreach (var alumno in _lsAlumnos)
                {
                    alumno.Calificacion += 2;
                }
            }
            /*7.2.1.9. Mostar en la consola los siguientes datos, de aquellos alumnos cuyo estatus sea mayor a 2,
             * ordenado por nombre del estatus:*/
            var alumnosEstatusMayor2 = from alumno in _lsAlumnos
                                       join Estado in _lsEstados on alumno.IdEstado equals Estado.Id
                                       join estatus in _lsEstatus on alumno.IdEstatus equals estatus.Id
                                       where alumno.IdEstatus > 2
                                       orderby estatus.Name, alumno.Nombre
                                       select new { idAlumno = alumno.Id, nombreAlumno= alumno.Nombre,estadoNombre=Estado.Name, estatusNombre = estatus.Name};

            foreach (var alumno in alumnosEstatusMayor2)
            {
                Console.WriteLine($"IdAlumno: {alumno.idAlumno}, Nombre: {alumno.nombreAlumno}, Estado: {alumno.nombreAlumno}, Estatus: {alumno.nombreAlumno}");
            }
            /*7.2.1.10. Calcular el impuesto para un sueldo mensual de 22,000, y mostrarlo en la consola:
             • La búsqueda en la tablaISR de los parámetros correspondientes para el cálculo del 
            ISR deben de ser a través de LINQ*/
            decimal sueldoMensual = 22000;

            var itemISR = (from isr in _TablaISR
                           where sueldoMensual >= isr.LimInf && sueldoMensual <= isr.LimSup
                           select isr).FirstOrDefault();

            if (itemISR != null)
            {
                decimal excedente = sueldoMensual - itemISR.LimInf;
                decimal impuesto = itemISR.CuotaFija + (excedente * itemISR.ProExceded / 100);
                Console.WriteLine($"El impuesto para un sueldo mensual de {sueldoMensual:C2} es de {impuesto:C2}");
            }
            else
            {
                Console.WriteLine("No se encontró un valor de ISR correspondiente para el sueldo proporcionado");
            }



        }
    }
}
