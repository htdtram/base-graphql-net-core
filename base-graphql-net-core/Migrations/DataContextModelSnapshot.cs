﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using base_graphql_net_core.Entities.Context;

namespace base_graphql_net_core.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("base_graphql_net_core.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DelFlag")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateAt = new DateTime(2020, 6, 26, 3, 37, 37, 685, DateTimeKind.Utc).AddTicks(2952),
                            DelFlag = false,
                            Name = "Shirt"
                        },
                        new
                        {
                            Id = 2,
                            CreateAt = new DateTime(2020, 6, 26, 3, 37, 37, 685, DateTimeKind.Utc).AddTicks(4250),
                            DelFlag = false,
                            Name = "Hat"
                        },
                        new
                        {
                            Id = 3,
                            CreateAt = new DateTime(2020, 6, 26, 3, 37, 37, 685, DateTimeKind.Utc).AddTicks(4270),
                            DelFlag = false,
                            Name = "Bike"
                        });
                });

            modelBuilder.Entity("base_graphql_net_core.Entities.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DelFlag")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Post");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateAt = new DateTime(2020, 6, 26, 3, 37, 37, 707, DateTimeKind.Utc).AddTicks(9137),
                            DelFlag = false,
                            Description = "Description 1",
                            Title = "Post 1",
                            UserId = 3
                        },
                        new
                        {
                            Id = 2,
                            CreateAt = new DateTime(2020, 6, 26, 3, 37, 37, 708, DateTimeKind.Utc).AddTicks(444),
                            DelFlag = false,
                            Description = "Description 2",
                            Title = "Post 2",
                            UserId = 3
                        },
                        new
                        {
                            Id = 3,
                            CreateAt = new DateTime(2020, 6, 26, 3, 37, 37, 708, DateTimeKind.Utc).AddTicks(473),
                            DelFlag = false,
                            Description = "Description 3",
                            Title = "Post 3",
                            UserId = 4
                        },
                        new
                        {
                            Id = 4,
                            CreateAt = new DateTime(2020, 6, 26, 3, 37, 37, 708, DateTimeKind.Utc).AddTicks(475),
                            DelFlag = false,
                            Description = "Description 4",
                            Title = "Post 4",
                            UserId = 5
                        },
                        new
                        {
                            Id = 5,
                            CreateAt = new DateTime(2020, 6, 26, 3, 37, 37, 708, DateTimeKind.Utc).AddTicks(476),
                            DelFlag = false,
                            Description = "Description 5",
                            Title = "Post 5",
                            UserId = 4
                        });
                });

            modelBuilder.Entity("base_graphql_net_core.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DelFlag")
                        .HasColumnType("bit");

                    b.Property<string>("Desciption")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreateAt = new DateTime(2020, 6, 26, 3, 37, 37, 691, DateTimeKind.Utc).AddTicks(4130),
                            DelFlag = false,
                            Desciption = "Desciption 01",
                            Price = 10.0,
                            Title = "Product 01"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CreateAt = new DateTime(2020, 6, 26, 3, 37, 37, 691, DateTimeKind.Utc).AddTicks(6028),
                            DelFlag = false,
                            Desciption = "Desciption 02",
                            Price = 11.0,
                            Title = "Product 02"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            CreateAt = new DateTime(2020, 6, 26, 3, 37, 37, 691, DateTimeKind.Utc).AddTicks(6061),
                            DelFlag = false,
                            Desciption = "Desciption 03",
                            Price = 12.0,
                            Title = "Product 03"
                        });
                });

            modelBuilder.Entity("base_graphql_net_core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DelFlag")
                        .HasColumnType("bit");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateAt = new DateTime(2020, 6, 26, 3, 37, 37, 696, DateTimeKind.Utc).AddTicks(5068),
                            DelFlag = false,
                            Gender = 1,
                            Name = "Admin",
                            Password = "e10adc3949ba59abbe56e057f20f883e",
                            Role = 0,
                            Username = "admin"
                        },
                        new
                        {
                            Id = 2,
                            CreateAt = new DateTime(2020, 6, 26, 3, 37, 37, 706, DateTimeKind.Utc).AddTicks(6512),
                            DelFlag = false,
                            Gender = 0,
                            Name = "Manager1",
                            Password = "e10adc3949ba59abbe56e057f20f883e",
                            Role = 1,
                            Username = "manager"
                        },
                        new
                        {
                            Id = 3,
                            CreateAt = new DateTime(2020, 6, 26, 3, 37, 37, 706, DateTimeKind.Utc).AddTicks(6743),
                            DelFlag = false,
                            Gender = 1,
                            Name = "Employee 1",
                            Password = "e10adc3949ba59abbe56e057f20f883e",
                            Role = 2,
                            Username = "employee1"
                        },
                        new
                        {
                            Id = 4,
                            CreateAt = new DateTime(2020, 6, 26, 3, 37, 37, 706, DateTimeKind.Utc).AddTicks(6766),
                            DelFlag = false,
                            Gender = 0,
                            Name = "Employee 2",
                            Password = "e10adc3949ba59abbe56e057f20f883e",
                            Role = 2,
                            Username = "employee2"
                        },
                        new
                        {
                            Id = 5,
                            CreateAt = new DateTime(2020, 6, 26, 3, 37, 37, 706, DateTimeKind.Utc).AddTicks(6828),
                            DelFlag = false,
                            Gender = 1,
                            Name = "Employee 3",
                            Password = "e10adc3949ba59abbe56e057f20f883e",
                            Role = 2,
                            Username = "employee3"
                        });
                });

            modelBuilder.Entity("base_graphql_net_core.Entities.Post", b =>
                {
                    b.HasOne("base_graphql_net_core.Entities.User", "Author")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("base_graphql_net_core.Entities.Product", b =>
                {
                    b.HasOne("base_graphql_net_core.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
