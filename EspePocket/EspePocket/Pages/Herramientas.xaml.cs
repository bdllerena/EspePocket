using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EspePocket.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Herramientas : ContentPage
    {
        public Herramientas()
        {
            InitializeComponent();
        }
        public async void Tareas(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new TodoListPage());
        }
        public async void Horarios(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Horarios());
        }
        public async void Armar(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Armar());
        }
        public async void Calcular(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Calcular());
        }
        public async void Docente(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Docente());
        }
        public async void LibrosE(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Librose());
        }
        public async void LibrosF(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Libros());
        }
        public async void Comprobante(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Comprobante());
        }
    }
}