using base_graphql_net_core.GraphQL.GraphQLQuery;
using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace base_graphql_net_core.GraphQL.GraphQLSchema
{
    public class AppSchema : Schema
    {

        // the IdependencyResolver which is going to help us resolve our Query, Mutation, or Subscription objects.
        public AppSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<AppQuery>();
        }
    }
}
