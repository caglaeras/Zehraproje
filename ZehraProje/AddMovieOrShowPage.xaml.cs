using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using ZehraProje;

namespace ZehraProje
{
    public partial class AddMovieOrShowPage : ContentPage
    {
        public ObservableCollection<MovieOrShow> MovieOrShowList { get; set; }
        public ObservableCollection<MovieOrShow> Watchlist { get; set; }

        public AddMovieOrShowPage(ObservableCollection<MovieOrShow> watchlist)
        {
            InitializeComponent();

            Watchlist = watchlist;
            MovieOrShowList = new ObservableCollection<MovieOrShow>
            {
                new MovieOrShow { Title = "Breaking Bad", Year = 2008, IMDBRating = "9.5 / 10" },
                new MovieOrShow { Title = "Band of Brothers", Year = 2001, IMDBRating = "9.4 / 10" },
                new MovieOrShow { Title = "The Wire", Year = 2002, IMDBRating = "9.3 / 10" },
                new MovieOrShow { Title = "Avatar: The Last Airbender", Year = 2005, IMDBRating = "9.3 / 10" },
                new MovieOrShow { Title = "The Sopranos", Year = 1999, IMDBRating = "9.2 / 10" },
                new MovieOrShow { Title = "Game of Thrones", Year = 2011, IMDBRating = "9.2 / 10" },
                new MovieOrShow { Title = "Esaretin Bedeli (The Shawshank Redemption)", Year = 1994, IMDBRating = "9.3 / 10" },
                new MovieOrShow { Title = "Kara Þövalye (The Dark Knight)", Year = 2008, IMDBRating = "9.0 / 10" },
                new MovieOrShow { Title = "Baba (The Godfather)", Year = 1972, IMDBRating = "9.2 / 10" },
                new MovieOrShow { Title = "Baba 2 (The Godfather Part II)", Year = 1974, IMDBRating = "9.0 / 10" },
                new MovieOrShow { Title = "Dövüþ Kulübü (Fight Club)", Year = 1999, IMDBRating = "8.8 / 10" },
                new MovieOrShow { Title = "Yüzüklerin Efendisi: Kralýn Dönüþü (The Lord of the Rings: The Return of the King)", Year = 2003, IMDBRating = "9.0 / 10" }
            };

        }
        public class MovieOrShow
        {
            public string Title { get; set; }
            public int Year { get; set; }
            public string IMDBRating { get; set; }
        }

        private void AddToWatchlist(MovieOrShow movieOrShow)
        {
            Watchlist.Add(movieOrShow);
        }

        private void OnItemTapped(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is MovieOrShow selectedMovieOrShow)
            {
                // Add the selected item to the Watchlist
                AddToWatchlist(selectedMovieOrShow);

                // Optional: Clear the selection to allow re-selection of the same item
                if (sender is CollectionView collectionView)
                {
                    collectionView.SelectedItem = null;
                }

                // Provide feedback (optional)
                DisplayAlert("Added to Watchlist", $"{selectedMovieOrShow.Title} has been added to your watchlist.", "OK");
            }
        }

    }
}