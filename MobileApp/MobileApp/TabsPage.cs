namespace MobileApp
{
	using System;
	using Xamarin.Forms;
	using AndroidSpecific = Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

	public class TabsPage : TabbedPage
	{
		public TabsPage()
		{
			/*
			 <TabbedPage
				x:Class="MobileApp.TabsPage"
				xmlns="http://xamarin.com/schemas/2014/forms"
				xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
				xmlns:android="clr-namespace:Xamarin.Forms.PlatformConfiguration.AndroidSpecific;assembly=Xamarin.Forms.Core"
				android:TabbedPage.ToolbarPlacement="Bottom"
				BarBackgroundColor="White"
				BarTextColor="Black" 
			 */
			AndroidSpecific.TabbedPage.SetToolbarPlacement(this, AndroidSpecific.ToolbarPlacement.Bottom);
		}
	}
}
