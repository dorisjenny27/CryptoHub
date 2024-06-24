using CryptoHub.Models.DTOs;

namespace CryptoHub.Services.Interfaces
{
    public interface ICryptoHubService
    {
        Task<IEnumerable<Crypto>> GetAllCryptos();
        Task<Crypto> GetCryptoById(string id);
    }
}
