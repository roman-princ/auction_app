﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using auction_app.Data;

#nullable disable

namespace auction_app.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220908090638_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("auction_app.Models.Auction", b =>
                {
                    b.Property<Guid>("AuctionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CreatorUserId")
                        .HasColumnType("TEXT");

                    b.Property<int>("CurrentBid")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("CurrentHighestBidderUserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("StartingBid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AuctionId");

                    b.HasIndex("CreatorUserId");

                    b.HasIndex("CurrentHighestBidderUserId");

                    b.ToTable("Auctions");
                });

            modelBuilder.Entity("auction_app.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("auction_app.Models.Auction", b =>
                {
                    b.HasOne("auction_app.Models.User", "Creator")
                        .WithMany("MyAuctions")
                        .HasForeignKey("CreatorUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("auction_app.Models.User", "CurrentHighestBidder")
                        .WithMany()
                        .HasForeignKey("CurrentHighestBidderUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creator");

                    b.Navigation("CurrentHighestBidder");
                });

            modelBuilder.Entity("auction_app.Models.User", b =>
                {
                    b.Navigation("MyAuctions");
                });
#pragma warning restore 612, 618
        }
    }
}
