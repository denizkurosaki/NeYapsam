
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class YemekListesi : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public YemekListesi()
        {
            InitializeComponent();

            Items = new ObservableCollection<string>
            {
                "Item 1",
                "Item 2",
                "Item 3",
                "Item 4",
                "Item 5"
            };
			
			MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Seçildi", "Listeden bir öğe seçildi", "Tamam","İptal");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
