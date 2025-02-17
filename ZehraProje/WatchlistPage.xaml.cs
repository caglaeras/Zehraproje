using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace ZehraProje
{
    public partial class WatchlistPage : ContentPage
    {
        public ObservableCollection<MovieOrShow> Watchlist { get; set; }

        public WatchlistPage(ObservableCollection<MovieOrShow> watchlist)
        {
            InitializeComponent();
            Watchlist = watchlist;

            // WatchlistListView'in ItemsSource özelliğini Watchlist koleksiyonuna bağlıyoruz.
            WatchlistListView.ItemsSource = Watchlist;
        }
    }
}