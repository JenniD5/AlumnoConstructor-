﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnoConstructores
{
    class Alumno
    {
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public Alumno()
        {
            Nombre="pendiente";
            Matricula = "sin asignar";
        }

        public Alumno(string nombre, string matricula)
        {
            Nombre = nombre;
            Matricula = matricula;
        }

    }
}
