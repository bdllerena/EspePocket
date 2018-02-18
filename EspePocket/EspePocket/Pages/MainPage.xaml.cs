using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EspePocket.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        /// <summary>
        /// Constructor that initialize the components of the Main Page class
        /// </summary>
        public MainPage()
        {
            InitializeComponent();

        }
        /// <summary>
        /// an async method that create an instance of the <see cref="Clubs"/> class
        /// </summary>
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        async void SeeClubs_Button(object sender, EventArgs args)
        {
            var stack = Navigation.NavigationStack;
            if (stack[stack.Count - 1].GetType() != typeof(Clubs))
                await Navigation.PushAsync(new Clubs());

        }
        /// <summary>
        /// an async method that create an instance of the <see cref="StudentTools"/> class
        /// </summary>
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        async void SeeStudentTools_Button(object sender, EventArgs args)
        {
            var stack = Navigation.NavigationStack;
            if (stack[stack.Count - 1].GetType() != typeof(StudentTools))
                await Navigation.PushAsync(new StudentTools());

        }
        /// <summary>
        /// an async method that create an instance of the <see cref="Rules"/> class
        /// </summary>
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        async void SeeRules_Button(object sender, EventArgs args)
        {
            var stack = Navigation.NavigationStack;
            if (stack[stack.Count - 1].GetType() != typeof(Rules))
                await Navigation.PushAsync(new Rules());

        }
        /// <summary>
        /// an async method that create an instance of the <see cref="Careers"/> class
        /// </summary>
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        async void SeeCareers_Button(object sender, EventArgs args)
        {
            var stack = Navigation.NavigationStack;
            if (stack[stack.Count - 1].GetType() != typeof(Careers))
                await Navigation.PushAsync(new Careers());

        }
        /// <summary>
        /// an async method that create an instance of the <see cref="Consult"/> class
        /// </summary>
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        async void SeeEnrollment_Button(object sender, EventArgs args)
        {
            var stack = Navigation.NavigationStack;
            if (stack[stack.Count - 1].GetType() != typeof(Consult))
                await Navigation.PushAsync(new Consult());

        }
        /// <summary>
        /// an async method that create an instance of the <see cref="FAQ"/> class
        /// </summary>
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        async void SeeFAQ_Button(object sender, EventArgs args)
        {
            var stack = Navigation.NavigationStack;
            if (stack[stack.Count - 1].GetType() != typeof(FAQ))
                await Navigation.PushAsync(new FAQ());
        }
        /// <summary>
        /// an async method that create an instance of the <see cref="Contact"/> class
        /// </summary>
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        async void SeeContact_Button(object sender, EventArgs args)
        {
            var stack = Navigation.NavigationStack;
            if (stack[stack.Count - 1].GetType() != typeof(Contact))
                await Navigation.PushAsync(new Contact());
        }
        /// <summary>
        /// To connect to the "miespe" site
        /// </summary>
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        public void SeeMiEspe_Button(object sender, EventArgs args) => Device.OpenUri(new Uri("https://miespe.espe.edu.ec"));
        /// <summary>
        /// To look for others apps in the "google play" site
        /// </summary>
        /// <param name="sender">contains a reference to the control/object that raised the event</param>
        /// <param name="args">is the base class to contain the events thrown by the control</param>
        public void SeeOtherApps_Button(object sender, EventArgs args) => Device.OpenUri(new Uri("https://play.google.com/store/apps/developer?id=JBSYS"));
    }
}