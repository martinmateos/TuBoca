using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuBoca.Modelos;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TuBoca.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resultado : ContentPage
    {
        public Resultado()
        {
            InitializeComponent();
            MostrarResultados();
        }
        //Test test = new Test();
        void MostrarResultados()
        {
            
        }
    }
}