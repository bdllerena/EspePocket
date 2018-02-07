using EspePocket.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EspePocket.Pages
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Careers : ContentPage
    {
        /// <summary>
        /// this class contains the methods to the information of the different existing careers.
        /// </summary>
        public Careers()
        {
            InitializeComponent();

        }
        /// <summary>
        /// this method redirect to the systems engineering repository.
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        /// </summary>
        public void metod (object sender, EventArgs args,String uri)
        {
            var browser = new PersonWebView
            {
                Uri = uri,
            };
            Content = browser;

        }
        
}