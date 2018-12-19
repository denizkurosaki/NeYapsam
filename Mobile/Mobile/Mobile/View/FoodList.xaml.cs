using Mobile.Controller;
using Mobile.Model;
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
	public partial class FoodList : ContentPage
	{
		public FoodList ()
		{
			InitializeComponent ();
            if(App.Login == null)
            {
                List<FoodCard> fd = new List<FoodCard>();
                Foods.foods.ForEach(e => fd.Add(new FoodCard(e)));
                Content = new Content(fd);
            }
            else
            {
                Content = new StackLayout
                {
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    Children = { new Image { Source = "starving.png" } },
                              
                };
            }
            /*
            Content = new Content(new List<FoodCard>
            {
                new FoodCard(new Food{ Label = "Havuç Salatası" , Image = "carrot.png", Calorie = "200 cl" }),
                new FoodCard(new Food{ Label = "Havuç Salatası" , Image = "carrot.png", Calorie = "200 cl" }),
                new FoodCard(new Food{ Label = "Havuç Salatası" , Image = "carrot.png", Calorie = "200 cl" }),
                new FoodCard(new Food{ Label = "Havuç Salatası" , Image = "carrot.png", Calorie = "200 cl" }),
            });
            */
            /*
            Content = new Content(new List<IngredientCard>
            {
                new IngredientCard("carrot.png","Havuç"),
                new IngredientCard("carrot.png","Havuç"),
                new IngredientCard("carrot.png","Havuç"),
                new IngredientCard("carrot.png","Havuç"),
                new IngredientCard("carrot.png","Havuç"),
                new IngredientCard("carrot.png","Havuç"),
            });
            */
		}

        private async void SettingsEvent(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Settings());
        }

        private async void LoginEvent(object sender, EventArgs e)
        {
            if(App.Login != null)
                await Navigation.PushAsync(new User());
            else
                await Navigation.PushAsync(new LoginPage());
        }
    }
}