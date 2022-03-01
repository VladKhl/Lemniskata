using Lemniskata.db;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


[assembly: ExportFont("RedHatText-Regular.ttf", Alias = "RedHatText.ttf")]
[assembly: ExportFont("MaterialIcons-Regular.ttf", Alias = "MaterialIconsFont")]
namespace Lemniskata
{
    public partial class App : Application
    {
        public const string DB_NAME = "films.db";
        public static CRUDOperation db;
        public static CRUDOperation Db
        {
            get
            {
                if (db == null)
                {
                    db = new CRUDOperation(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DB_NAME));
                }
                return db;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

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
