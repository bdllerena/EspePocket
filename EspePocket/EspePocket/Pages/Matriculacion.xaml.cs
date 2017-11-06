using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EspePocket.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Matriculacion : ContentPage
    {
        public Matriculacion()
        {
            InitializeComponent();
        }
        public async void Materia(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Materias());
        }
        public async void Cupos(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Cupos());
        }

        public async void Calendario(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Calendario());
        }
        public async void BuscaID(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new BuscaID());
        }

        public async void Listas(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Compas());
        }
        public async void ListasI(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new CompasI());
        }
        public async void Matricula(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Matricula());
        }

    }
}