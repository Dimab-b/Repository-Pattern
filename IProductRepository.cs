using SecondSiteArchitecture.Models;

namespace SecondSiteArchitecture.Data.Reposetories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
         IQueryable<Product> SearchProduct(string Name);
    }
}
