using Microsoft.AspNetCore.Mvc;
using services;
using models.services;

namespace controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExchangeController : ControllerBase
    {
        private readonly ExchangeRateService _exchangeRateService;

        public ExchangeController(ExchangeRateService exchangeRateService)
        {
            _exchangeRateService = exchangeRateService;
        }

        [HttpGet("rate")]
        public async Task<IActionResult> GetExchangeRate([FromQuery] string baseCurrency = "USD")
        {
            var exchangeRate = await _exchangeRateService.GetExchangeRateAsync(baseCurrency);

            if (exchangeRate == null)
                return NotFound("Unable to retrieve exchange rate data.");

            return Ok(exchangeRate);
        }
    }
}
