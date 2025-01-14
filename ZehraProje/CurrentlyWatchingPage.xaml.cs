using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace ZehraProje
{
    public partial class CurrentlyWatchingPage : ContentPage
    {
        public ObservableCollection<MovieOrShow> CurrentlyWatchingList { get; set; }

        public CurrentlyWatchingPage()
        {
            InitializeComponent();

            CurrentlyWatchingList = new ObservableCollection<MovieOrShow>
            {
                new MovieOrShow { Title = "Dizi 1", Status = "Devam Ediyor" },
                new MovieOrShow { Title = "Film 1", Status = "Bitti" }
            };

            var listView = new ListView();
            listView.ItemsSource = CurrentlyWatchingList;
            listView.ItemTemplate = new DataTemplate(typeof(TextCell));
            listView.ItemTemplate.SetBinding(TextCell.TextProperty, "Title");
            listView.ItemTemplate.SetBinding(TextCell.DetailProperty, "Status");

            Content = new StackLayout
            {
                Padding = 20,
                Spacing = 20,
                Children = { listView }
            };
        }
    }

    public class MovieOrShow
    {
        public string Title { get; set; }
        public string Status { get; set; }
    }
}