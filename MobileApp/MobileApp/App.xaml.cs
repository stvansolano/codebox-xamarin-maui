using MobileApp.Views;
using Xamarin.Forms;

namespace MobileApp
{
	public partial class App
	{
		public App()
		{
			InitializeComponent();

			MainPage = new ContentPage { Content = new Label { Text = "Hello, World!", VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center } };
		}

		private Page UseTabs()
		{
			TabsPage tabs;
			MainPage = tabs = new TabsPage();

			tabs.Children.Add(new FontsView() { Title = "Font Families" });
			tabs.Children.Add(new FontSample("Lobster") { Title = "Font sample" });

			return tabs;
		}
	}
}
