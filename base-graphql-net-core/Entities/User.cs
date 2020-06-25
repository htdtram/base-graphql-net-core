using base_graphql_net_core.Common.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace base_graphql_net_core.Entities
{
    [Table("User")]
    public class User : BaseEntity
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public Gender Gender { get; set; }

        public Role Role { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
