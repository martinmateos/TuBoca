using System;
using System.Collections.Generic;
using System.Text;

namespace TuBoca.Modelos
{
    public class Usuario
    {
        public int ID { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }
    }

    public class ListUser
    {
        public List<Usuario> usuarios { get; set; }
    }
}
