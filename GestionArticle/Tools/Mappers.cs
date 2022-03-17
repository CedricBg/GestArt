using GestionArticle.Models;

namespace GestionArticle.Tools
{
    public static class Mappers
    {
        public static Article ToData(this ArticleForm f)
        {
            return new Article
            {
                Name = f.Name,
                EAN13 = f.EAN13,
                Price = f.Price,
                Description = f.Description
            };
        }

        public static ArticleForm ToView(this Article f)
        {
            return new ArticleForm
            {
                Name = f.Name,
                EAN13 = f.EAN13,
                Price = f.Price,
                Description = f.Description
            };
        }
    }
}
