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
       // private readonly IHttpService _httpService;
        private readonly IConfiguration _config;
        private readonly ICryptoHubService _cryptoHubService;

        public CryptoHubController(IConfiguration config, ICryptoHubService cryptoHubService)
        {
            _config = config;
            _cryptoHubService = cryptoHubService;
        }

        [HttpGet("assets")]
        public async Task<IActionResult> GetAllCryptos()
        {
            var result = await _cryptoHubService.GetAllCryptos();
            return Ok(result);
        }

        [HttpGet("assets/{id}")]
        public async Task<IActionResult> GetCryptoById(string id)
        {
            var result = await _cryptoHubService.GetCryptoById(id);
            return Ok(result);
        }
    }
}
