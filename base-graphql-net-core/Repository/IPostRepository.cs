﻿using base_graphql_net_core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace base_graphql_net_core.Repository
{
    public interface IPostRepository
    {
        Task<IEnumerable<Post>> GetPosts();
    }
}
