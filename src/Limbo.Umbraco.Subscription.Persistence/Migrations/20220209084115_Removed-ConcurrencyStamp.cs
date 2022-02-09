﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Limbo.Umbraco.Subscription.Persistence.Migrations {
    public partial class RemovedConcurrencyStamp : Migration {
        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "SubscriptionSystems");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "SubscriptionItems");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "NewsletterQueues");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Categories");
        }

        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.AddColumn<byte[]>(
                name: "ConcurrencyStamp",
                table: "SubscriptionSystems",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ConcurrencyStamp",
                table: "SubscriptionItems",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ConcurrencyStamp",
                table: "Subscribers",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ConcurrencyStamp",
                table: "NewsletterQueues",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ConcurrencyStamp",
                table: "Categories",
                type: "rowversion",
                rowVersion: true,
                nullable: true);
        }
    }
}
