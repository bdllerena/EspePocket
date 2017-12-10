using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EspePocket.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
        async void Boton_VerClubs(object sender, EventArgs args)
        {
            var stack = Navigation.NavigationStack;
            if (stack[stack.Count - 1].GetType() != typeof(Clubs))
                await Navigation.PushAsync(new Clubs());

        }
        public void Boton_CambiarTema(object sender, EventArgs args)
        {
            ((App)Application.Current).SwitchTheme();
        }
        async void Boton_VerHerramientas(object sender, EventArgs args)
        {
            var stack = Navigation.NavigationStack;
            if (stack[stack.Count - 1].GetType() != typeof(Herramientas))
                await Navigation.PushAsync(new Herramientas());

        }
        async void Boton_VerReglamento(object sender, EventArgs args)
        {
            var stack = Navigation.NavigationStack;
            if (stack[stack.Count - 1].GetType() != typeof(Reglamento))
                await Navigation.PushAsync(new Reglamento());

        }
        async void Boton_VerCarreras(object sender, EventArgs args)
        {
            var stack = Navigation.NavigationStack;
            if (stack[stack.Count - 1].GetType() != typeof(Carreras))
                await Navigation.PushAsync(new Carreras());

        }
        async void Boton_VerMatricula(object sender, EventArgs args)
        {
            var stack = Navigation.NavigationStack;
            if (stack[stack.Count - 1].GetType() != typeof(Consultar))
                await Navigation.PushAsync(new Consultar());

        }
        async void Boton_VerPreguntas(object sender, EventArgs args)
        {
            var stack = Navigation.NavigationStack;
            if (stack[stack.Count - 1].GetType() != typeof(Preguntas))
                await Navigation.PushAsync(new Preguntas());
        }
        async void Boton_VerContacto(object sender, EventArgs args)
        {
            var stack = Navigation.NavigationStack;
            if (stack[stack.Count - 1].GetType() != typeof(Contacto))
                await Navigation.PushAsync(new Contacto());
        }
        public void Boton_VerMiEspe(object sender, EventArgs args) => Device.OpenUri(new Uri("https://miespe.espe.edu.ec"));
        public void Boton_VerApps(object sender, EventArgs args) => Device.OpenUri(new Uri("https://play.google.com/store/apps/developer?id=JBSYS"));
    }
}