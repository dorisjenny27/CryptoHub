namespace CryptoHub.Models.DTOs
{
    public class ApiResponse
    {
        // Represents the data field in the API response, containing a list of cryptos
        public IEnumerable<Crypto> Data { get; set; }
    }

    public class SingleCryptoResponse
    {
        // Represents the data field in the API response, containing a single crypto
        public Crypto Data { get; set; }
    }

}
