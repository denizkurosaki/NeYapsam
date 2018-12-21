using System;
using Xamarin.Forms;
using Mobile.View;
using Xamarin.Forms.Xaml;
using Parse;
using Mobile.Model;
using System.Collections.Generic;
using Mobile.Controller;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Mobile
{
    public partial class App : Application
    {
        static public UserInfo Login;
        static public FoodList RootPage;

        public App()
        {
            InitializeComponent();
            /*
            ParseClient.Initialize(new ParseClient.Configuration
            {
                ApplicationId = "JNL89UesCt8LOWM0LcHgvyM4Yngxakm9ZKFuTK4J",
                WindowsKey = "MfIzx6plQ2cQxQTcqYUY9eHtsMyQWsedSSeqRb1h",
                Server = "https://parseapi.back4app.com/"
            });
            */
            RootPage = new FoodList();
            update();
            MainPage = new NavigationPage(RootPage);
        }

        static public void update()
        {
            if (App.Login == null)
            {
                List<FoodCard> fd = new List<FoodCard>();
                Foods.foods.ForEach(e => fd.Add(new FoodCard(e)));
                RootPage.Content = new Content(fd);
            }
            else
            {
                List<Food> foods = new List<Food>();
                Foods.foods.ForEach(food => foods.Add(food));
                Foods.foods.ForEach(f => f.ingredients.ForEach( i => 
                {
                    if (foods.Contains(f) && !Login.fridge.Contains(i)) foods.Remove(f);
                }));
                if(foods.Count == 0)
                {
                    RootPage.Content = new StackLayout
                    {
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        Children = { new Image { Source = "starving.png" } },
                    };
                }
                else
                {
                    List<FoodCard> cards = new List<FoodCard>();
                    foods.ForEach(f => cards.Add(new FoodCard(f)));
                    RootPage.Content = new Content(cards);
                }
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
