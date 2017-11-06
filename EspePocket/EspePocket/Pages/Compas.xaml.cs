using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EspePocket.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Compas : ContentPage
    {
        public Compas()
        {
            InitializeComponent();
        }
        private void Button_Buscar(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(lista.Text))
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
                webviews.Source = "http://pentaho.espe.edu.ec:8080/pentaho/api/repos/%3Apublic%3AReportes%3AEstudiantes%3APZSE0005_Listado_Estudiante_fin.prpt/report?userid=docente&password=docente&htmlProportionalWidth=true&par_nrc=" + lista.Text + "&par_periodo=201720&par_institucion=UNIVERSIDAD%20DE%20LAS%20FUERZAS%20ARMADAS%20-%20ESPE&output-target=table%2Fhtml%3Bpage-mode%3Dpage&accepted-page=0&showParameters=true&renderMode=REPORT";
                /* var browser = new WebView
                 {
                     Source = "http://pentaho.espe.edu.ec:8080/pentaho/api/repos/%3Apublic%3AReportes%3AEstudiantes%3APZSE0005_Listado_Estudiante_fin.prpt/report?userid=docente&password=docente&htmlProportionalWidth=true&par_nrc=" + lista.Text + "&par_periodo=201720&par_institucion=UNIVERSIDAD%20DE%20LAS%20FUERZAS%20ARMADAS%20-%20ESPE&output-target=table%2Fhtml%3Bpage-mode%3Dpage&accepted-page=0&showParameters=true&renderMode=REPORT",
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