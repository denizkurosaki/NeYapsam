using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FoodList : ContentPage
	{
        
		public FoodList ()
		{
			InitializeComponent ();
        }

        private async void SettingsEvent(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Settings());
        }

        private async void LoginEvent(object sender, EventArgs e)
        {
            if(App.Login != null)
                await Navigation.PushAsync(new User());
            else
                await Navigation.PushAsync(new LoginPage());
        }
    }
}