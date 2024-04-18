using CommunityToolkit.Mvvm.ComponentModel;
using FootyApp.Model;

namespace FootyApp.ViewModel
{
    [QueryProperty("Squad", "Squad")]
    [QueryProperty("TeamName", "TeamName")]
    public partial class TeamDetailsViewModel : BaseViewModel
    {
        [ObservableProperty]
        private List<Player> squad;

        [ObservableProperty]
        private string teamName;

        public TeamDetailsViewModel() { }
    }
}
