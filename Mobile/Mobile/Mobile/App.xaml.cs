using System;
using Xamarin.Forms;
using Mobile.View;
using Xamarin.Forms.Xaml;
using Parse;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Mobile
{
    public partial class App : Application
    {
        static public bool Login=false;

        public App()
        {
            InitializeComponent();
            ParseClient.Initialize(new ParseClient.Configuration
            {
                ApplicationId = "JNL89UesCt8LOWM0LcHgvyM4Yngxakm9ZKFuTK4J",
                WindowsKey = "MfIzx6plQ2cQxQTcqYUY9eHtsMyQWsedSSeqRb1h",
                Server = "https://parseapi.back4app.com/"
            });
            MainPage = new NavigationPage(new YemekListesi());
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
