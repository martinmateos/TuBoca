using Newtonsoft.Json;
using System;
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
        /*intento de metodo que devuelva el resultado de la consulta linq
         * (no funciona)
        private Enunciado Consulta (Enunciado i)
        {
            var query =
                from Enunciado enunciado in ObjListEnunciado.Enunciados
                where enunciado.ID == idEnunciado
                select enunciado == i;
            return i;
        }*/

        //variable para identificar el enunciado con ID 
        int idEnunciado = 1;
        ListEnunciado ObjListEnunciado = new ListEnunciado();
        void LoadEnunciado ()
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
            
        }



        /* este boton hara que al clickearse se recorra la lista al siguiente objeto
        y sume al tipo de personalidad del enunciado*/
        private void btnNext_Clicked(object sender, EventArgs e)
        {
            SumPersonalidad(personalidad1.Realista, personalidad1.Investigador, personalidad1.Artistico, personalidad1.Social,personalidad1.Emprendedor, personalidad1.Convencional);
            NextEnunciado();
        }
        Personalidad personalidad1 = new Personalidad();


        /*Este boton al clickearse retrocede la lista en uno y resta al tipo de personalidad
        del enuncidado*/
        private void btnBack_Clicked(object sender, EventArgs e)
        {

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
                enunciadoLabel.Text = enunciado.Data;
            }
        }

        
        private void SumPersonalidad(int realista, int investigador, int artistico, int social, int emprendedor, int convencional)
        {
            double value = barra.Value;
            Personalidad personalidad = new Personalidad()
            { 
                Realista = realista,
                Investigador = investigador, 
                Artistico = artistico,
                Social = social,
                Emprendedor = emprendedor,
                Convencional = convencional
            };

            var query =
                from Enunciado enunciado in ObjListEnunciado.Enunciados
                where enunciado.ID == idEnunciado
                select enunciado;

            foreach (Enunciado enunciado in query)
            {
                if (value >=0 && value <= 1)
                {
                    if (enunciado.Tipo == 'R')
                    {
                        realista++;
                    }
                    
                    if (enunciado.Tipo == 'I')
                    {
                        investigador++;
                    }

                    if (enunciado.Tipo == 'A')
                    {
                        artistico++;
                    }
                    
                    if (enunciado.Tipo == 'S')
                    {
                        social++;
                    }
                    
                    if (enunciado.Tipo == 'E')
                    {
                        emprendedor++;
                    }
                    
                    if (enunciado.Tipo == 'C')
                    {
                        convencional++;
                    }
                }
                if (value >1 && value <= 2)
                {
                    if (enunciado.Tipo == 'R')
                    {
                        realista = realista + 2;
                    }
                    if (enunciado.Tipo == 'A')
                    {
                        artistico = artistico + 2;
                    }
                    if (enunciado.Tipo == 'C')
                    {
                        convencional = convencional + 2;
                    }
                    if (enunciado.Tipo == 'S')
                    {
                        social = social + 2;
                    }
                    if (enunciado.Tipo == 'I')
                    {
                        investigador = investigador + 2;
                    }
                    if (enunciado.Tipo == 'E')
                    {
                        emprendedor = emprendedor + 2;
                    }
                }
                if (value > 2 && value <= 3)
                {
                    if (enunciado.Tipo == 'R')
                    {
                        realista = realista + 3;
                    }
                    if (enunciado.Tipo == 'A')
                    {
                        artistico = artistico + 3;
                    }
                    if (enunciado.Tipo == 'C')
                    {
                        convencional = convencional + 3;
                    }
                    if (enunciado.Tipo == 'S')
                    {
                        social = social + 3;
                    }
                    if (enunciado.Tipo == 'I')
                    {
                        investigador = investigador + 3;
                    }
                    if (enunciado.Tipo == 'E')
                    {
                        emprendedor = emprendedor + 3;
                    }
                }
                if (value > 3 && value <= 4)
                {
                    if (enunciado.Tipo == 'R')
                    {
                        realista = realista + 4;
                    }
                    if (enunciado.Tipo == 'A')
                    {
                        artistico = artistico + 4;
                    }
                    if (enunciado.Tipo == 'C')
                    {
                        convencional = convencional + 4;
                    }
                    if (enunciado.Tipo == 'S')
                    {
                        social = social + 4;
                    }
                    if (enunciado.Tipo == 'I')
                    {
                        investigador = investigador + 4;
                    }
                    if (enunciado.Tipo == 'E')
                    {
                        emprendedor = emprendedor + 4;
                    }
                }
                if (value > 4 && value <= 5)
                {
                    if (enunciado.Tipo == 'R')
                    {
                        realista = realista + 5;
                    }
                    if (enunciado.Tipo == 'A')
                    {
                        artistico = artistico + 5;
                    }
                    if (enunciado.Tipo == 'C')
                    {
                        convencional = convencional + 5;
                    }
                    if (enunciado.Tipo == 'S')
                    {
                        social = social + 5;
                    }
                    if (enunciado.Tipo == 'I')
                    {
                        investigador = investigador + 5;
                    }
                    if (enunciado.Tipo == 'E')
                    {
                        emprendedor = emprendedor + 5;
                    }
                }

            }
        }

        private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double value = barra.Value;
            if (value >= 0 && value <= 1)
            {
                valorLabel.Text = "En total desacuerdo";
            }
            if (value > 1 && value <= 2)
            {
                valorLabel.Text = "En desacuerdo";
            }
            if (value > 2 && value <= 3)
            {
                valorLabel.Text = "Neutro";
            }
            if (value > 3 && value <= 4)
            {
                valorLabel.Text = "De acuerdo";
            }
            if (value > 4 && value <= 5)
            {
                valorLabel.Text = "Muy de acuerdo";
            }
        }
    }
}