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
	public partial class SignIn : ContentPage
	{
		public SignIn ()
		{
			InitializeComponent ();
		}

        private async void SignInEvent(object sender, EventArgs e)
        {
            App.Login = true;
            await Navigation.PopAsync();
        }

        private async void SettingsEvent(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Settings());
        }
    }
}