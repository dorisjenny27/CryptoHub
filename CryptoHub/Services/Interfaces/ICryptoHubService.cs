using CryptoHub.Models.DTOs;

namespace CryptoHub.Services.Interfaces
{
    public interface ICryptoHubService
    {
        Task<IEnumerable<Crypto>> GetAllCryptos(int page, int perPage);
        Task<Crypto> GetCryptoById(string id);
    }
}
