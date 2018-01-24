using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EspePocket.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contact : ContentPage
    {
        public Contact()
        {
            InitializeComponent();
        }
        private void Email(object sender, EventArgs e) => Device.OpenUri(new Uri("mailto:espepocketsoporte@gmail.com?subject=Bugs,Sugerencias,Inquietudes&body=Escribe tu mensaje..." + "%0D%0A"));
        private void Facebook(object sender, EventArgs e) => Device.OpenUri(new Uri("https://www.facebook.com/EspePocket/"));
        private void Rating(object sender, EventArgs e) => Device.OpenUri(new Uri("https://play.google.com/store/apps/details?id=ec.espe.espepockets&hl=es"));
    }
}