using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EspePocket.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contact : ContentPage
    {
        /// <summary>
        /// this class open an Url to the contact us.
        /// </summary>
        public Contact()
        {
            InitializeComponent();
        }
        /// <summary>
        /// this method mail to espepocketsoporte@gmail.com to report bugs, Sugestions and Concerns.
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        /// </summary>
        private void Email(object sender, EventArgs e) => Device.OpenUri(new Uri("mailto:espepocketsoporte@gmail.com?subject=Bugs,Sugerencias,Inquietudes&body=Escribe tu mensaje..." + "%0D%0A"));
        /// <summary>
        /// this method redirect to EspePocket Facebook page.
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        /// </summary>
        private void Facebook(object sender, EventArgs e) => Device.OpenUri(new Uri("https://www.facebook.com/EspePocket/"));
        /// <summary>
        /// this method redirect to EspePocket download page.
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        /// </summary>
        private void Rating(object sender, EventArgs e) => Device.OpenUri(new Uri("https://play.google.com/store/apps/details?id=ec.espe.espepockets&hl=es"));
    }
}