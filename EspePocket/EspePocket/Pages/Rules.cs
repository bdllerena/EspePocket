using EspePocket.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace EspePocket.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Rules : ContentPage
    {
        public Rules()
        {
            Title = "Reglamentos";
            var browser = new PersonWebView
            {
                Uri = "https://goo.gl/wjpD7L",
            };
            Content = browser;
        }
    }
}
