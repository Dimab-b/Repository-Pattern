using SecondSiteArchitecture.Models;

namespace SecondSiteArchitecture.Data.Reposetories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        private readonly AppDbContext _context;

        public OrderRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<Order> AddOrder(Order order)
        {
            var result = await _context.orders.AddAsync(order);
            return result.Entity;
        }
    }
}
