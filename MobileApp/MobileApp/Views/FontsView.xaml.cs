using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileApp.Views
{
	public partial class FontsView
	{
		public ObservableCollection<FontItem> FontFamilies { get; set; } = new ObservableCollection<FontItem>();
		public Command RefreshCommand { get; private set; }
		
		public FontsView()
		{
			RefreshCommand = new Command(async () => await Refresh());
			InitializeComponent();

			IconImageSource = Device.RuntimePlatform == Device.iOS ? "AppIcon" : "icon.png";
		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();

			await Refresh();
		}

		private async Task Refresh()
		{
			FontFamilies.Clear();
			IsBusy = true;

			var taskGroups = await GetFonts().ConfigureAwait(false);

			foreach (var item in taskGroups)
			{
				FontFamilies.Add(item);
			}

			IsBusy = false;
		}

		private async Task<IEnumerable<FontItem>> GetFonts()
		{
			await Task.Delay(3000);

			var fonts = new List<FontItem> {
				new FontItem { FontFamilyName = new Label().FontFamily },
				new FontItem { FontFamilyName = "Lobster" },
				new FontItem { FontFamilyName = "ArchitectsDaughter" },
			};

			return fonts;
		}

		public class FontItem
		{
			public string Icon { get; set; }
			public string FontFamilyName { get; set; }
			public string SampleText { get; set; }

			public FontItem()
			{
				SampleText = FontFamilyName;
			}
		}
	}
}

