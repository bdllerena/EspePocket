using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EspePocket.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MiEspe : ContentPage
    {
        public MiEspe()
        {
            InitializeComponent();
            ToolbarItems.Add(new ToolbarItem("Back", "atras.png", () => { webviews.GoBack(); }));
            ToolbarItems.Add(new ToolbarItem("Forward", "adelante.png", () => { webviews.GoForward(); }));

        }



        public void OnNavigating(object sender, WebNavigatingEventArgs e)
        {
           Indicator.IsVisible = true;
           LIndicator.IsVisible = true;
           Indicator.IsRunning = true;
            webviews.IsVisible = false;
            Act.IsVisible = true;

        }

        public void OnNavigated(object sender, WebNavigatedEventArgs e)
        {

           Indicator.IsVisible = false;
           LIndicator.IsVisible = false;
           Indicator.IsRunning = false;
            webviews.IsVisible = true;
            Act.IsVisible = false;

        }
    }
}