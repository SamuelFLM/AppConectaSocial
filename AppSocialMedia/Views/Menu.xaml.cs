using AppSocialMedia.Views.Media;

namespace AppSocialMedia.Views;

public partial class Menu : ContentPage
{
	public Menu()
	{
        InitializeComponent();
	}

    private void OnButtonClickedLinkedin(object sender, EventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Linkedin());
    }

    private void OnButtonClickedGithub(object sender, EventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Github());
    }

    private void OnButtonClickedHome(object sender, EventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Home());
    }

    private void OnButtonClickedYoutube(object sender, EventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Youtube());
    }

    private void OnButtonClickedFacebook(object sender, EventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Facebook());
    }

    private void OnButtonClickedInstagram(object sender, EventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Instagram());
    }

    private void OnButtonClickedReddit(object sender, EventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Reddit());
    }

    private void OnButtonClickedStackOverFlow(object sender, EventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new StackOverFlow());
    }

    private void OnButtonClickedTiktok(object sender, EventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new Tiktok());
    }
}