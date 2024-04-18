using FootyApp.ViewModel;

namespace FootyApp;

public partial class MainPage : ContentPage
{
	public MainPage(LeagueViewModel leagueViewModel)
	{
		InitializeComponent();
		BindingContext = leagueViewModel;
	}
}

