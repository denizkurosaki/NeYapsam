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
        private List<IngredientCard> ingredients = new List<IngredientCard>();

        public User ()
		{
            InitializeComponent();
            App.Login.fridge.ForEach(element => ingredients.Add(new IngredientCard(element,false)));
            Content = new Content(ingredients,true);
        }

        private async void SettingsEvent(object sender, System.EventArgs e)
        {
            if (Device.RuntimePlatform == Device.Android)
                await Navigation.PushAsync(new AddItemPage());
            else
                await Navigation.PushAsync(new Settings()); ;
        }
        
    }
}