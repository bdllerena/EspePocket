using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EspePocket.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Books : ContentPage
    {
        int value = 0;
        public Books()
        {
            InitializeComponent();
            Dictionary<string, int> option = new Dictionary<string, int>
            {
               { "Biblioteca Matriz", 1 },{ "Biblioteca Extensiones", 2 },{"Biblioteca Digital Ecuador",3},
               { "E-book Central", 4 },{ "E-Libro", 5}, {"SpringerLink",6},
               { "Scopus", 7 }, {"IEEE Xplore", 8}, {"Gale",9},
               {"Repositorios (rraae)",10}, {"Repositorios (Espe)",11}, {"ProQuest",12}


            };

            foreach (string options in option.Keys)
            {
                PickMe.Items.Add(options);
            }
            PickMe.SelectedIndexChanged += (sender, args) =>
            {
                if (PickMe.SelectedIndex != -1)
                {
                    string number = PickMe.Items[PickMe.SelectedIndex];
                    value = option[number];
                }
                else
                {
                    string number = PickMe.Items[PickMe.SelectedIndex];
                    value = option[number];
                }

            };
        }
        private void Button_Search(object sender, EventArgs e)
        {
            switch (value)
            {
                case 1:
                    Indicator.IsVisible = true;
                    LIndicator.IsVisible = true;
                    Indicator.IsRunning = true;
                    WebViews.IsVisible = false;
                    Act.IsVisible = true;
                    WebViews.Source = "http://catalogo.espe.edu.ec/reservacion/index.php";
                    break;
                case 2:
                    Indicator.IsVisible = true;
                    LIndicator.IsVisible = true;
                    Indicator.IsRunning = true;
                    WebViews.IsVisible = false;
                    Act.IsVisible = true;
                    WebViews.Source = "http://webltga.espe.edu.ec:8080/index.php";
                    break;
                case 3:
                    Indicator.IsVisible = true;
                    LIndicator.IsVisible = true;
                    Indicator.IsRunning = true;
                    WebViews.IsVisible = false;
                    Act.IsVisible = true;
                    WebViews.Source = "http://www.bibliotecasdelecuador.com/";
                    break;
                case 4:
                    Indicator.IsVisible = true;
                    LIndicator.IsVisible = true;
                    Indicator.IsRunning = true;
                    WebViews.IsVisible = false;
                    Act.IsVisible = true;
                    WebViews.Source = "http://bd.espe.edu.ec/ebrary.php";
                    break;
                case 5:
                    Indicator.IsVisible = true;
                    LIndicator.IsVisible = true;
                    Indicator.IsRunning = true;
                    WebViews.IsVisible = false;
                    Act.IsVisible = true;
                    WebViews.Source = "http://bd.espe.edu.ec/elibro.php";
                    break;
                case 6:
                    Indicator.IsVisible = true;
                    LIndicator.IsVisible = true;
                    Indicator.IsRunning = true;
                    WebViews.IsVisible = false;
                    Act.IsVisible = true;
                    WebViews.Source = "http://bd.espe.edu.ec/springerlink.php";
                    break;
                case 7:
                    Indicator.IsVisible = true;
                    LIndicator.IsVisible = true;
                    Indicator.IsRunning = true;
                    WebViews.IsVisible = false;
                    Act.IsVisible = true;
                    WebViews.Source = "http://bd.espe.edu.ec/scopus.php";
                    break;
                case 8:
                    Indicator.IsVisible = true;
                    LIndicator.IsVisible = true;
                    Indicator.IsRunning = true;
                    WebViews.IsVisible = false;
                    Act.IsVisible = true;
                    WebViews.Source = "http://bd.espe.edu.ec/ieee.php";
                    break;
                case 9:
                    Indicator.IsVisible = true;
                    LIndicator.IsVisible = true;
                    Indicator.IsRunning = true;
                    WebViews.IsVisible = false;
                    Act.IsVisible = true;
                    WebViews.Source = "http://bd.espe.edu.ec/gale.php";
                    break;
                case 10:
                    Indicator.IsVisible = true;
                    LIndicator.IsVisible = true;
                    Indicator.IsRunning = true;
                    WebViews.IsVisible = false;
                    Act.IsVisible = true;
                    WebViews.Source = "http://rraae.org.ec/";
                    break;
                case 11:
                    Indicator.IsVisible = true;
                    LIndicator.IsVisible = true;
                    Indicator.IsRunning = true;
                    WebViews.IsVisible = false;
                    Act.IsVisible = true;
                    WebViews.Source = "http://repositorio.espe.edu.ec/";
                    break;
                case 12:
                    Indicator.IsVisible = true;
                    LIndicator.IsVisible = true;
                    Indicator.IsRunning = true;
                    WebViews.IsVisible = false;
                    Act.IsVisible = true;
                    WebViews.Source = "http://bd.espe.edu.ec/proquest.php";
                    break;
            }
        }
        public void OnNavigated(object sender, WebNavigatedEventArgs e)
        {
            Indicator.IsVisible = false;
            LIndicator.IsVisible = false;
            Indicator.IsRunning = false;
            WebViews.IsVisible = true;
            Act.IsVisible = false;
        }
    }
}