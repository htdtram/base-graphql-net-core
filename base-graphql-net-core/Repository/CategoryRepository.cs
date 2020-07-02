using base_graphql_net_core.Entities;
using base_graphql_net_core.Entities.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace base_graphql_net_core.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _db;

        public CategoryRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Category>> GetCategories() => await _db.Categories.Where(x => !x.DelFlag).Include(x => x.Products).ToListAsync();
    }
}
