using System;
using System.Collections.Generic;
using System.Text;
using Mobile.Model;
using Xamarin.Forms;

namespace Mobile.Controller
{
    class Content : ScrollView
    {
        public Content(List<IngredientCard> items)
        {
            Grid content = new Grid
            {
                ColumnDefinitions =
                    {
                        new ColumnDefinition(),new ColumnDefinition()
                    }
                ,
                Padding = 20
            };

            int integer = 0;
            items.ForEach(i =>
            {
                content.Children.Add(i, integer % 2, integer / 2);
                integer++;
            });
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
                HeightRequest = 300,
                Padding = 20
            };

            int integer = 0;
            items.ForEach(i =>
            {
                content.Children.Add(i, 0, integer);
                integer++;
            });
            Content = content;
        }
    }
}
