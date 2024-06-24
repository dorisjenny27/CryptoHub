namespace CryptoHub.Models.DTOs
{
    public class ApiResponse
    {
        public IEnumerable<Crypto> Data { get; set; }
    }

    public class SingleCryptoResponse
    {
        public Crypto Data { get; set; }
    }
}
