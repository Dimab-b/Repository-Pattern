using Microsoft.EntityFrameworkCore;
using SecondSiteArchitecture.Models;
using SecondSiteArchitecture.Data;

namespace SecondSiteArchitecture.Data.Reposetories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }


        public IQueryable<Product> SearchProduct(string name)
        {
            return _context.products.AsQueryable().Where(p => p.Name.Contains(name));
        }
    }
}
