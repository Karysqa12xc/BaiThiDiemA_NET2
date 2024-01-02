﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NVHN_0461.Data;

#nullable disable

namespace NVHN_0461.Migrations
{
    [DbContext(typeof(ApplicationDbcontext))]
    [Migration("20240102075348_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("NVHN_0461.Models.Wallet", b =>
                {
                    b.Property<string>("WalletId")
                        .HasColumnType("TEXT");

                    b.Property<float>("Money")
                        .HasColumnType("REAL");

                    b.Property<int>("NameWallet")
                        .HasColumnType("INTEGER");

                    b.HasKey("WalletId");

                    b.ToTable("Wallets");
                });
#pragma warning restore 612, 618
        }
    }
}
