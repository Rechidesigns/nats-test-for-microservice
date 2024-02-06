﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Store.ShippingService;

namespace ShippingService.Migrations
{
    [DbContext(typeof(StoreDBContext))]
    partial class StoreDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Store.ShippingService.Order", b =>
                {
                    b.Property<string>("OrderNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Shipped")
                        .HasColumnType("bit");

                    b.Property<string>("ShippingAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderNumber");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Store.ShippingService.OrderedProduct", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OrderNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProductNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OrderNumber");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Store.ShippingService.ShippingInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("LastSeqNr")
                        .HasColumnType("decimal(20,0)");

                    b.HasKey("Id");

                    b.ToTable("ShippingInfo");
                });

            modelBuilder.Entity("Store.ShippingService.OrderedProduct", b =>
                {
                    b.HasOne("Store.ShippingService.Order", "Order")
                        .WithMany("Products")
                        .HasForeignKey("OrderNumber")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}