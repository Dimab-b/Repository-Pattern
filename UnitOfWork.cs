using SecondSiteArchitecture.Data.Reposetories;

namespace SecondSiteArchitecture.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public IProductRepository products { get; }
        public IOrderRepository orders { get; }

        public UnitOfWork(AppDbContext context, IProductRepository productRepository, IOrderRepository orderRepository)
        {
            _context = context;
            products = productRepository;
            orders = orderRepository;
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
