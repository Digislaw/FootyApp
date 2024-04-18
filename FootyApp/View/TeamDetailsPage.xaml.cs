using FootyApp.ViewModel;

namespace FootyApp.View;

public partial class TeamDetailsPage : ContentPage
{
	public TeamDetailsPage(TeamDetailsViewModel teamDetailsViewModel)
	{
		InitializeComponent();
		BindingContext = teamDetailsViewModel;
	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}