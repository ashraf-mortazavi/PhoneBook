﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PhonBook.Context;

#nullable disable

namespace PhoneBook.Migrations
{
    [DbContext(typeof(PhonebookDbContext))]
    partial class PhonebookDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PhonBook.Model.PhoneBookImages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneBookId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PhoneBookId");

                    b.ToTable("PhoneBookImages");
                });

            modelBuilder.Entity("PhoneBook.Models.PhoneBooks", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PhoneBooks");
                });

            modelBuilder.Entity("PhonBook.Model.PhoneBookImages", b =>
                {
                    b.HasOne("PhoneBook.Models.PhoneBooks", "PhoneBook")
                        .WithMany("PhoneBookImages")
                        .HasForeignKey("PhoneBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PhoneBook");
                });

            modelBuilder.Entity("PhoneBook.Models.PhoneBooks", b =>
                {
                    b.Navigation("PhoneBookImages");
                });
#pragma warning restore 612, 618
        }
    }
}
