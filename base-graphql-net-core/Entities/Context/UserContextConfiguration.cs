using base_graphql_net_core.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace base_graphql_net_core.Entities.Context
{
    public class UserContextConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(e => e.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(e => e.Username)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.HasIndex(e => e.Username)
                    .IsUnique();

            builder.Property(e => e.Password)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(e => e.Gender)
                  .IsRequired();

            builder.Property(e => e.Role)
                  .IsRequired();

            builder.HasData(
               new User { Id = 1, Username = "admin", Password = Security.GetSimpleMD5("123456"), Name = "Admin", Gender = Common.Enum.Gender.Female, Role = Common.Enum.Role.Admin},
               new User { Id = 2, Username = "manager", Password = Security.GetSimpleMD5("123456"), Name = "Manager1", Gender = Common.Enum.Gender.Male, Role = Common.Enum.Role.Manager},
               new User { Id = 3, Username = "employee1", Password = Security.GetSimpleMD5("123456"), Name = "Employee 1", Gender = Common.Enum.Gender.Female, Role = Common.Enum.Role.Employee},
               new User { Id = 4, Username = "employee2", Password = Security.GetSimpleMD5("123456"), Name = "Employee 2", Gender = Common.Enum.Gender.Male, Role = Common.Enum.Role.Employee},
               new User { Id = 5, Username = "employee3", Password = Security.GetSimpleMD5("123456"), Name = "Employee 3", Gender = Common.Enum.Gender.Female, Role = Common.Enum.Role.Employee}
           );
        }
    }
}
