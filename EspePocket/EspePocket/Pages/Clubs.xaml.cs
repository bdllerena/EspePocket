using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EspePocket.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Clubs : ContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Clubs"/> class.
        /// </summary>
        public Clubs()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This function adds a new club if it does not exist in the list displayed
        /// To add a club links us with a google forms
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="args">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void Add_Club(object sender, EventArgs args) => Device.OpenUri(new Uri("https://goo.gl/WcgQZu"));

        /// <summary>
        /// This function allows to visualize the existing clubs.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="args">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void See_Ces(object sender, EventArgs args) => Device.OpenUri(new Uri("http://www.csespe.com/"));
    }
}