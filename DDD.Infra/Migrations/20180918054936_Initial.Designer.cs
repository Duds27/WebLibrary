﻿// <auto-generated />
using DDD.Infra.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DDD.Infra.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20180918054936_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("LivrariaHbsis")
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DDD.Domain.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("book_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Book_Author")
                        .IsRequired()
                        .HasColumnName("book_author")
                        .HasMaxLength(200);

                    b.Property<string>("Book_Description")
                        .IsRequired()
                        .HasColumnName("book_description")
                        .HasMaxLength(200);

                    b.Property<double>("Book_Price")
                        .HasColumnName("book_price");

                    b.Property<string>("Book_Publishing_Company")
                        .IsRequired()
                        .HasColumnName("book_publishing_company")
                        .HasMaxLength(200);

                    b.Property<string>("Book_Title")
                        .IsRequired()
                        .HasColumnName("book_title")
                        .HasMaxLength(200);

                    b.HasKey("Id")
                        .HasName("book_id");

                    b.HasIndex("Book_Title")
                        .IsUnique();

                    b.ToTable("BOOK");
                });

            modelBuilder.Entity("DDD.Domain.Entities.Exemplary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("exemplary_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Book_Id")
                        .HasColumnName("book_id");

                    b.Property<int>("Exemplary_Count")
                        .HasColumnName("exemplary_count");

                    b.HasKey("Id")
                        .HasName("exemplary_id");

                    b.ToTable("EXEMPLARY");
                });
#pragma warning restore 612, 618
        }
    }
}
