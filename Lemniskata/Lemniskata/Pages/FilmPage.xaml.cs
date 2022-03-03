using Lemniskata.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lemniskata.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FilmPage : ContentPage
    {
        readonly Movie mov;
        public FilmPage(Movie mov)
        {
            InitializeComponent();
            this.mov = mov;
            namefilm.Text = mov.Namefilm;
            imfilm.Source = mov.Image;
            yearlab.Text = mov.Year;
            countrylab.Text = mov.Country;
            janrlab.Text = mov.Genre;
            timelab.Text = mov.Duration;
            decrlab.Text = mov.Description;
            frag1im.Source = mov.Fragment1;
            frag2im.Source = mov.Fragment2;
            frag3im.Source = mov.Fragment3;
            treiler.Source = mov.Treiler;
        }
        public async Task OpenBrowser(Uri uri)
        {
            try
            {
                await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
            catch
            {
                await DisplayAlert(null, "Ошибка", "OK");
            }
        }
        private async void linkbtn_Clicked(object sender, EventArgs e)
        {
            await OpenBrowser(new Uri(mov.Linkfilm));
        }
    }
}