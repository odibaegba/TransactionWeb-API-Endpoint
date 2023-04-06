﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TransactionWebAPI.Infrastructure;

#nullable disable

namespace TransactionWebAPI.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TransactionWebAPI.Domain.Models.Merchant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Merchants");
                });

            modelBuilder.Entity("TransactionWebAPI.Domain.Models.PaymentTerminal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("MerchantId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TerminalType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MerchantId");

                    b.ToTable("PaymentTerminals");
                });

            modelBuilder.Entity("TransactionWebAPI.Domain.Models.Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CardType")
                        .HasColumnType("int");

                    b.Property<Guid>("PaymentTerminalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RRN")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PaymentTerminalId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("TransactionWebAPI.Domain.Models.PaymentTerminal", b =>
                {
                    b.HasOne("TransactionWebAPI.Domain.Models.Merchant", "Merchant")
                        .WithMany("PaymentTerminal")
                        .HasForeignKey("MerchantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Merchant");
                });

            modelBuilder.Entity("TransactionWebAPI.Domain.Models.Transaction", b =>
                {
                    b.HasOne("TransactionWebAPI.Domain.Models.PaymentTerminal", "PaymentTerminal")
                        .WithMany("TransactionList")
                        .HasForeignKey("PaymentTerminalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PaymentTerminal");
                });

            modelBuilder.Entity("TransactionWebAPI.Domain.Models.Merchant", b =>
                {
                    b.Navigation("PaymentTerminal");
                });

            modelBuilder.Entity("TransactionWebAPI.Domain.Models.PaymentTerminal", b =>
                {
                    b.Navigation("TransactionList");
                });
#pragma warning restore 612, 618
        }
    }
}
