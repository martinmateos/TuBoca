using System;
using System.Collections.Generic;
using System.Text;

namespace TuBoca.Modelos
{
    class Carrera
    {
        public int ID { get; set; }

        public int IdUni { get; set; }

        public string Nombre { get; set; }

        public double Duracion { get; set; }

        public string Url { get; set; }

        public string MostrarDatos
        {
            get
            {
                return string.Format("Nombre: " + Nombre + "{0}" + "Duracion: " + Duracion + "{0}" + "El link con mas datos es: " + Url, Environment.NewLine);
            }
        }

    }
}
