using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BT1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterDetailsPage : MasterDetailPage
	{
        public MasterDetailsPage()
        {
            InitializeComponent();
            imgHome.Source = Device.RuntimePlatform == Device.Android ? ImageSource.FromFile("ic_home.png") : ImageSource.FromFile("Images/ic_home.png");
            imgBook.Source = Device.RuntimePlatform == Device.Android ? ImageSource.FromFile("ic_bed.png") : ImageSource.FromFile("Images/ic_bed.png");
            imgRoom.Source = Device.RuntimePlatform == Device.Android ? ImageSource.FromFile("ic_key.png") : ImageSource.FromFile("Images/ic_key.png");
            imgSugg.Source = Device.RuntimePlatform == Device.Android ? ImageSource.FromFile("ic_beach.png") : ImageSource.FromFile("Images/ic_beach.png");
            imgConc.Source = Device.RuntimePlatform == Device.Android ? ImageSource.FromFile("ic_bot.png") : ImageSource.FromFile("Images/ic_bot.png");
            imgLogout.Source = Device.RuntimePlatform == Device.Android ? ImageSource.FromFile("ic_logout.png") : ImageSource.FromFile("Images/ic_logout.png");
        }
    }
}