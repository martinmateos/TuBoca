using System;
using System.Collections.Generic;
using System.Text;

namespace TuBoca.Modelos
{
    public class Universidad
    {
        public int ID { get; set; }

        public string Nombre { get; set; }

        public string Direccion { get; set; }

        public string NumContacto { get; set; }
        public string NumContacto2 { get; set; }
        public string Web { get; set; }

        public string RedSocial { get; set; }

        public string Correo { get; set; }

        public string MostrarDatos
        {
            get
            {
                return string.Format("Universidad: " + Nombre + "{0}" + "Direccion: " + "{0}" + "Contactos: " + NumContacto + " o " + NumContacto2 + "{0}" + "Sitio Web: " + Web +
                    "{0}" + "Red social: " + RedSocial + "{0}" + "Correo: " + Correo, Environment.NewLine);
            }
        }
    }
    
    public class ListUniversidad
    {
        public List<Universidad> ListUnis { get; set; }
    }
}
