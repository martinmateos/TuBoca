using System;
using System.Collections.Generic;
using System.Text;

namespace TuBoca.Modelos
{
    public class CarreraResultado
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public bool Realista { get; set; }
        public bool Investigador { get; set; }
        public bool Artista { get; set; }
        public bool Social { get; set; }
        public bool Emprendedor { get; set; }
        public bool Convencional { get; set; }
    }
}
