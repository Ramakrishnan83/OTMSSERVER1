﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OTMS.Context;

namespace OTMS.Migrations
{
    [DbContext(typeof(UserDbContext))]
    partial class UserDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OTMS.Context.TripDetails", b =>
                {
                    b.Property<int>("Trip_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Destination");

                    b.Property<int>("Duration");

                    b.Property<int>("Fare");

                    b.Property<string>("Source");

                    b.Property<string>("Trip_Name");

                    b.Property<int>("User_Id");

                    b.HasKey("Trip_id");

                    b.ToTable("TripDetails");

                    b.HasData(
                        new
                        {
                            Trip_id = 1,
                            Destination = "QLN",
                            Duration = 5,
                            Fare = 100,
                            Source = "ERS",
                            Trip_Name = "KOllam",
                            User_Id = 1
                        },
                        new
                        {
                            Trip_id = 2,
                            Destination = "TVM",
                            Duration = 7,
                            Fare = 100,
                            Source = "ERS",
                            Trip_Name = "TVM",
                            User_Id = 2
                        },
                        new
                        {
                            Trip_id = 3,
                            Destination = "THR",
                            Duration = 5,
                            Fare = 300,
                            Source = "ERS",
                            Trip_Name = "THR",
                            User_Id = 1
                        },
                        new
                        {
                            Trip_id = 4,
                            Destination = "KTY",
                            Duration = 3,
                            Fare = 100,
                            Source = "ERS",
                            Trip_Name = "KTY",
                            User_Id = 3
                        },
                        new
                        {
                            Trip_id = 5,
                            Destination = "ALP",
                            Duration = 2,
                            Fare = 50,
                            Source = "ERS",
                            Trip_Name = "ALP",
                            User_Id = 3
                        });
                });

            modelBuilder.Entity("OTMS.Context.User", b =>
                {
                    b.Property<int>("User_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Pwd");

                    b.Property<string>("Role");

                    b.HasKey("User_Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            User_Id = 1,
                            Pwd = "John",
                            Role = "Developer"
                        },
                        new
                        {
                            User_Id = 2,
                            Pwd = "Chris",
                            Role = "Admin"
                        },
                        new
                        {
                            User_Id = 3,
                            Pwd = "Mukesh",
                            Role = "Consultant"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
