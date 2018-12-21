using Mobile.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mobile.Controller
{
    class IngredientCard : StackLayout
    {
        public IngredientCard(Ingredient ingredient,bool add)
        {
            Margin = new Thickness(10);
            BackgroundColor = App.Login.fridge.Contains(ingredient) && add ? Color.Gray : Color.LightGray;
            Orientation = StackOrientation.Vertical;

            Image icon = new Image();
            icon.Source = ImageSource.FromFile(ingredient.Image);

            var iconTap = new TapGestureRecognizer();
            iconTap.Tapped += (object sender, EventArgs e) =>
            {
                if(BackgroundColor == Color.LightGray && add)
                {
                    App.Login.fridge.Add(ingredient);
                    BackgroundColor = Color.Gray;
                    App.update();
                }
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
