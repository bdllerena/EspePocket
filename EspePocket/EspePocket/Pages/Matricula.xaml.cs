using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EspePocket.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Matricula : ContentPage
    {
        public Matricula()
        {
            InitializeComponent();
        }

        private void Button_Buscar(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cedula.Text))
            {
                DisplayAlert("Mensaje", "Necesita ingresar su cédula primero", "OK");
            }
            else
            {

                Indicator.IsVisible = true;
                LIndicator.IsVisible = true;
                Indicator.IsRunning = true;
                webviews.IsVisible = false;
                Act.IsVisible = true;
                webviews.Source = "https://pentaho.espe.edu.ec/pentaho/api/repos/%3Apublic%3AReportes%3AMatriculas%3ARZSM0002_Fecha_Matriculacion.prpt/report?userid=consulta&password=consulta&PAR_ID=" + cedula.Text + "&PAR_PERIODO=201720&PAR_NIVEL=UG&PAR_INSTITUCION=UNIVERSIDAD%20DE%20LAS%20FUERZAS%20ARMADAS%20-%20ESPE&accepted-page=-1&showParameters=true&renderMode=REPORT";
                /* var browser = new WebView
                 {
                     Source = "https://pentaho.espe.edu.ec/pentaho/api/repos/%3Apublic%3AReportes%3AMatriculas%3ARZSM0002_Fecha_Matriculacion.prpt/report?userid=consulta&password=consulta&PAR_ID=" + cedula.Text + "&PAR_PERIODO=201720&PAR_NIVEL=UG&PAR_INSTITUCION=UNIVERSIDAD%20DE%20LAS%20FUERZAS%20ARMADAS%20-%20ESPE&accepted-page=-1&showParameters=true&renderMode=REPORT",
                     HorizontalOptions = LayoutOptions.Fill,
                     VerticalOptions = LayoutOptions.Fill
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
