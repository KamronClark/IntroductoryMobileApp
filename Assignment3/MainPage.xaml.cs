using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Assignment3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Controls the navigation of the app. Navigates to a page corresponding to the list item the was tapped.
        void ListView_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            ListView lv = sender as ListView;
            if ((lv.SelectedItem as string) == "About")
            {
                Navigation.PushAsync(new AboutPage("https://en.wikipedia.org/wiki/Giannis_Antetokounmpo"));
            }
            else if ((lv.SelectedItem as string) == "Favorite Plays")
            {
                Navigation.PushAsync(new FavoritePlaysPage());
            }
            else if ((lv.SelectedItem as string) == "Gallery")
            {
                Navigation.PushAsync(new GalleryPage());
            }
        }
    }
}
