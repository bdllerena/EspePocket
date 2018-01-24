using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EspePocket.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudentTools : ContentPage
    {
        public StudentTools()
        {
            InitializeComponent();
        }
        private void Email(object sender, EventArgs e) => Device.OpenUri(new Uri("mailto:espepocketsoporte@gmail.com?subject=Bugs,Sugerencias,Inquietudes&body=Escribe tu mensaje..." + "%0D%0A"));
        async void SeeBooks_Button(object sender, EventArgs args)
        {
            var stack = Navigation.NavigationStack;
            if (stack[stack.Count - 1].GetType() != typeof(Books))
                await Navigation.PushAsync(new Books());
        }
        async void SeeNotes_Button(object sender, EventArgs args)
        {
            var stack = Navigation.NavigationStack;
            if (stack[stack.Count - 1].GetType() != typeof(TodoListPage))
                await Navigation.PushAsync(new TodoListPage());
        }
        async void SeeCalculate_Button(object sender, EventArgs args)
        {
            var stack = Navigation.NavigationStack;
            if (stack[stack.Count - 1].GetType() != typeof(Calculate))
                await Navigation.PushAsync(new Calculate());
        }
        async void SeeCalendar_Button(object sender, EventArgs args)
        {
            var stack = Navigation.NavigationStack;
            if (stack[stack.Count - 1].GetType() != typeof(AcademicCalendar))
                await Navigation.PushAsync(new AcademicCalendar());
        }
        async void SeeClubs_Button(object sender, EventArgs args)
        {
            var stack = Navigation.NavigationStack;
            if (stack[stack.Count - 1].GetType() != typeof(Clubs))
                await Navigation.PushAsync(new Clubs());
        }
    }
}