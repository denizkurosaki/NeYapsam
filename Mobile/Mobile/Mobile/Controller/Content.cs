using System;
using System.Collections.Generic;
using System.Text;
using Mobile.Model;
using Mobile.View;
using Xamarin.Forms;

namespace Mobile.Controller
{
    class Content : ScrollView
    {
        public Content(List<IngredientCard> items,bool add)
        {
            Grid content = new Grid
            {
                ColumnDefinitions =
                    {
                        new ColumnDefinition(),new ColumnDefinition(),
                    }
                ,
                RowDefinitions =
                    {
                        new RowDefinition(),new RowDefinition(),
                    },
                Padding = 20
            };

            int integer = 0;
            items.ForEach(i =>
            {
                content.Children.Add(i, integer % 2, integer / 2);
                integer++;
            });

            Image icon = new Image();
            icon.Source = ImageSource.FromFile("add.png");

            var iconTap = new TapGestureRecognizer();
            iconTap.Tapped += (object sender, EventArgs e) =>
            {
                Navigation.PushAsync(new AddItemPage());
            };
            icon.GestureRecognizers.Add(iconTap);

            if (add)
            {
                content.Children.Add(new StackLayout
                {
                    Children = { icon },
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                }
                , integer % 2, integer / 2);
            }
            Content = content;
        }

        public Content(List<FoodCard> items)
        {
            Grid content = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition(),new RowDefinition(),
                    new RowDefinition(),new RowDefinition(),
                    new RowDefinition(),
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition(),
                    new ColumnDefinition(),
                    new ColumnDefinition(),
                },
                MinimumHeightRequest = 200,
                Padding = 20
            };

            int integer = 0;
            items.ForEach(i =>
            {
                content.Children.Add(i.img, 0,integer);
                content.Children.Add(i.main, 1,3,integer,integer+1);
                integer++;
            });
            Content = content;
        }
    }
}
