using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EspePocket.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Horarios : ContentPage
    {
        public Horarios()
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
                Device.OpenUri(new Uri(" http://reportes.espe.edu.ec/pentaho/content/reporting?renderMode=REPORT&PAR_ID=" + cedula.Text + "&solution=BANNER&name=RZSM0010_HorarioAlumno.prpt&output-type=pdf"));
            }
        }
    }
}