using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace base_graphql_net_core.GraphQL.GraphQLTypes
{
    public class GenderEnum : EnumerationGraphType
    {
        public GenderEnum()
        {
            Name = "Gender";
            Description = "Gender of user";
            AddValue("MALE","Male", 0);
            AddValue("FEMALE","Female", 1);
        }
    }
}
