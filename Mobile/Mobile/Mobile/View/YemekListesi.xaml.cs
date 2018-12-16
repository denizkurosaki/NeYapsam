
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
            if(App.Login)
            {
                await Navigation.PushAsync(new User());
            }
            else
            {
                await Navigation.PushAsync(new LoginPage());
            }
        }

        private async void SettingsEvent(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Settings());
        }
    }
}
