using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EspePocket.Pages
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Armar
    {
        public Armar()
        {
            InitializeComponent();
            DisplayAlert("Alerta", "Está herramienta se encuentra en BETA puede no funcionar como es debido considerar esto al usarla.", "OK");
            var browser = new WebView
            {

                Source = "file:///android_asset/Content/horarios.html",
            };

            Content = browser;
        }
    }
}
