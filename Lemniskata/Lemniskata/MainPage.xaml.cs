using Lemniskata.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lemniskata
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void regbtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistrationPage());
        }

        private void signbtn_Clicked(object sender, EventArgs e)
        {
            var lst = App.Db.GetUser();
            bool state = false;
            foreach (var item in lst)
            {
                if (item.Login == login.Text)
                {
                    if (item.Password == pass.Text)
                    {
                        if (item.Role == "Admin")
                        {
                            DisplayAlert("", "Вы вошли в админ-аккаунт", "Ok");
                            state = true;
                            Navigation.PushAsync(new AdminPage());
                        }
                        else
                        {
                            state = true;
                            Navigation.PushAsync(new StartPage());
                        }
                    }
                }
            }

            if (!state)
                DisplayAlert("", "Неправильный логин или пароль", "Ok");
        }
    }
}
