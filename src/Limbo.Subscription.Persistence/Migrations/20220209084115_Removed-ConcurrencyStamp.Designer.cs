﻿// <auto-generated />
using System;
using Limbo.Subscriptions.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Limbo.Subscriptions.Persistence.Migrations
{
    /// <summary>
    /// 
    /// </summary>
    [DbContext(typeof(SubscriptionDbContext))]
    [Migration("20220209084115_Removed-ConcurrencyStamp")]
    partial class RemovedConcurrencyStamp
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CategorySubscriber", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("SubscribersId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "SubscribersId");

                    b.HasIndex("SubscribersId");

                    b.ToTable("CategorySubscriber");
                });

            modelBuilder.Entity("CategorySubscriptionItem", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("SubscriptionItemsId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "SubscriptionItemsId");

                    b.HasIndex("SubscriptionItemsId");

                    b.ToTable("CategorySubscriptionItem");
                });

            modelBuilder.Entity("Limbo.Umbraco.Subscription.Persistence.Categories.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Limbo.Umbraco.Subscription.Persistence.NewsletterQueues.Models.NewsletterQueue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NewsletterQueues");
                });

            modelBuilder.Entity("Limbo.Umbraco.Subscription.Persistence.Subscribers.Models.Subscriber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SubscriptionSystemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubscriptionSystemId");

                    b.ToTable("Subscribers");
                });

            modelBuilder.Entity("Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Models.SubscriptionItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NodeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SubscriptionItems");
                });

            modelBuilder.Entity("Limbo.Umbraco.Subscription.Persistence.SubscriptionSystems.Models.SubscriptionSystem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SubscriptionSystems");
                });

            modelBuilder.Entity("NewsletterQueueSubscriptionItem", b =>
                {
                    b.Property<int>("NewsletterQueuesId")
                        .HasColumnType("int");

                    b.Property<int>("SubscriptionItemsId")
                        .HasColumnType("int");

                    b.HasKey("NewsletterQueuesId", "SubscriptionItemsId");

                    b.HasIndex("SubscriptionItemsId");

                    b.ToTable("NewsletterQueueSubscriptionItem");
                });

            modelBuilder.Entity("SubscriberSubscriptionItem", b =>
                {
                    b.Property<int>("SubscribersId")
                        .HasColumnType("int");

                    b.Property<int>("SubscriptionItemsId")
                        .HasColumnType("int");

                    b.HasKey("SubscribersId", "SubscriptionItemsId");

                    b.HasIndex("SubscriptionItemsId");

                    b.ToTable("SubscriberSubscriptionItem");
                });

            modelBuilder.Entity("CategorySubscriber", b =>
                {
                    b.HasOne("Limbo.Umbraco.Subscription.Persistence.Categories.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Limbo.Umbraco.Subscription.Persistence.Subscribers.Models.Subscriber", null)
                        .WithMany()
                        .HasForeignKey("SubscribersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CategorySubscriptionItem", b =>
                {
                    b.HasOne("Limbo.Umbraco.Subscription.Persistence.Categories.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Models.SubscriptionItem", null)
                        .WithMany()
                        .HasForeignKey("SubscriptionItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Limbo.Umbraco.Subscription.Persistence.Subscribers.Models.Subscriber", b =>
                {
                    b.HasOne("Limbo.Umbraco.Subscription.Persistence.SubscriptionSystems.Models.SubscriptionSystem", "SubscriptionSystem")
                        .WithMany("Subscribers")
                        .HasForeignKey("SubscriptionSystemId");

                    b.Navigation("SubscriptionSystem");
                });

            modelBuilder.Entity("NewsletterQueueSubscriptionItem", b =>
                {
                    b.HasOne("Limbo.Umbraco.Subscription.Persistence.NewsletterQueues.Models.NewsletterQueue", null)
                        .WithMany()
                        .HasForeignKey("NewsletterQueuesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Models.SubscriptionItem", null)
                        .WithMany()
                        .HasForeignKey("SubscriptionItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SubscriberSubscriptionItem", b =>
                {
                    b.HasOne("Limbo.Umbraco.Subscription.Persistence.Subscribers.Models.Subscriber", null)
                        .WithMany()
                        .HasForeignKey("SubscribersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Limbo.Umbraco.Subscription.Persistence.SubscriptionItems.Models.SubscriptionItem", null)
                        .WithMany()
                        .HasForeignKey("SubscriptionItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Limbo.Umbraco.Subscription.Persistence.SubscriptionSystems.Models.SubscriptionSystem", b =>
                {
                    b.Navigation("Subscribers");
                });
#pragma warning restore 612, 618
        }
    }
}
