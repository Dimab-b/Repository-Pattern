using SecondSiteArchitecture.Data.Reposetories;

namespace SecondSiteArchitecture.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository products { get; }
        IOrderRepository orders { get; }
        Task CompleteAsync();
    }
}
