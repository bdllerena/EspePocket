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
        public void Sistemas(object sender, EventArgs args)
        {
            var browser = new PersonWebView
            {
                Uri = "https://goo.gl/RRfE18",
            };
            Content = browser;

        }
        /// <summary>
        /// this method redirect to the Mecatronic enfineering repository.
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        /// </summary>
        public void Mecatronica(object sender, EventArgs args)
        {
            var browser = new PersonWebView
            {
                Uri = "https://goo.gl/5oyVqR"
            };
            Content = browser;

        }
        /// <summary>
        /// this method redirect to the Biological engineering repository.
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        /// </summary>
        public void Bio(object sender, EventArgs args)
        {
            var browser = new PersonWebView
            {
                Uri = "https://goo.gl/VFJC1c"
            };
            Content = browser;

        }
        /// <summary>
        /// this method redirect to the Automotive engineering repository.
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        /// </summary>
        public void Automotriz(object sender, EventArgs args)
        {
            var browser = new PersonWebView
            {
                Uri = "https://goo.gl/qbvDu3"
            };
            Content = browser;

        }
        /// <summary>
        /// this method redirect to the Software engineering repository.
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        /// </summary>
        public void Software(object sender, EventArgs args)
        {
            var browser = new PersonWebView
            {
                Uri = "https://goo.gl/k3c88N"
            };
            Content = browser;

        }
        /// <summary>
        /// this method redirect to the Mecanics engineering repository.
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        /// </summary>
        public void Mecanica(object sender, EventArgs args)
        {
            var browser = new PersonWebView
            {
                Uri = "https://goo.gl/zoSmRY"
            };
            Content = browser;

        }
        /// <summary>
        /// this method redirect to the Civil engineering repository.
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        /// </summary>
        public void Civil(object sender, EventArgs args)
        {
            var browser = new PersonWebView
            {
                Uri = "https://goo.gl/XWgmHb"
            };
            Content = browser;

        }
        /// <summary>
        /// this method redirect to the Geographic engineering repository.
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        /// </summary>
        public void Geo(object sender, EventArgs args)
        {
            var browser = new PersonWebView
            {
                Uri = "https://goo.gl/ufvjkv"
            };
            Content = browser;

        }
        /// <summary>
        /// this method redirect to the Automation and Control repository.
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        /// </summary>
        public void Automatizacion(object sender, EventArgs args)
        {
            var browser = new PersonWebView
            {
                Uri = "https://goo.gl/VjfxRc"
            };
            Content = browser;

        }
        /// <summary>
        /// this method redirect to the Telecommunications repository.
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        /// </summary>
        public void Telecomunicaciones(object sender, EventArgs args)
        {
            var browser = new PersonWebView
            {
                Uri = "https://goo.gl/XVAoti"
            };
            Content = browser;

        }
        /// <summary>
        /// this method redirect to the IASA repository.
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        /// </summary>
        public void Iasa(object sender, EventArgs args)
        {
            var browser = new PersonWebView
            {
                Uri = "https://goo.gl/Vrg2hM"
            };
            Content = browser;

        }
        /// <summary>
        /// this method redirect to the Mecatronic engineering repository.
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        /// </summary>
        public void Mecatronic(object sender, EventArgs args)
        {
            var browser = new PersonWebView
            {
                Uri = "https://goo.gl/J773hS"
            };
            Content = browser;

        }
        /// <summary>
        /// this method redirect to the Electromechanics repository.
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        /// </summary>
        public void Electrom(object sender, EventArgs args)
        {
            var browser = new PersonWebView
            {
                Uri = "https://goo.gl/1BtdeH"
            };
            Content = browser;

        }
        /// <summary>
        /// this method redirect to the Instrumentation Electronics repository.
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        /// </summary>
        public void Tecelec(object sender, EventArgs args)
        {
            var browser = new PersonWebView
            {
                Uri = "https://goo.gl/KMWgqa"
            };
            Content = browser;

        }
        /// <summary>
        /// this method redirect to the Finance and Audit repository.
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        /// </summary>
        public void Finanzas(object sender, EventArgs args)
        {
            var browser = new PersonWebView
            {
                Uri = "https://goo.gl/GgAqYc"
            };
            Content = browser;

        }
        /// <summary>
        /// this method redirect to the Commercial engineering repository.
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        /// </summary>
        public void Comercial(object sender, EventArgs args)
        {
            var browser = new PersonWebView
            {
                Uri = "https://goo.gl/BWQ1vM"
            };
            Content = browser;

        }
        /// <summary>
        /// this method redirect to the Hotel Tourism Management repository.
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        /// </summary>
        public void Turistica(object sender, EventArgs args)
        {
            var browser = new PersonWebView
            {
                Uri = "https://goo.gl/us5ngn"
            };
            Content = browser;

        }
        /// <summary>
        /// this method redirect to the systems Petrochemistry repository.
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        /// </summary>
        public void Petro(object sender, EventArgs args)
        {
            var browser = new PersonWebView
            {
                Uri = "https://goo.gl/KSLv1V"
            };
            Content = browser;

        }
        /// <summary>
        /// this method redirect to the systems Foreign Trade repository.
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        /// </summary>
        public void Ceni(object sender, EventArgs args)
        {
            var browser = new PersonWebView
            {
                Uri = "https://goo.gl/w3VPHj"
            };
            Content = browser;

        }
        /// <summary>
        /// this method redirect to the Initial Education repository.
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        /// </summary>
        public void Educacion(object sender, EventArgs args)
        {
            var browser = new PersonWebView
            {
                Uri = "https://goo.gl/FeSQuH"
            };
            Content = browser;

        }
        /// <summary>
        /// this method redirect to the systems Finance repository.
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        /// </summary>
        public void Finanza(object sender, EventArgs args)
        {
            var browser = new PersonWebView
            {
                Uri = "https://goo.gl/Umz8bn"
            };
            Content = browser;

        }
        /// <summary>
        /// this method redirect to the Physics & Sports repository.
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        /// </summary>
        public void Fisica(object sender, EventArgs args)
        {
            var browser = new PersonWebView
            {
                Uri = "https://goo.gl/kYDWXn"
            };
            Content = browser;

        }
        /// <summary>
        /// this method redirect to the systems Aeronautical Mechanics repository.
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        /// </summary>
        public void Aviones(object sender, EventArgs args)
        {
            var browser = new PersonWebView
            {
                Uri = "https://goo.gl/xGjHMF"
            };
            Content = browser;

        }
        /// <summary>
        /// this method redirect to the systems Aeronautics Motors repository.
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        /// </summary>
        public void Motores(object sender, EventArgs args)
        {
            var browser = new PersonWebView
            {
                Uri = "https://goo.gl/hNu7Ae"
            };
            Content = browser;

        }
        /// <summary>
        /// this method redirect to the Marketing repository.
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        /// </summary>
        public void Merca(object sender, EventArgs args)
        {
            var browser = new PersonWebView
            {
                Uri = "https://goo.gl/qbyh8x"
            };
            Content = browser;

        }
    }
}