using System;
using Xamarin.Forms;

namespace MobileApp
{
	public partial class App : Application
	{
		public App()
		{
			MainPage = new ContentPage { Content = new Label { Text = "Hello, World!", VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center } };
		}
	}
}