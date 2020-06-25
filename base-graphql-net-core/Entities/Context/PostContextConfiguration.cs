using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace base_graphql_net_core.Entities.Context
{
    public class PostContextConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasOne<User>(s => s.Author)
                   .WithMany(g => g.Posts)
                   .HasForeignKey(s => s.UserId);

            builder.Property(e => e.Title)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(e => e.Description)
                  .IsRequired();

            builder.HasData(
                new Post { Id = 1, Title = "Post 1",  Description = "Description 1", UserId = 3 },
                new Post { Id = 2, Title = "Post 2",  Description = "Description 2", UserId = 3 },
                new Post { Id = 3, Title = "Post 3",  Description = "Description 3", UserId = 4 },
                new Post { Id = 4, Title = "Post 4",  Description = "Description 4", UserId = 5 },
                new Post { Id = 5, Title = "Post 5",  Description = "Description 5", UserId = 4 }
           );
        }
    }
}
