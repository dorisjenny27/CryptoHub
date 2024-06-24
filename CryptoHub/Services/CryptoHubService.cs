using CryptoHub.Helpers;
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

        public async Task<IEnumerable<Crypto>> GetAllCryptos(int page, int perPage)
        {
            // Fetch all cryptos from the CoinCap API
            var response = await _httpClient.GetFromJsonAsync<ApiResponse>("https://api.coincap.io/v2/assets");
            // Paginate the fetched data
            var paginatedData = UtilityMethods.Paginate(response.Data.ToList(), page, perPage);
            return paginatedData; // Return the paginated data
        }

        public async Task<Crypto> GetCryptoById(string id)
        {
            // Fetch a single crypto by ID from the CoinCap API
            var response = await _httpClient.GetFromJsonAsync<SingleCryptoResponse>($"https://api.coincap.io/v2/assets/{id}");
            return response.Data; // Return the fetched crypto
        }

    }
}
