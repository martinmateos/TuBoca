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
            realistaLabel.Text = realistaLabel.Text + Test.personalidad.Realista;
            investidoraLabel.Text = investidoraLabel.Text + Test.personalidad.Investigador;
            artisticaLabel.Text = artisticaLabel.Text + Test.personalidad.Artistico;
            socialLabel.Text = socialLabel.Text + Test.personalidad.Social;
            emprendedoraLabel.Text = emprendedoraLabel.Text + Test.personalidad.Emprendedor;
            convencionalLabel.Text = convencionalLabel.Text + Test.personalidad.Convencional;
        }
    }
}