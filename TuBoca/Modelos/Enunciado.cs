﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace TuBoca.Modelos
{
    //[Table("enunciado")]
    public class Enunciado
    {
        //[MaxLength (300)]
        public string Contenido { get; set; }

        //[PrimaryKey, AutoIncrement]
        public int ID { get; set; }


        public Personalidad Tipo { get; set; }

        public string Data
        {
            get
            {
                return string.Format("{0}, {1}, {2}", ID, Contenido, Tipo);
            }
        }
    }

    public class ListEnunciado
    {
        public List<Enunciado> enunciados { get; set; }
    }
    
           
}