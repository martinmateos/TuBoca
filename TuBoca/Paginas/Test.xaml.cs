using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using TuBoca.Modelos;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TuBoca.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Test : ContentPage
    {
        public Test()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            LoadEnunciado();
        }
        //variable para identificar el enunciado con ID 
        int idEnunciado = 1;
        //en esta lista se guardan los enunciados deserializados
        Enunciado enunciado = new Enunciado();
        
        //este objeto de clase tipo personalidad se guardan los puntajes
        public static Personalidad personalidad = new Personalidad();
        //Estas variables se utilizan para guardar los puntajes en las propiedades de personalidad
        //int rea, inv, art, soc, emp, con;
        double value;

        //public List<Personalidad> personalidades { get; set; }

        Valoracion valoracion = new Valoracion();
        public List<Valoracion> Valoraciones = new List<Valoracion> { };

        /*intento de metodo que devuelva el resultado de la consulta linq
         (no funciona)*/
        private Enunciado Consulta(Enunciado i)
        {
            var query =
                from Enunciado enunciado in ObjListEnunciado.Enunciados
                where enunciado.ID == idEnunciado
                select enunciado == i;
            return i;
        }

        ListEnunciado ObjListEnunciado = new ListEnunciado();
        //carga los enunciados
        void LoadEnunciado()
        {
            string jsonFileName = "Enunciados.json";
            //ListEnunciado ObjListEnunciado = new ListEnunciado();
            var assembly = typeof(Test).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.Archivos.{jsonFileName}");
            using (var reader = new System.IO.StreamReader(stream))
            {
                var jsonString = reader.ReadToEnd();

                //Convirtiendo el arreglo de objetos JSON en una lista generica
                ObjListEnunciado = JsonConvert.DeserializeObject<ListEnunciado>(jsonString);
            }

            //Consulta LINQ sobre enunciados con ID = 1

            var query =
                from Enunciado enunciado in ObjListEnunciado.Enunciados
                where enunciado.ID == idEnunciado
                select enunciado;
            //mostramos el enunciado obtenido en la label
            foreach (Enunciado enunciado in query)
            {
                enunciadoLabel.Text = enunciado.Data;
            }
            barra.Value = 1;
            MostrarVars();
        }

        /* este boton hara que al clickearse se recorra la lista al siguiente objeto
        y sume al tipo de personalidad del enunciado*/
        private void btnNext_Clicked(object sender, EventArgs e)
        {
            SumPersonalidad();
            NextEnunciado();
            Resultado();
        }

        /*Este boton al clickearse retrocede la lista en uno y resta al tipo de personalidad
        del enuncidado*/
        private void btnBack_Clicked(object sender, EventArgs e)
        {
            if(idEnunciado > 1)
            {
                var ultiValor = Valoraciones.Last<Valoracion>().Valor;
                var query =
                    from Enunciado enunciado in ObjListEnunciado.Enunciados
                    where enunciado.ID == idEnunciado - 1
                    select enunciado;

                foreach (Enunciado enunciado in query)
                {
                    if (enunciado.Tipo == 'R')
                    {
                        personalidad.Realista -= ultiValor;
                    }
                    else if (enunciado.Tipo == 'A')
                    {
                        personalidad.Artistico -= ultiValor;
                    }
                    else if (enunciado.Tipo == 'C')
                    {
                        personalidad.Convencional -= ultiValor;
                    }
                    else if (enunciado.Tipo == 'S')
                    {
                        personalidad.Social -= ultiValor;
                    }
                    else if (enunciado.Tipo == 'I')
                    {
                        personalidad.Investigador -= ultiValor;
                    }
                    else if (enunciado.Tipo == 'E')
                    {
                        personalidad.Emprendedor -= ultiValor;
                    }
                    Valoraciones.Remove(Valoraciones.Last<Valoracion>());
                    idEnunciado--;
                    enunciadoLabel.Text = enunciado.Data;
                    MostrarVars();
                }
            }
        }

        void NextEnunciado()
        {
            idEnunciado++;
            var query =
                from Enunciado enunciado in ObjListEnunciado.Enunciados
                where enunciado.ID == idEnunciado
                select enunciado;

            foreach (Enunciado enunciado in query)
            {
                enunciadoLabel.Text = enunciado.Contenido;
            }
        }

        /*Este metodo se encarga de sumar el valor correspondiente (tomado del valor del slider) a las distintas propiedades de 
         Personalidad.*/
        private void SumPersonalidad()
        {
            value = barra.Value;
            //filtrado del enunciado
            var query =
                from Enunciado enunciado in ObjListEnunciado.Enunciados
                where enunciado.ID == idEnunciado
                select enunciado;


            //comienzo de la valoracion
            foreach (Enunciado enunciado in query)
            {
                //si el contenido del enunciado es distinto al del label entonces valuamos de lo contrario navegamos a los resultados
                valoracion.Valor = Convert.ToInt16(value);
                Valoraciones.Add(valoracion);
                if (enunciado.Tipo == 'R')
                {
                    personalidad.Realista += Convert.ToInt16(value);
                }
                else if (enunciado.Tipo == 'A')
                {
                    personalidad.Artistico += Convert.ToInt16(value);
                }
                else if (enunciado.Tipo == 'C')
                {
                    personalidad.Convencional += Convert.ToInt16(value);
                }
                else if (enunciado.Tipo == 'S')
                {
                    personalidad.Social += Convert.ToInt16(value);
                }
                else if (enunciado.Tipo == 'I')
                {
                    personalidad.Investigador += Convert.ToInt16(value);
                }
                else if (enunciado.Tipo == 'E')
                {
                    personalidad.Emprendedor += Convert.ToInt16(value);
                }

                MostrarVars();


                /* 
                
                else
                {
                    await Navigation.PushAsync(new Resultado());
                }*/


            }


        }

        async private void Resultado()
        {
            if (ObjListEnunciado.Enunciados.Last<Enunciado>().ID < idEnunciado)
            {
                await Navigation.PushAsync(new Resultado());
            }

        }

        private void MostrarVars()
        {
            realistaLabel.Text = "Su personalidad Realista es: " + personalidad.Realista;
            investidoraLabel.Text = "Su personalidad Investigador es: " + personalidad.Investigador;
            artisticaLabel.Text = "Su personalidad Artistico es: " + personalidad.Artistico;
            socialLabel.Text = "Su personalidad Social es: " + personalidad.Social;
            emprendedoraLabel.Text = "Su personalidad Emprendedor es: " + personalidad.Emprendedor;
            convencionalLabel.Text = "Su personalidad Convencional es: " + personalidad.Convencional;
        }



        private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            value = barra.Value;
            if (value >= 0 && value <= 1)
            {
                valorLabel.Text = "En total desacuerdo";
                barra.Value = 1;
            }
            if (value > 1 && value <= 2)
            {
                valorLabel.Text = "En desacuerdo";
                barra.Value = 2;
            }
            if (value > 2 && value <= 3)
            {
                valorLabel.Text = "Neutro";
                barra.Value = 3;
            }
            if (value > 3 && value <= 4)
            {
                valorLabel.Text = "De acuerdo";
                barra.Value = 4;
            }
            if (value > 4 && value <= 5)
            {
                valorLabel.Text = "Muy de acuerdo";
                barra.Value = 5;
            }
        }
    }
}