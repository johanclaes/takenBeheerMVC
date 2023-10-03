﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using takenbeheer_dal;

#nullable disable

namespace takenbeheer_dal.Migrations
{
    [DbContext(typeof(TakenContext))]
    [Migration("20231003100034_5Fifth")]
    partial class _5Fifth
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("takenbeheer_models.Comment", b =>
                {
                    b.Property<string>("CommentID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CommentCreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ToDoTaskID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CommentID");

                    b.HasIndex("ToDoTaskID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("takenbeheer_models.ToDoTaak", b =>
                {
                    b.Property<string>("ToDoTaskID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ToDoCreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ToDoFinishedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ToDoStartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ToDoTaskID");

                    b.ToTable("ToDoTaken");
                });

            modelBuilder.Entity("takenbeheer_models.Comment", b =>
                {
                    b.HasOne("takenbeheer_models.ToDoTaak", "ToDoTaak")
                        .WithMany("Comments")
                        .HasForeignKey("ToDoTaskID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ToDoTaak");
                });

            modelBuilder.Entity("takenbeheer_models.ToDoTaak", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
