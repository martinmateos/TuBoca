using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TuBoca
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private async void Continuar_Test_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());//Page2 es la pagina donde se interactua con el test.
        }
    }
}