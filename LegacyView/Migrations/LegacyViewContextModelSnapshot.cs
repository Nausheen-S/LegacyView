﻿// <auto-generated />
using System;
using LegacyView.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LegacyView.Migrations
{
    [DbContext(typeof(LegacyViewContext))]
    partial class LegacyViewContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LegacyView.Models.DVD", b =>
                {
                    b.Property<int>("DVDId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("DVDCustomerReview")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("DVDDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DVDGenre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DVDName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DVDPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DVDId");

                    b.ToTable("DVD");
                });
#pragma warning restore 612, 618
        }
    }
}
