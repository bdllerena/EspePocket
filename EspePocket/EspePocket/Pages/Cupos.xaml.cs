using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EspePocket.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cupos : ContentPage
    {
        public Cupos()
        {
            InitializeComponent();
        }
        private void Button_Buscar(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cupos.Text))
            {
                DisplayAlert("Mensaje", "Necesita ingresar su NRC primero", "OK");
            }
            else
            {
                Indicator.IsVisible = true;
                LIndicator.IsVisible = true;
                Indicator.IsRunning = true;
                webviews.IsVisible = false;
                Act.IsVisible = true;
                webviews.Source = "http://autoservicio.espe.edu.ec:9065/pls/PROD/bwckschd.p_disp_detail_sched?term_in=201720&crn_in=" + cupos.Text;
                /*var browser = new WebView
                {

                    Source = "http://autoservicio.espe.edu.ec:9065/pls/PROD/bwckschd.p_disp_detail_sched?term_in=201720&crn_in=" + cupos.Text
                };
                Grids.Children.Add(browser, 0, 1);*/
            }
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