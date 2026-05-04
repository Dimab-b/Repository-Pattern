using SecondSiteArchitecture.Models;

namespace SecondSiteArchitecture.Data.Reposetories
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
         Task<Order> AddOrder(Order order);
        
            
        
    }
}
