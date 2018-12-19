using Mobile.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mobile.Controller
{
    class IngredientCard : ICard
    {
        public IngredientCard(Ingredient ingredient)
        {
            Margin = new Thickness(10);
            BackgroundColor = Color.LightGray;
            Orientation = StackOrientation.Vertical;

            Image icon = new Image();
            icon.Source = ImageSource.FromFile(ingredient.Image);

            var iconTap = new TapGestureRecognizer();
            iconTap.Tapped += (object sender, EventArgs e) =>
            {
                App.Login.fridge.Add(ingredient);

            };
            icon.GestureRecognizers.Add(iconTap);
            
            Children.Add(icon);

            Children.Add(new Label()
            {
                Text = ingredient.Name,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                FontSize = 20
            });
        }
        
    }
}
