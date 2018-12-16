using Parse;
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
	public partial class User : ContentPage
	{
		public User ()
		{
			InitializeComponent ();
		}

        private async void SettingsEvent(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Settings());
        }

        private async void AddNewItem(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AddItemPage());
        }
    }
}