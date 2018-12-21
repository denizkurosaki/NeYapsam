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
	public partial class SignIn : ContentPage
	{
		public SignIn ()
		{
			InitializeComponent ();
		}

        private async void SignInEvent(object sender, EventArgs e)
        {
            UserInfo user = new UserInfo();
            user.Name = usernameEntry.Text;
            user.Pass = passwordEntry.Text;
            user.Email = addressEntry.Text;
            if(AreDetailsValid(user))
            {
                App.Login = user;
                Acounts.users.Add(user);
                App.update();
                await Navigation.PopToRootAsync();
            }
            else
                await DisplayAlert("Hata", "İsim, şifre veya Email adresi formata uygun değildir", "Tamam");
        }

        private async void SettingsEvent(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Settings());
        }

        bool AreDetailsValid(UserInfo user)
        {
            return (!string.IsNullOrWhiteSpace(user.Name) && !user.Name.Contains(" ") && !user.Pass.Contains(" ") &&
                !string.IsNullOrWhiteSpace(user.Pass) && !string.IsNullOrWhiteSpace(user.Email) && user.Email.Contains("@"));
        }
    }
}