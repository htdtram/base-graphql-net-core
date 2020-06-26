using base_graphql_net_core.Entities;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace base_graphql_net_core.GraphQL.GraphQLTypes
{
    public class CategoryType : ObjectGraphType<Category>
    {
        public CategoryType()
        {
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Id property from the category object.");
            Field(x => x.Name).Description("Name property from the category object.");
        }
    }
}
