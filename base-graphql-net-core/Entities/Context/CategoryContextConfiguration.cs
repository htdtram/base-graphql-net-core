using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace base_graphql_net_core.Entities.Context
{
    public class CategoryContextConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> modelBuilder)
        {
            modelBuilder.Property(e => e.Name)
                        .IsRequired()
                        .HasMaxLength(100);

            modelBuilder.HasData(
                new Category { Id = 1, Name = "Shirt" },
                new Category { Id = 2, Name = "Hat" },
                new Category { Id = 3, Name = "Bike" }
            );
        }
    }
}
