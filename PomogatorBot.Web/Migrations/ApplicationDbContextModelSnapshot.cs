﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PomogatorBot.Web.Infrastructure;

#nullable disable

namespace PomogatorBot.Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PomogatorBot.Web.Infrastructure.Entities.User", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("UserId"));

                    b.Property<string>("Alias")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("alias");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("last_name");

                    b.Property<int>("Subscriptions")
                        .HasColumnType("integer")
                        .HasColumnName("subscriptions");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)")
                        .HasColumnName("username");

                    b.HasKey("UserId")
                        .HasName("pk_users");

                    b.ToTable("users", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
