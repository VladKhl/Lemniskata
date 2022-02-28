using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace Lemniskata
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : Xamarin.Forms.TabbedPage
    {
        public StartPage()
        {
            InitializeComponent();
            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            NavigationPage.SetHasBackButton(this, false);
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var action = await DisplayActionSheet("Выберите жанр:", "Закрыть", null, "Ужасы", "Комедия", "Фантастика");
            if (action == "Ужасы")
            {
                homepage.BackgroundImageSource = "scary.png";
            }
            else if (action == "Комедия")
            {
                homepage.BackgroundImageSource = "comedy.png";
            }
            else if (action == "Фантастика")
            {
                homepage.BackgroundImageSource = "fantasy.png";
            }
        }
    }
}