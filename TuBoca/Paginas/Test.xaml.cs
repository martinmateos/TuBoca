using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TuBoca.Modelos;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;

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

        int idEnunciado = 1;//variable para identificar el enunciado con ID 
        void LoadEnunciado ()
        {
            string jsonFileName = "Enunciados.json";
            ListEnunciado ObjListEnunciado = new ListEnunciado();
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

        }

        /* */
        private void btnBack_Clicked(object sender, EventArgs e)
        {

        }
    }
}