using base_graphql_net_core.Entities;
using GraphQL.Instrumentation;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace base_graphql_net_core.GraphQL.GraphQLTypes
{
    public class PostType : ObjectGraphType<Post>
    {
        public PostType()
        {
            Field(x => x.Id, type: typeof(IdGraphType), nullable: false);
            Field(x => x.Title);
            Field(x => x.Description);
            Field(x => x.Author, type: typeof(UserType), nullable: false);
        }
    }
}
