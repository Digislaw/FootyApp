using FootyApp.View;

namespace FootyApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(TeamDetailsPage), typeof(TeamDetailsPage));
	}
}
