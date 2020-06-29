using base_graphql_net_core.Entities;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace base_graphql_net_core.GraphQL.GraphQLTypes
{
    public class UserType : ObjectGraphType<User>
    {
        public UserType()
        {
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Id property from the user object.");
            Field(x => x.Name).Description("Name property from the user object.");
            Field(x => x.Username).Description("Username property from the user object.");
            Field(x => x.Posts, type: typeof(ListGraphType<PostType>));
        }
    }
}
