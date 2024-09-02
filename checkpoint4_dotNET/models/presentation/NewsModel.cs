using models.services;

namespace models.presentation
{
    public class NewsModel
    {
        public List<ArticleModel>? News { get; set; }

        public NewsModel()
        {
            News = new List<ArticleModel>();
        }

        public NewsModel ConvertServiceToPresentation(NewsResponseModel? newsResponseModel)
        {
            if (newsResponseModel == null || newsResponseModel.Articles == null)
                return this;

            foreach (var model in newsResponseModel.Articles)
            {
                if (model != null)
                {
                    var article = new ArticleModel
                    {
                        Title = model.Title,
                        Source = model.Source?.Name,
                        PublishedAt = model.PublishedAt
                    };

                    if (!string.IsNullOrEmpty(article.Title) && !string.IsNullOrEmpty(article.Source))
                    {
                        News?.Add(article);
                    }
                }
            }

            return this;
        }
    }
}