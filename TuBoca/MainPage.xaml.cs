using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TuBoca
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {//MainPage muestra los accesos al test y la informacion sobre carreras y universidades.
        public MainPage()
        {
            InitializeComponent();
           
        }

        private async void Test_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

        private async void Carreras_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UniMasCarreras());
        }
    }
}
 