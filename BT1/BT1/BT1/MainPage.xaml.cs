using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BT1
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            imgBackground.Source = Device.RuntimePlatform == Device.Android ? ImageSource.FromFile("img_header_background_1.png") : ImageSource.FromFile("Images/img_header_background_1.png");
            imgLogo.Source = Device.RuntimePlatform == Device.Android ? ImageSource.FromFile("logo_splash.png") : ImageSource.FromFile("Images/logo_splash.png");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new MasterDetailsPage());
        }
    }
}
