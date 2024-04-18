using CommunityToolkit.Mvvm.Input;
using FootyApp.Model;
using FootyApp.Model.Dto;

namespace FootyApp.Services
{
    public partial class LeaguesService
    {
        private readonly ApiService _api;

        public LeaguesService(ApiService apiService)
        {
            _api = apiService;
        }

        [RelayCommand]
        public async Task<List<Standing>> GetLeagueStandingsAsync(int leagueId)
        {
            List<Standing> standings = new();

            try
            {
                var response = await _api.GetAsync($"/standings?league={leagueId}&season=2022");

                if (response.IsSuccessStatusCode)
                {
                    var dto = await ApiService.ResponseToDto<StandingsDto>(response);
                    var league = dto[0].League;
                    standings = league.Standings[0];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while loading league standings: {ex.Message}");
            }

            return standings;
        }
    }
}
