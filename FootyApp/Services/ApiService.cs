using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;

namespace FootyApp.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient, IConfiguration config) 
        {
            AppSettings settings = config.GetRequiredSection("AppSettings").Get<AppSettings>();

            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            _httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Key", settings.ApiKey);
            _httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Host", settings.ApiHost);
            _httpClient.BaseAddress = new Uri(settings.ApiUrl);
        }

        /// <summary>
        /// Żądanie GET poprzez wskazany adres (pomijając adres bazowy)
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> GetAsync(string url)
        {
            return await _httpClient.GetAsync(url);
        }

        /// <summary>
        /// Metoda pomocnicza do konwersji odpowiedzi API na model aplikacji
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="response"></param>
        /// <returns></returns>
        public static async Task<List<T>> ResponseToDto<T>(HttpResponseMessage response)
        {
            string jsonString = await response.Content.ReadAsStringAsync();
            string json = JObject.Parse(jsonString)["response"].ToString();
            var dto = JsonConvert.DeserializeObject<List<T>>(json);

            return dto;
        }
    }
}
