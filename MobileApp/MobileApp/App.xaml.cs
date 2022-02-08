using MobileApp.Views;
using Xamarin.Forms;

namespace MobileApp
{
	public partial class App
	{
		public App()
		{
			InitializeComponent();

			TabsPage tabs;
			MainPage = tabs = new TabsPage();

			tabs.Children.Add(new FontsView() { Title = "Font Families" });
			tabs.Children.Add(new FontSample("Lobster") { Title = "Sample 2" });
		}
	}
}
