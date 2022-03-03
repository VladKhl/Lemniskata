using Lemniskata.Models;
using Lemniskata.Pages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace Lemniskata
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : Xamarin.Forms.TabbedPage
    {
        public string profim;
        readonly User user;
        public StartPage(User user)
        {
            this.user = user;
            InitializeComponent();
            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            NavigationPage.SetHasNavigationBar(this, false);
            FilmsLstView.ItemsSource = App.Db.GetMovie();
            surnamelab.Text = user.Surname;
            namelab.Text = user.Name;
            login.Text = user.Login;
            pass.Text = user.Password;
            profph.Source = user.Image;
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var action = await DisplayActionSheet("Выберите жанр:", "Закрыть", null, "Ужасы", "Комедия", "Фантастика");
            List<Movie> lst = new List<Movie>();
            if (action == "Ужасы")
            {
                homepage.BackgroundImageSource = "scary.png";
                FilmsLstView.ItemsSource = null;
                foreach (var item in App.Db.GetMovie())
                {
                    if(item.Genre == "Ужасы")
                    {
                        lst.Add(item);
                    }
                }
                FilmsLstView.ItemsSource = lst;
            }
            else if (action == "Комедия")
            {
                homepage.BackgroundImageSource = "comedy.png";
                FilmsLstView.ItemsSource = null;
                foreach (var item in App.Db.GetMovie())
                {
                    if (item.Genre == "Комедия")
                    {
                        lst.Add(item);
                    }
                }
                FilmsLstView.ItemsSource = lst;
            }
            else if (action == "Фантастика")
            {
                homepage.BackgroundImageSource = "fantasy.png";
                FilmsLstView.ItemsSource = null;
                foreach (var item in App.Db.GetMovie())
                {
                    if (item.Genre == "Фантастика")
                    {
                        lst.Add(item);
                    }
                }
                FilmsLstView.ItemsSource = lst;
            }
        }

        private /*async*/ void searchbtn_SearchButtonPressed(object sender, EventArgs e)
        {
            List<Movie> list = new List<Movie>();
            searchLstView.ItemsSource = null;
            foreach (var item in App.Db.GetMovie())
            {
                if (item.Namefilm == searchbtn.Text)
                {
                    //try
                    //{
                    //    var photo = await MediaPicker.PickPhotoAsync();
                    //    item.Fragment1 = photo.FullPath;
                    //    var photo2 = await MediaPicker.PickPhotoAsync();
                    //    item.Fragment2 = photo2.FullPath;
                    //    var photo3 = await MediaPicker.PickPhotoAsync();
                    //    item.Fragment3 = photo3.FullPath;
                    //    App.db.SaveMov(item);
                    //}
                    //catch (Exception ex)
                    //{
                    //    await DisplayAlert("Сообщение об ошибке", ex.Message, "OK");
                    //}
                    list.Add(item);
                }
                searchLstView.ItemsSource = list;
            }
        }

        private void FilmsLstView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new FilmPage((Movie)e.Item));
        }
    }
}