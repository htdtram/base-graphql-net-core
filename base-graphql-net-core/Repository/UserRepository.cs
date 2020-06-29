using base_graphql_net_core.Entities;
using base_graphql_net_core.Entities.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace base_graphql_net_core.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _db;
        public UserRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<User>> GetUsers() => await _db.Users.Include(x => x.Posts).ToListAsync();
    }
}
