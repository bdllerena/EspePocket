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
         async void Boton_VerMiEspe(object sender, EventArgs e)
        {
            var stack = Navigation.NavigationStack;
            if (stack[stack.Count - 1].GetType() != typeof(MiEspe))
                await Navigation.PushAsync(new MiEspe());
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
            if (stack[stack.Count - 1].GetType() != typeof(Herramientas))
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
            if (stack[stack.Count - 1].GetType() != typeof(Matriculacion))
                await Navigation.PushAsync(new Matriculacion());
            //this.Navigation.PushAsync(new Matriculacion());

        }
        async void Boton_VerPreguntas(object sender, EventArgs args)
        {
            var stack = Navigation.NavigationStack;
            if (stack[stack.Count - 1].GetType() != typeof(Preguntas))
                await Navigation.PushAsync(new Preguntas());
        }
    }
}