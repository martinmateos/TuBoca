using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TuBoca.Modelos
{
    //[Table ("personalidad")]
    public class Personalidad
    {
        //[MaxLength (200)]
        public int Realista { get; set; }

        //[MaxLength(200)]
        public int Investigador { get; set; }

        //[MaxLength(200)]
        public int Artistico { get; set; }

        //[MaxLength(200)]
        public int Social { get; set; }

        //[MaxLength(200)]
        public int Emprendedor { get; set; }

        //[MaxLength(200)]
        public int Convencional { get; set; }
    }
}
