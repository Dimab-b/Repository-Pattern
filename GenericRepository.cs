using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SecondSiteArchitecture.Data.Reposetories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext _context;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            var result = await _context.Set<T>().AsNoTracking().ToListAsync();
            return result;
        }

        public async Task<T> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task Add(T entity)
        {           
            await _context.Set<T>().AddAsync(entity);   
)
        {
            var res =  _context.Set<T>().Find(id);
            if (res != null)
            {
                _context.Set<T>().Remove(res);
            }
           
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }


    }
}
