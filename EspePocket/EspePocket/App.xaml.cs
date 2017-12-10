using EspePocket.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EspePocket.Data;
using Xamarin.Forms.Themes;
using EspePocket.Models;

namespace EspePocket
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class App : Application
    {
        static TodoItemDatabase database;
        public App()
        {
            InitializeComponent();
            Resources = new Xamarin.Forms.Themes.DarkThemeResources();
            MainPage = new NavigationPage(new MainPage());
            //MainPage = new TabAux();

        }

        public void SwitchTheme()
        {
            if (Resources?.GetType() == typeof(LightThemeResources))
            {
                Resources = new Xamarin.Forms.Themes.DarkThemeResources();
                return;
            }
            else
            {
                Resources = new Xamarin.Forms.Themes.LightThemeResources();
                return;
            }
        }
        public static TodoItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new TodoItemDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("TodoSQLite.db3"));
                }
                return database;
            }
        }

        public int ResumeAtTodoId { get; set; }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {

        }
    }
}
