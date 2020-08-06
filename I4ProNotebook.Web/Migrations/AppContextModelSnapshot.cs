﻿// <auto-generated />
using System;
using I4ProNotebook.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace I4ProNotebook.Web.Migrations
{
    [DbContext(typeof(Models.AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("I4PRONotebook.Entity.Models.Contact", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("I4PRONotebook.Entity.Models.Email", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ContactID")
                        .HasColumnType("int");

                    b.Property<string>("EmailName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ContactID");

                    b.ToTable("Email");
                });

            modelBuilder.Entity("I4PRONotebook.Entity.Models.PhoneNumber", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ContactID")
                        .HasColumnType("int");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ContactID");

                    b.ToTable("PhoneNumber");
                });

            modelBuilder.Entity("I4PRONotebook.Entity.Models.Email", b =>
                {
                    b.HasOne("I4PRONotebook.Entity.Models.Contact", "Contact")
                        .WithMany("Emails")
                        .HasForeignKey("ContactID");
                });

            modelBuilder.Entity("I4PRONotebook.Entity.Models.PhoneNumber", b =>
                {
                    b.HasOne("I4PRONotebook.Entity.Models.Contact", "Contact")
                        .WithMany("PhoneNumbers")
                        .HasForeignKey("ContactID");
                });
#pragma warning restore 612, 618
        }
    }
}