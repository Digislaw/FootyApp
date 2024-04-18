using CommunityToolkit.Mvvm.Input;
using FootyApp.Model;
using FootyApp.Model.Dto;

namespace FootyApp.Services
{
    public partial class PlayersService
    {
        private readonly ApiService _api;

        public PlayersService(ApiService apiService)
        {
            _api = apiService;
        }

        [RelayCommand]
        public async Task<List<Player>> GetSquadAsync(int teamId)
        {
            List<Player> players = new();

            try
            {
                var response = await _api.GetAsync($"/players/squads?team={teamId}");

                if (response.IsSuccessStatusCode)
                {
                    var dto = await ApiService.ResponseToDto<SquadDto>(response);
                    players = dto[0].Players;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while loading squad: {ex.Message}");
            }

            return players;
        }
    }
}
