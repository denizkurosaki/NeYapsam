using Mobile.Controller;
using Parse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class User : ContentPage
	{
		public User ()
		{
            InitializeComponent();
            List<IngredientCard> ingredients = new List<IngredientCard>();
            App.Login.fridge.ForEach(element => ingredients.Add(new IngredientCard(element)));
            ScrollView sv = new Content(ingredients);
            
            Content = sv;
            
        }

        private async void SettingsEvent(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AddItemPage());
        }

        private async void AddNewItem(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AddItemPage());
        }
    }
}