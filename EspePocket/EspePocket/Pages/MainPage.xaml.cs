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
        async void SeeClubs_Button(object sender, EventArgs args)
        {
            var stack = Navigation.NavigationStack;
            if (stack[stack.Count - 1].GetType() != typeof(Clubs))
                await Navigation.PushAsync(new Clubs());

        }
        async void SeeStudentTools_Button(object sender, EventArgs args)
        {
            var stack = Navigation.NavigationStack;
            if (stack[stack.Count - 1].GetType() != typeof(StudentTools))
                await Navigation.PushAsync(new StudentTools());

        }
        async void SeeRules_Button(object sender, EventArgs args)
        {
            var stack = Navigation.NavigationStack;
            if (stack[stack.Count - 1].GetType() != typeof(Rules))
                await Navigation.PushAsync(new Rules());

        }
        async void SeeCareers_Button(object sender, EventArgs args)
        {
            var stack = Navigation.NavigationStack;
            if (stack[stack.Count - 1].GetType() != typeof(Careers))
                await Navigation.PushAsync(new Careers());

        }
        async void SeeEnrollment_Button(object sender, EventArgs args)
        {
            var stack = Navigation.NavigationStack;
            if (stack[stack.Count - 1].GetType() != typeof(Consult))
                await Navigation.PushAsync(new Consult());

        }
        async void SeeFAQ_Button(object sender, EventArgs args)
        {
            var stack = Navigation.NavigationStack;
            if (stack[stack.Count - 1].GetType() != typeof(FAQ))
                await Navigation.PushAsync(new FAQ());
        }
        async void SeeContact_Button(object sender, EventArgs args)
        {
            var stack = Navigation.NavigationStack;
            if (stack[stack.Count - 1].GetType() != typeof(Contact))
                await Navigation.PushAsync(new Contact());
        }
        public void SeeMiEspe_Button(object sender, EventArgs args) => Device.OpenUri(new Uri("https://miespe.espe.edu.ec"));
        public void SeeOtherApps_Button(object sender, EventArgs args) => Device.OpenUri(new Uri("https://play.google.com/store/apps/developer?id=JBSYS"));
    }
}