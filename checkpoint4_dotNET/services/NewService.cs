using models.configuration;
using models.services;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace services
{
    public class ExchangeRateService
    {
        private readonly ConfigModel _configModel = ConfigModel.Instance;
        private readonly HttpClient _httpClient;

        public ExchangeRateService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ExchangeRateResponseModel?> GetExchangeRateAsync(string baseCurrency = "USD")
        {
            var url = $"{_configModel.ApiExchangeRateUrl}/{baseCurrency}/latest";
            var response = await _httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
                return null;

            var jsonResponse = await response.Content.ReadAsStringAsync();
            JsonSerializerOptions jsonSerializerOptions = new()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            };
            var exchangeRateResponse = JsonSerializer.Deserialize<ExchangeRateResponseModel>(jsonResponse, jsonSerializerOptions);

            return exchangeRateResponse;
        }
    }
}