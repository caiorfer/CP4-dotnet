using models.configuration;
using models.presentation;
using services;

namespace business
{
    public class NewsBusiness
    {
        private readonly ConfigModel _configModel;
        public NewsBusiness() 
        {
            _configModel = ConfigModel.Instance;
        }
        public async Task<NewsModel> GetNewsAsync()
        {
            using var httpClient = new HttpClient();
            var apiKey = _configModel.ApiNewsKey;
            var resultService = await new NewsService(httpClient).GetLatestNewsAsync(apiKey);
            return new NewsModel().ConvertServiceToPresentation(resultService);
        }
    }
}