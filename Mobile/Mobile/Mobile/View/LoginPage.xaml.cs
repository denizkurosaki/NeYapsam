using Mobile.Model;
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
            if(Acounts.users.Any(u => u.Name == usernameEntry.Text && u.Pass == passwordEntry.Text))
            {
                App.Login = Acounts.users.Find(u => u.Name == usernameEntry.Text && u.Pass == passwordEntry.Text);
                App.update();
                await Navigation.PopAsync();
            }
                
            else
                await DisplayAlert("Hata", "İsim veya şifre hatalı", "Tamam");
        }

        private async void SignInEvent(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignIn());
        }

        private async void SettingsEvent(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Settings());
        }
    }
}