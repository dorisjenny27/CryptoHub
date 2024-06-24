using CryptoHub.Helpers;
using CryptoHub.Models.DTOs;
using CryptoHub.Services;
using CryptoHub.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CryptoHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CryptoHubController : ControllerBase
    {
        private readonly ICryptoHubService _cryptoHubService;

        public CryptoHubController(ICryptoHubService cryptoHubService)
        {
            _cryptoHubService = cryptoHubService;
        }

        [HttpGet("assets")]
        public async Task<IActionResult> GetAllCryptos(int page, int perPage)
        {
            var result = await _cryptoHubService.GetAllCryptos(page, perPage); // Fetch paginated cryptos
            return Ok(result); // Return the result in an HTTP 200 response
        }

        [HttpGet("assets/{id}")]
        public async Task<IActionResult> GetCryptoById(string id)
        {
            var result = await _cryptoHubService.GetCryptoById(id); // Fetch the crypto by ID
            return Ok(result); // Return the result in an HTTP 200 response
        }
    }
}
