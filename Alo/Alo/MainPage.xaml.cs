using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Alo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Title = "Página Inicial";
        }

        private async void NavegarParaAbout(object sender, EventArgs e)
        {
            var About = new About();

            await Navigation.PushAsync(About);
        }

        private async void AbrirSite(object sender, EventArgs e)
        {
            var web = new Github();

            await Navigation.PushAsync(web);
        }

        private async void Materias(object sender, EventArgs e)
        {
            var materias = new Disciplinas();

            await Navigation.PushAsync(materias);
        }
    }
}
