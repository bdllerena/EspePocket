using EspePocket.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace EspePocket.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Rules : ContentPage
    {
        /// <summary>
        /// this class redirect to the ESPE Students Regulations and ESPE License plates Regualtions
        /// </summary>
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
