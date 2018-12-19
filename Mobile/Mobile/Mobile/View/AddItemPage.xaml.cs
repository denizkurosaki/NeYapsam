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
	public partial class AddItemPage : ContentPage
	{
		public AddItemPage ()
		{
			InitializeComponent ();
            List<IngredientCard> ingredients = new List<IngredientCard>();
            foreach(Ingredient i in Ingredients.ing)
            {
                ingredients.Add(new IngredientCard(i));
            }
            Content = new Content(ingredients);
		}

    }
}