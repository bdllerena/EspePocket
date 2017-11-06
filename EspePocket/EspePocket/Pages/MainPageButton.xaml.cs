
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EspePocket.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPageButton : ContentView
    {
        public MainPageButton()
        {
            InitializeComponent();
        }
        public ImageSource Icon
        {
            get { return SwitchboardIcon.Source; }
            set { SwitchboardIcon.Source = value; }
        }

        public string Label
        {
            get { return SwitchboardLabel.Text; }
            set { SwitchboardLabel.Text = value; }
        }
    }
}