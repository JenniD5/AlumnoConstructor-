
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnoConstructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
     


            Console.WriteLine("nombre;" + alumno1.Nombre);
            Console.WriteLine("matriula;" + alumno1.Matricula);

            Alumno alumno2 = new Alumno("jose", "1234");
            
            Console.WriteLine("nombre  " + alumno2.Nombre);
            Console.WriteLine("mat:"+ alumno2.Matricula);

            Console.Read();

        }
    }
}
