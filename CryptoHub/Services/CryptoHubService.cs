using CryptoHub.Models.DTOs;
using CryptoHub.Services.Interfaces;
using System.Net.Http.Json;

namespace CryptoHub.Services
{
    public class CryptoHubService : ICryptoHubService
    {
        private readonly HttpClient _httpClient;
        private readonly string? _apikey;

        public CryptoHubService(IConfiguration config, HttpClient httpClient)
        {
            _httpClient = httpClient;
            _apikey = config["CurrencyApiSettings:ApiKey"];
        }

        public async Task<IEnumerable<Crypto>> GetAllCryptos()
        {
            var response = await _httpClient.GetFromJsonAsync<ApiResponse>("https://api.coincap.io/v2/assets");
            return response.Data;
        }

        public async Task<Crypto> GetCryptoById(string id)
        {
            var response = await _httpClient.GetFromJsonAsync<SingleCryptoResponse>($"https://api.coincap.io/v2/assets/{id}");
            return response.Data;
        }
    }
}
