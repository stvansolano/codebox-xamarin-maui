using System;
using Xamarin.Forms;

namespace MobileApp
{
	public partial class App : Application
	{
		public App()
		{
			/**** #1 */
			MainPage = new ContentPage { Content = new Label { Text = "Hello, World!", VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center } };
		}
	}
}

























/**** #2
			var label = new Label { Text = "Hello, World!" };
			var button = new Button { Text = "Click me!" };

			MainPage = new ContentPage {
				Content = new StackLayout {
					Children = { label, button },
					HorizontalOptions = LayoutOptions.Center,
					VerticalOptions = LayoutOptions.Center,
				}
			};

			var i = 0;
			button.Clicked += (s, e) => { label.Text = "Hello, World! " + (i = i + 1); };				 
*/

/**** #3
var page = new ContentPage
{
	Content = new Label
	{
		Text = "Hello, World!",
		VerticalOptions = LayoutOptions.Center,
		HorizontalOptions = LayoutOptions.Center,
	},
	Title = "Welcome"
};

View titleView = new StackLayout {
	HorizontalOptions = LayoutOptions.Center,
	VerticalOptions = LayoutOptions.Center,
	Children = {
		new Label { Text = page.Title, TextColor = Color.White, }
	},
};
NavigationPage.SetTitleView(page, titleView);

MainPage = new NavigationPage(page) {
	BarBackgroundColor = Color.FromHex("#1976D2"),
	BarTextColor = Color.White,
};*/