using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace base_graphql_net_core.Entities
{
    [Table("Product")]
    public partial class Product : BaseEntity
    {
        public string Title { get; set; }

        public string Desciption { get; set; }

        public double Price { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
