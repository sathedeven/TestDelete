﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using MyTransport.Domain.Data;
using System;

namespace MyTransport.Domain.Migrations
{
    [DbContext(typeof(MyTransportDbContext))]
    [Migration("20180507113632_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyTransport.Domain.Entities.Vendor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsActive");

                    b.Property<string>("OwnerEmail");

                    b.Property<string>("OwnerMobile");

                    b.Property<string>("OwnerName");

                    b.Property<string>("VendorName");

                    b.HasKey("Id");

                    b.ToTable("Vendors");
                });
#pragma warning restore 612, 618
        }
    }
}
