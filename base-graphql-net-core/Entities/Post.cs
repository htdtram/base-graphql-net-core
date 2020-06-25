using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace base_graphql_net_core.Entities
{
    [Table("Post")]
    public class Post : BaseEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public int UserId { get; set; }

        public User Author { get; set; }
    }
}
