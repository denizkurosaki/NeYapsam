using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Mobile.Controller
{
    class Card : StackLayout
    {
        public Card(string imagesource,string label)
        {
            Padding = 20;
            BackgroundColor = Color.LightGray;
            Orientation = StackOrientation.Vertical;
            Children.Add(new Image()
            { Source = imagesource });
            Children.Add(new Label()
            {
                Text = label,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                FontSize = 20
            });
        }
    }
}
