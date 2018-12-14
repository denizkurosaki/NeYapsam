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

        private void Login_Clicked(object sender, EventArgs e)
        {
            //var query = from User in ParseObject.GetQuery("username") where true select User;
            //IEnumerable<ParseObject> results = await query.FindAsync();
        }
    }
}