using Mobile.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Mobile.Controller
{
    class FoodCard : StackLayout
    {
        public Image img;
        public StackLayout main;

        public FoodCard(Food food)
        {
            Margin = new Thickness(10);
            BackgroundColor = Color.LightGray;
            Orientation = StackOrientation.Horizontal;
            HorizontalOptions = LayoutOptions.FillAndExpand;
            Padding = new Thickness(10);

            Image icon = new Image();
            icon.Source = ImageSource.FromFile(food.Image);
            icon.HeightRequest = 100;
            icon.WidthRequest = 100;


            var iconTap = new TapGestureRecognizer();
            iconTap.Tapped += (object sender, EventArgs e) =>
            {
                //On click action
            };
            icon.GestureRecognizers.Add(iconTap);

            Children.Add(icon);
            Grid.SetColumn(icon, 0);
            img = icon;

            StackLayout main = new StackLayout
            {
                Children =
                {
                    new Label()
                    {
                        Text = food.Label,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        VerticalTextAlignment = TextAlignment.Center,
                        HorizontalTextAlignment = TextAlignment.Center,
                        FontSize = 30
                    },
                    new Label()
                    {
                        Text = food.Calorie,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        VerticalTextAlignment = TextAlignment.Center,
                        HorizontalTextAlignment = TextAlignment.Center,
                        FontSize = 15
                    }
                },
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };
            Grid.SetColumn(main, 1);
            Grid.SetColumnSpan(main, 2);
            Children.Add(main);
            this.main = main;
        }
    }
}
