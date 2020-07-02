using base_graphql_net_core.Common;
using base_graphql_net_core.Common.Enum;
using base_graphql_net_core.Entities;
using base_graphql_net_core.Entities.Context;
using base_graphql_net_core.GraphQL.GraphQLTypes;
using GraphQL;
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

        public async Task<User> CreateUser(User user)
        {
            user.Password = Security.GetSimpleMD5(user.Password);
            await _db.AddAsync(user);
            await _db.SaveChangesAsync();
            return user ;
        }

        public async Task<User> GetUserById(int id) => await _db.Users.Include(x => x.Posts).FirstOrDefaultAsync(x => !x.DelFlag && x.Id == id); 

        public async Task<IEnumerable<User>> GetUsers() => await _db.Users.Include(x => x.Posts).Where(x => !x.DelFlag).ToListAsync();

        public async Task<User> UpdateUser(int userId, string name)
        {
            var user = _db.Users.Include(x => x.Posts).FirstOrDefault(x => !x.DelFlag && x.Id == userId);
            if(user == null)
            {
                throw new ExecutionError("Couldn't find user");
            }
            user.Name = name;
            await _db.SaveChangesAsync();
            return user;
        }

        public async Task<string> DeleteUser(int userId)
        {
            var user = _db.Users.Include(x => x.Posts).FirstOrDefault(x => !x.DelFlag && x.Id == userId);
            if (user == null)
            {
                throw new ExecutionError("Couldn't find user");
            }
            user.DelFlag = true;
            await _db.SaveChangesAsync();
            return $"The user with the id: {userId} has been successfully deleted from db.";
        }
    }
}
