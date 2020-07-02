using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace base_graphql_net_core.GraphQL.GraphQLTypes
{
    public class RoleEnum : EnumerationGraphType
    {
        public RoleEnum()
        {
            Name = "Role";
            AddValue("ADMIN", "Admin", 0);
            AddValue("MANAGER", "Manager", 1);
            AddValue("EMPLOYEE", "Employee", 2);
        }
    }
}
