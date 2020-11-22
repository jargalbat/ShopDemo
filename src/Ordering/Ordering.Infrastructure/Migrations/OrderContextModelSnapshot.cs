﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ordering.Infrastructure.Data;

namespace Ordering.Infrastructure.Migrations
{
    [DbContext(typeof(OrderContext))]
    partial class OrderContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ordering.Core.Entities.Order", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("AddressLine")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("CVV")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("CardName")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("CardNumber")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Country")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("EmailAddress")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Expiration")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("FirstName")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("LastName")
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("PaymentMethod")
                    .HasColumnType("int");

                b.Property<string>("State")
                    .HasColumnType("nvarchar(max)");

                b.Property<decimal>("TotalPrice")
                    .HasColumnType("decimal(18,2)");

                b.Property<string>("UserName")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("ZipCode")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Orders");
            });
#pragma warning restore 612, 618
        }
    }
}
