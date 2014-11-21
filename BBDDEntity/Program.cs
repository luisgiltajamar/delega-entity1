using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BBDDEntity.Modelo;

namespace BBDDEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DatosEntities();

            var c = new Curso()
            {
                nombre = "C#2",
                fechaInicio = DateTime.Now
            };

            var c1 = new Curso()
            {
                nombre = "Java2",
                fechaInicio = DateTime.Now
            };
            var c2 = new Curso()
            {
                nombre = "JavaScript2",
                fechaInicio = DateTime.Now
            };
            var c3 = new Curso()
            {
                nombre = "Botanica"

            };
            var alu = new Alumno()
            {
                
                nombre = "Luis",
                Curso = c2

            };
            db.Curso.Add(c);

            db.Curso.Add(c1);
            db.Curso.Add(c2);
            db.Alumno.Add(alu);
            db.Curso.Add(c3);


            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


            foreach (var alumno in db.Alumno)
            {
                Console.WriteLine(alumno.Curso.nombre);
            }
        }
    }
}
