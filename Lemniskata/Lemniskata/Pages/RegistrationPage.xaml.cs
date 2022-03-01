using Lemniskata.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lemniskata.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public string impath;
        public RegistrationPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void regbtn_Clicked(object sender, EventArgs e)
        {
            try
            {
                App.Db.SaveUser(new User(surname.Text, name.Text, login.Text, pass.Text, "Admin", impath));
                DisplayAlert("", "Вы успешно зарегистрировались", "Ok");
                Navigation.PushAsync(new MainPage());
            }
            catch
            {
                DisplayAlert("Ошибка", "Введите все данные", "OK");
            }
        }

        private async void addphbtn_Clicked(object sender, EventArgs e)
        {
            var action = await DisplayActionSheet(null, "Отмена", null, "Выбрать фото из галереи", "Использовать камеру");
            if (action == "Выбрать фото из галереи")
            {
                try
                {
                    var photo = await MediaPicker.PickPhotoAsync();
                    impath = photo.FullPath;
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Сообщение об ошибке", ex.Message, "OK");
                }
            }
            else if (action == "Использовать камеру")
            {
                try
                {
                    var photo = await MediaPicker.CapturePhotoAsync(new MediaPickerOptions
                    {
                        Title = $"xamarin.{DateTime.Now.ToString("dd.MM.yyyy_hh.mm.ss")}.png"
                    });
                    var newFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), photo.FileName);
                    using (var stream = await photo.OpenReadAsync())
                    using (var newStream = File.OpenWrite(newFile))
                        await stream.CopyToAsync(newStream);

                    Debug.WriteLine($"Путь фото {photo.FullPath}");
                    impath = photo.FullPath;
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Сообщение об ошибке", ex.Message, "OK");
                }
            }
        }
    }
}