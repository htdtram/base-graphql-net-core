using base_graphql_net_core.GraphQL.GraphQLTypes;
using base_graphql_net_core.Repository;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace base_graphql_net_core.GraphQL.GraphQLQuery
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery(ICategoryRepository categoryRepository)
        {
            Field<ListGraphType<CategoryType>>(
                "categories",
                resolve: context => categoryRepository.GetCategories()
                );
        }
    }
}
