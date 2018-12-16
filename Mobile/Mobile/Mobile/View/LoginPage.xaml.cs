using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
            InitializeComponent ();
		}

        private async void LoginEvent(object sender, System.EventArgs e)
        {
            App.Login = true;
            await Navigation.PopAsync();
        }

        private async void SignInEvent(object sender, EventArgs e)
        {
            Navigation.InsertPageBefore(new SignIn(),this);
            await Navigation.PopAsync();
        }

        private async void SettingsEvent(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Settings());
        }
    }
}