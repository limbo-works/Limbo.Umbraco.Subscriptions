﻿// <auto-generated />
using Limbo.ApiAuthentication.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Limbo.ApiAuthentication.Persistence.Migrations
{
    [DbContext(typeof(ApiAuthenticationContext))]
    [Migration("20220218102752_Add-Claims")]
    partial class AddClaims
    {/// <summary>
    /// 
    /// </summary>
    /// <param name="modelBuilder"></param>
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApiClaimApiKey", b =>
                {
                    b.Property<int>("ApiKeysId")
                        .HasColumnType("int");

                    b.Property<int>("ClaimsId")
                        .HasColumnType("int");

                    b.HasKey("ApiKeysId", "ClaimsId");

                    b.HasIndex("ClaimsId");

                    b.ToTable("ApiClaimApiKey");
                });

            modelBuilder.Entity("Limbo.ApiAuthentication.Persistence.ApiClaims.Models.ApiClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Value")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("ApiClaims");
                });

            modelBuilder.Entity("Limbo.ApiAuthentication.Persistence.ApiKeys.Models.ApiKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Key")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.HasKey("Id");

                    b.ToTable("ApiKeys");
                });

            modelBuilder.Entity("ApiClaimApiKey", b =>
                {
                    b.HasOne("Limbo.ApiAuthentication.Persistence.ApiKeys.Models.ApiKey", null)
                        .WithMany()
                        .HasForeignKey("ApiKeysId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Limbo.ApiAuthentication.Persistence.ApiClaims.Models.ApiClaim", null)
                        .WithMany()
                        .HasForeignKey("ClaimsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
