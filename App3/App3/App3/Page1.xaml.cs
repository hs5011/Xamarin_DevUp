using App3.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
        LoginView view { get; set; }
		public Page1 ()
		{
			InitializeComponent ();
            BindingContext = view = new LoginView() { user="sondh"};
            
        }
        protected override async void OnAppearing()
        {
            //base.OnAppearing();
            await Task.Delay(3000);
            view.user = "kiet";
            view.pass123 = "123";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}