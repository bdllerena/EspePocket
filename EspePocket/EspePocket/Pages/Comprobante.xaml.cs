using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EspePocket.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Comprobante : ContentPage
    {
        public Comprobante()
        {
            InitializeComponent();
        }
        private void Button_Buscar(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cedula.Text))
            {
                DisplayAlert("Mensaje", "Necesita ingresar su ID primero", "OK");
            }
            else
            {
                Device.OpenUri(new Uri("http://pentaho.espe.edu.ec:8080/pentaho/api/repos/%3Ahome%3AUFI%3APAPELETA_MATRICULA_201720.prpt/report?PER=201720&PER_ID=201706&PAR_ID=" + cedula.Text + "&userid=consulta&password=consulta&output-target=pageable%2Fpdf&accepted-page=-1&showParameters=true&renderMode=REPORT&htmlProportionalWidth=false"));
            }
        }
    }
}