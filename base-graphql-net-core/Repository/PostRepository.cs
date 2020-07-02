using base_graphql_net_core.Entities;
using base_graphql_net_core.Entities.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace base_graphql_net_core.Repository
{
    public class PostRepository : IPostRepository
    {
        public readonly DataContext _db;
        public PostRepository(DataContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Post>> GetPosts()
        {
            return await _db.Posts.Where(x => !x.DelFlag).Include(x => x.Author).ToListAsync();
        }
    }
}
