using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace TuBoca.Modelos
{
    public class Enunciado
    {
        public string Contenido { get; set; }
        
        public int ID { get; set; }

        public char Tipo { get; set; }

        public string Data
        {
            get
            {
                return string.Format("{0}, {1}", ID, Contenido);
            }
        }
    }

    public class ListEnunciado
    {
        public List<Enunciado> Enunciados { get; set; }
    }
    
           
}
