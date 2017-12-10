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
        private void Email(object sender, EventArgs e) => Device.OpenUri(new Uri("mailto:espepocketsoporte@gmail.com?subject=Bugs,Sugerencias,Inquietudes&body=Escribe tu mensaje..." + "%0D%0A"));
        async void Boton_VerLibros(object sender, EventArgs args)
        {
            var stack = Navigation.NavigationStack;
            if (stack[stack.Count - 1].GetType() != typeof(Libros))
                await Navigation.PushAsync(new Libros());
        }
        async void Boton_VerNotas(object sender, EventArgs args)
        {
            var stack = Navigation.NavigationStack;
            if (stack[stack.Count - 1].GetType() != typeof(TodoListPage))
                await Navigation.PushAsync(new TodoListPage());
        }
        async void Boton_VerCalculadora(object sender, EventArgs args)
        {
            var stack = Navigation.NavigationStack;
            if (stack[stack.Count - 1].GetType() != typeof(Calcular))
                await Navigation.PushAsync(new Calcular());
        }
        async void Boton_VerCalendario(object sender, EventArgs args)
        {
            var stack = Navigation.NavigationStack;
            if (stack[stack.Count - 1].GetType() != typeof(Calendario))
                await Navigation.PushAsync(new Calendario());
        }
        async void Boton_VerClubs(object sender, EventArgs args)
        {
            var stack = Navigation.NavigationStack;
            if (stack[stack.Count - 1].GetType() != typeof(Clubs))
                await Navigation.PushAsync(new Clubs());
        }
    }
}