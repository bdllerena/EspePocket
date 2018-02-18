using EspePocket.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EspePocket.Data;
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
            MainPage = new NavigationPage(new MainPage());
            //MainPage = new TabAux();

        }
        /// <summary>
        /// This method initializate the database based on a file named as TodoSQLite located at Resources folders
        /// </summary>
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
        /// <summary>
        /// this class resumes last item created by id
        /// </summary>
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
