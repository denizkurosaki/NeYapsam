using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using static Xamarin.Forms.Grid;

namespace Mobile.Controller
{
    class Content : ScrollView
    {
        public Content(List<Card> items)
        {
            Grid content = new Grid
            {
                ColumnDefinitions =
                    {
                        new ColumnDefinition(),new ColumnDefinition()
                    }
            };

            int integer = 0;
            items.ForEach(i =>
            {
                content.Children.Add(i, integer % 2, integer / 2);
                integer++;
            });
            Content = content;
        }
        
    }
}
