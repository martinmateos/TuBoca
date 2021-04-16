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
    public partial class Universidades : ContentPage
    {
        //public ListUniversidad listUniversidad = new ListUniversidad();
        public Universidades()
        {
            InitializeComponent();
            LoadUnis();
            
        }

        
        public List<Universidad> universidads = new List<Universidad> ();
        void LoadUnis()
        {
            string jsonFileName = "Universidades.json";
            var assembly = typeof(Universidades).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.Archivos.{jsonFileName}");
            using (var reader = new System.IO.StreamReader(stream))
            {
                var jsonString = reader.ReadToEnd();
                
                universidads = JsonConvert.DeserializeObject<List<Universidad>>(jsonString);    
            }
            
            CaurouselUni.ItemsSource = universidads;
        }
    }
}