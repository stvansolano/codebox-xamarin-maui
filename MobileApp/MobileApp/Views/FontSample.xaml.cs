using System;
using System.Linq;
using Xamarin.Forms;

namespace MobileApp.Views
{
	public partial class FontSample : ContentPage
	{
		public FontSample(string fontFamily = "Arial")
		{
			InitializeComponent();

			IconImageSource = Device.RuntimePlatform == Device.iOS ? "AppIcon" : "icon.png";

			var allLabels = ParentContainer.Children.OfType<Label>();
			foreach (var label in allLabels)
			{
				label.FontFamily = fontFamily;
			}

			var allSpans = allLabels.SelectMany(label => label?.FormattedText?.Spans ?? Array.Empty<Span>());

			foreach (var span in allSpans)
			{
				span.FontFamily = fontFamily;
			}
		}
	}
}
