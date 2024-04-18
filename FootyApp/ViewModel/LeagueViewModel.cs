using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FootyApp.Config;
using FootyApp.Model;
using FootyApp.Services;
using FootyApp.View;
using Microsoft.Extensions.Configuration;
using System.Collections.ObjectModel;

namespace FootyApp.ViewModel
{
    public partial class LeagueViewModel : BaseViewModel
    {
        [ObservableProperty]
        private League league;

        public ObservableCollection<Standing> Standings { get; } = new();

        public ObservableCollection<League> Leagues { get; } = new();

        private readonly LeaguesService _leaguesService;
        private readonly PlayersService _playersService;

        public LeagueViewModel(LeaguesService leaguesService, PlayersService playersService,
            IConfiguration config)
        {
            _leaguesService = leaguesService;
            _playersService = playersService;

            var leagues = config.GetRequiredSection("LeaguesConfig").Get<LeaguesConfig>();

            foreach (League league in leagues.AvailableLeagues) 
            {
                Leagues.Add(league);
            }
        }

        [RelayCommand]
        public async Task GetStandingsAsync(League league)
        {
            if (IsBusy) return;

            try
            {

                IsBusy = true;
                var standings = await _leaguesService.GetLeagueStandingsAsync(league.Id);

                if (standings.Count == 0)
                {
                    throw new NullReferenceException("Empty standings data");
                }

                if (Standings.Count > 0)
                {
                    Standings.Clear();
                }

                foreach (Standing standing in standings)
                {
                    Standings.Add(standing);
                }

            }
            catch (Exception)
            {
                await Shell.Current.DisplayAlert("Error", "Unable to load teams", "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }

        [RelayCommand]
        public async Task GoToDetailsAsync(Team team)
        {
            if (team == null) return;

            List<Player> squad = await _playersService.GetSquadAsync(team.Id);

            await Shell.Current.GoToAsync($"{nameof(TeamDetailsPage)}", true,
                new Dictionary<string, object>
                {
                    { "Squad", squad },
                    { "TeamName", team.Name }
                });
        }
    }
}
