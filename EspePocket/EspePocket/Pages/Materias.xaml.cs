using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EspePocket.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Materias : ContentPage
	{
		public Materias ()
		{
			InitializeComponent ();
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