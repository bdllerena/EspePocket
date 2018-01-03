using EspePocket.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace EspePocket.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Reglamento : ContentPage
    {
        public PersonaWebView browser;
        public Reglamento()
        {
            Title = "Reglamentos";
            browser = new PersonaWebView
            {
                Uri = "https://goo.gl/wjpD7L",
            };
              Content = browser;  
        }

        
    }
}
