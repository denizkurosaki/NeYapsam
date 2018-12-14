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
            NavigationPage.SetHasBackButton(this,true);
			InitializeComponent ();
		}

        private async void LoginEvent(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}