﻿// <auto-generated />
using System;
using AvaloniaChat.Backend.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AvaloniaChat.Backend.Migrations
{
    [DbContext(typeof(ChatDbContext))]
    partial class ChatDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AvaloniaChat.Backend.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("GroupId"));

                    b.Property<byte[]>("GroupImage")
                        .HasColumnType("bytea");

                    b.Property<string>("GroupTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("AvaloniaChat.Backend.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MessageId"));

                    b.Property<string>("MessageText")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("UsergroupId")
                        .HasColumnType("integer");

                    b.HasKey("MessageId");

                    b.HasIndex("UsergroupId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("AvaloniaChat.Backend.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<long?>("ExpiresIn")
                        .HasColumnType("bigint");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<byte[]>("Logo")
                        .HasColumnType("bytea");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AvaloniaChat.Backend.Models.UserGroup", b =>
                {
                    b.Property<int>("UsergroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UsergroupId"));

                    b.Property<int?>("GroupId")
                        .HasColumnType("integer");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("UsergroupId");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("UserGroups");
                });

            modelBuilder.Entity("AvaloniaChat.Backend.Models.Message", b =>
                {
                    b.HasOne("AvaloniaChat.Backend.Models.UserGroup", "Usergroup")
                        .WithMany("Messages")
                        .HasForeignKey("UsergroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usergroup");
                });

            modelBuilder.Entity("AvaloniaChat.Backend.Models.UserGroup", b =>
                {
                    b.HasOne("AvaloniaChat.Backend.Models.Group", "Group")
                        .WithMany("UserGroups")
                        .HasForeignKey("GroupId");

                    b.HasOne("AvaloniaChat.Backend.Models.User", "User")
                        .WithMany("UserGroups")
                        .HasForeignKey("UserId");

                    b.Navigation("Group");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AvaloniaChat.Backend.Models.Group", b =>
                {
                    b.Navigation("UserGroups");
                });

            modelBuilder.Entity("AvaloniaChat.Backend.Models.User", b =>
                {
                    b.Navigation("UserGroups");
                });

            modelBuilder.Entity("AvaloniaChat.Backend.Models.UserGroup", b =>
                {
                    b.Navigation("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
