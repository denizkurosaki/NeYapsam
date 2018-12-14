
using Mobile.Model;
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

            Items = new ObservableCollection<string>();

            Food.FoodNames.FindAll(e => true).ForEach(e => Items.Add(e));
			
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

        private async void ProfileEvent(object sender, System.EventArgs e)
        {
            Navigation.InsertPageBefore(new LoginPage(),this);
            await Navigation.PopAsync();
        }

        private async void SettingsEvent(object sender, System.EventArgs e)
        {
            Navigation.InsertPageBefore(new Settings(), this);
            await Navigation.PopAsync();
        }
    }
}
