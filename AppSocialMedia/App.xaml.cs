namespace AppSocialMedia;
using AppSocialMedia.Views;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new FlyoutPageMenu();
	}
}
