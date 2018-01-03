using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EspePocket.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Consultar : ContentPage
    {
        int value = 0;

        public Consultar()
        {
            InitializeComponent();
            Dictionary<string, int> option = new Dictionary<string, int>
            {
                 { "Consultar ID", 1 },
                { "Día de matriculación", 2 }, { "Ver cupos restantes", 3 },
                { "Consultar lista de estudiantes", 4 }, { "Imprimir papeleta de pago", 6 },
                { "Imprimir horario", 7 },{"Consultar lista (Inglés)", 8}

            };
            foreach (string options in option.Keys)
            {
                poison.Items.Add(options);
            }
            poison.SelectedIndexChanged += (sender, args) =>
            {
                if (poison.SelectedIndex != -1)
                {
                    string number = poison.Items[poison.SelectedIndex];
                    value = option[number];
                    switch (value)
                    {
                        case 1:
                            cedula.IsEnabled = true;
                            cedula.IsVisible = true;
                            nrc.IsEnabled = false;
                            nrc.IsVisible = false;
                            id.IsEnabled = false;
                            id.IsVisible = false;
                            break;
                        case 2:
                            cedula.IsEnabled = true;
                            cedula.IsVisible = true;
                            nrc.IsEnabled = false;
                            nrc.IsVisible = false;
                            id.IsEnabled = false;
                            id.IsVisible = false;
                            break;
                        case 3:
                            cedula.IsEnabled = false;
                            cedula.IsVisible = false;
                            nrc.IsEnabled = true;
                            nrc.IsVisible = true;
                            id.IsEnabled = false;
                            id.IsVisible = false;
                            break;
                        case 4:
                            cedula.IsEnabled = false;
                            cedula.IsVisible = false;
                            nrc.IsEnabled = true;
                            nrc.IsVisible = true;
                            id.IsEnabled = false;
                            id.IsVisible = false;
                            break;
                        case 5:
                            cedula.IsEnabled = false;
                            cedula.IsVisible = false;
                            nrc.IsEnabled = true;
                            nrc.IsVisible = true;
                            id.IsEnabled = false;
                            id.IsVisible = false;
                            break;
                        case 6:
                            cedula.IsEnabled = false;
                            cedula.IsVisible = false;
                            nrc.IsEnabled = false;
                            nrc.IsVisible = false;
                            id.IsEnabled = true;
                            id.IsVisible = true;
                            break;
                        case 7:
                            cedula.IsEnabled = true;
                            cedula.IsVisible = true;
                            nrc.IsEnabled = false;
                            nrc.IsVisible = false;
                            id.IsEnabled = false;
                            id.IsVisible = false;
                            break;
                        case 8:
                            cedula.IsEnabled = false;
                            cedula.IsVisible = false;
                            nrc.IsEnabled = false;
                            nrc.IsVisible = false;
                            id.IsEnabled = false;
                            id.IsVisible = false;
                            break;
                    }
                }
                else
                {
                    string number = poison.Items[poison.SelectedIndex];
                    value = option[number];
                    switch (value)
                    {
                        case 1:
                            cedula.IsEnabled = true;
                            cedula.IsVisible = true;
                            nrc.IsEnabled = false;
                            nrc.IsVisible = false;
                            id.IsEnabled = false;
                            id.IsVisible = false;
                            break;
                        case 2:
                            cedula.IsEnabled = true;
                            cedula.IsVisible = true;
                            nrc.IsEnabled = false;
                            nrc.IsVisible = false;
                            id.IsEnabled = false;
                            id.IsVisible = false;
                            break;
                        case 3:
                            cedula.IsEnabled = false;
                            cedula.IsVisible = false;
                            nrc.IsEnabled = true;
                            nrc.IsVisible = true;
                            id.IsEnabled = false;
                            id.IsVisible = false;
                            break;
                        case 4:
                            cedula.IsEnabled = false;
                            cedula.IsVisible = false;
                            nrc.IsEnabled = true;
                            nrc.IsVisible = true;
                            id.IsEnabled = false;
                            id.IsVisible = false;
                            break;
                        case 5:
                            cedula.IsEnabled = false;
                            cedula.IsVisible = false;
                            nrc.IsEnabled = true;
                            nrc.IsVisible = true;
                            id.IsEnabled = false;
                            id.IsVisible = false;
                            break;
                        case 6:
                            cedula.IsEnabled = false;
                            cedula.IsVisible = false;
                            nrc.IsEnabled = false;
                            nrc.IsVisible = false;
                            id.IsEnabled = true;
                            id.IsVisible = true;
                            break;
                        case 7:
                            cedula.IsEnabled = true;
                            cedula.IsVisible = true;
                            nrc.IsEnabled = false;
                            nrc.IsVisible = false;
                            id.IsEnabled = false;
                            id.IsVisible = false;
                            break;
                        case 8:
                            cedula.IsEnabled = false;
                            cedula.IsVisible = false;
                            nrc.IsEnabled = false;
                            nrc.IsVisible = false;
                            id.IsEnabled = false;
                            id.IsVisible = false;
                            break;
                    }
                }
            };
        }
        private void Button_Buscar(object sender, EventArgs e)
        {
            switch (value)
            {
                case 1:
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
                        webviews.Source = "https://pentaho.espe.edu.ec/pentaho/api/repos/%3Apublic%3AReportes%3AMatriculas%3APZSDATOSID_espe.prpt/report?userid=consulta&password=consulta&par_cedula=" + cedula.Text + "&par_institucion=UNIVERSIDAD%20DE%20LAS%20FUERZAS%20ARMADAS%20-%20ESPE&output-target=table%2Fhtml%3Bpage-mode%3Dpage&accepted-page=0&showParameters=true&renderMode=REPORT&htmlProportionalWidth=false+";
                    }
                    break;
                case 2:
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
                    }
                    break;
                case 3:
                    if (string.IsNullOrWhiteSpace(nrc.Text))
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
                        webviews.Source = "http://autoservicio.espe.edu.ec:9065/pls/PROD/bwckschd.p_disp_detail_sched?term_in=201720&crn_in=" + nrc.Text;
                    }
                    break;
                case 4:
                    if (string.IsNullOrWhiteSpace(nrc.Text))
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
                        webviews.Source = "http://pentaho.espe.edu.ec:8080/pentaho/api/repos/%3Apublic%3AReportes%3AEstudiantes%3APZSE0005_Listado_Estudiante_fin.prpt/report?userid=docente&password=docente&htmlProportionalWidth=true&par_nrc=" + nrc.Text + "&par_periodo=201720&par_institucion=UNIVERSIDAD%20DE%20LAS%20FUERZAS%20ARMADAS%20-%20ESPE&output-target=table%2Fhtml%3Bpage-mode%3Dpage&accepted-page=0&showParameters=true&renderMode=REPORT";
                    }
                    break;
                case 5:
                    if (string.IsNullOrWhiteSpace(nrc.Text))
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
                        webviews.Source = "http://pentaho.espe.edu.ec:8080/pentaho/api/repos/%3Apublic%3AReportes%3AEstudiantes%3APZSE0005_Listado_Estudiante_fin.prpt/report?userid=docente&password=docente&par_nrc=" + nrc.Text + "&par_periodo=201706&par_institucion=UNIVERSIDAD%20DE%20LAS%20FUERZAS%20ARMADAS%20-%20ESPE&output-target=table%2Fhtml%3Bpage-mode%3Dpage&accepted-page=0&showParameters=true&renderMode=REPORT&htmlProportionalWidth=false";
                    }
                    break;
                case 6:
                    if (string.IsNullOrWhiteSpace(id.Text))
                    {
                        DisplayAlert("Mensaje", "Necesita ingresar su ID primero", "OK");
                    }
                    else
                    {
                        Indicator.IsVisible = true;
                        LIndicator.IsVisible = true;
                        Indicator.IsRunning = true;
                        webviews.IsVisible = false;
                        Act.IsVisible = true;
                        Device.OpenUri(new Uri("http://pentaho.espe.edu.ec:8080/pentaho/api/repos/%3Ahome%3AUFI%3APAPELETA_MATRICULA_201720.prpt/report?PER=201720&PER_ID=201706&PAR_ID=" + id.Text + "&userid=consulta&password=consulta&output-target=pageable%2Fpdf&accepted-page=-1&showParameters=true&renderMode=REPORT&htmlProportionalWidth=false"));
                    }
                    break;
                case 7:
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
                        Device.OpenUri(new Uri(" http://reportes.espe.edu.ec/pentaho/content/reporting?renderMode=REPORT&PAR_ID=" + cedula.Text + "&solution=BANNER&name=RZSM0010_HorarioAlumno.prpt&output-type=pdf"));
                    }
                    break;
                case 8:
                    Indicator.IsVisible = true;
                    LIndicator.IsVisible = true;
                    Indicator.IsRunning = true;
                    webviews.IsVisible = false;
                    Act.IsVisible = true;
                    webviews.Source = "https://pentaho.espe.edu.ec/pentaho/api/repos/%3Apublic%3AReportes%3AMatriculas%3ARZSP0002_BusquedaNRCES.prpt/viewer?userid=consulta&password=consulta";
                    break;
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