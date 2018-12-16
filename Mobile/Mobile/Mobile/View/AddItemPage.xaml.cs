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
	public partial class AddItemPage : ContentPage
	{
		public AddItemPage ()
		{
			InitializeComponent ();
		}

        private async void AddNewItem(object sender, System.EventArgs e)
        {
            await DisplayAlert("Eklendi", "Listeden bir öğe eklediniz", "Tamam");
        }
        
    }
}