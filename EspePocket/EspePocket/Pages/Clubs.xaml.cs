using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EspePocket.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Clubs : ContentPage
    {
        public Clubs()
        {
            InitializeComponent();
        }
        public void Inscribir_Club(object sender, EventArgs args) => Device.OpenUri(new Uri("https://goo.gl/WcgQZu"));
        public void Ver_Ces(object sender, EventArgs args) => Device.OpenUri(new Uri("http://www.csespe.com/"));
    }
}