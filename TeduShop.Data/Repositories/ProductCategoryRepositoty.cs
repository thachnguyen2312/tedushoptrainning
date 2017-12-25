using System.Collections;
using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;
using System.Linq;
namespace TeduShop.Data.Repositories
{
    internal class ProductCategoryRepositoty : RepositoryBase<ProductCategory>, IProductCategoryRepositoty
    {
        public ProductCategoryRepositoty(IDbFactory dbFactory) : base(dbFactory)
        {

        }
        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return DbContext.ProductCategories.Where(x => x.Alias == alias);
        }
    }
    public interface IProductCategoryRepositoty
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }
}