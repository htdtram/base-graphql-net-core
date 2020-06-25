using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace base_graphql_net_core.Entities.Context
{
    public class ProductContextConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> modelBuilder)
        {
            modelBuilder.HasOne<Category>(s => s.Category)
                        .WithMany(g => g.Products)
                        .HasForeignKey(s => s.CategoryId);

            modelBuilder.Property(e => e.Desciption)
                        .HasMaxLength(500);

            modelBuilder.Property(e => e.Title)
                        .IsRequired()
                        .HasMaxLength(100);

            modelBuilder.Property(e => e.Price)
                        .IsRequired();

            modelBuilder.HasData(
                new Product { Id = 1, Title = "Product 01", Desciption = "Desciption 01", Price = 10.00, CategoryId = 1 },
                new Product { Id = 2, Title = "Product 02", Desciption = "Desciption 02", Price = 11.00, CategoryId = 1 },
                new Product { Id = 3, Title = "Product 03", Desciption = "Desciption 03", Price = 12.00, CategoryId = 2 }
            );
        }
    }
}
