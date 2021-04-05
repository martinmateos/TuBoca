using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TuBoca.Modelos
{
    public class Personalidad
    {
        public int Realista { get; set; }

        public int Investigador { get; set; }

        public int Artistico { get; set; }

        public int Social { get; set; }

        public int Emprendedor { get; set; }

        public int Convencional { get; set; }
    }
}
