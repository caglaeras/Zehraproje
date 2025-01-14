using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace ZehraProje
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();


            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Spacing = 20,
                Children =
                {
                    new Label
                    {
                        Text = "Welcome to Dizi/Film Tracker!",
                        FontSize = 24,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.Center
                    },

                    new Button
                    {
                        Text = "\u2190 Þu Anda Ýzlediklerim",
                        FontSize = 18,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        VerticalOptions = LayoutOptions.Center,
                        Command = new Command(() => NavigateToCurrentlyWatching())
                    },

                    new Button
                    {
                        Text = "Ýzlemek Ýstediklerim \u2192",
                        FontSize = 18,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        VerticalOptions = LayoutOptions.Center,
                        Command = new Command(() => NavigateToWatchlist())
                    }
                }
            };
        }

        private async void NavigateToCurrentlyWatching()
        {
            await Navigation.PushAsync(new CurrentlyWatchingPage());
        }

        private async void NavigateToWatchlist()
        {
            ObservableCollection<MovieOrShow> watchlist = new ObservableCollection<MovieOrShow>();
            WatchlistPage watchlistPage = new WatchlistPage(watchlist);
            await Navigation.PushAsync(watchlistPage);
        }

    }
}