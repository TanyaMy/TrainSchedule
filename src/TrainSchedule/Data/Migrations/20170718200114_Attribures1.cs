using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainSchedule.Data.Migrations
{
    public partial class Attribures1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArrivalTime",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "DepartureTime",
                table: "Tickets");

            migrationBuilder.AddColumn<DateTime>(
                name: "ArrivalTime",
                table: "Routes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DepartureTime",
                table: "Routes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Routes_FinishLocationId",
                table: "Routes",
                column: "FinishLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_StartLocationId",
                table: "Routes",
                column: "StartLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_TrainId",
                table: "Routes",
                column: "TrainId");

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_Locations_FinishLocationId",
                table: "Routes",
                column: "FinishLocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_Locations_StartLocationId",
                table: "Routes",
                column: "StartLocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_Trains_TrainId",
                table: "Routes",
                column: "TrainId",
                principalTable: "Trains",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Locations_FinishLocationId",
                table: "Routes");

            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Locations_StartLocationId",
                table: "Routes");

            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Trains_TrainId",
                table: "Routes");

            migrationBuilder.DropIndex(
                name: "IX_Routes_FinishLocationId",
                table: "Routes");

            migrationBuilder.DropIndex(
                name: "IX_Routes_StartLocationId",
                table: "Routes");

            migrationBuilder.DropIndex(
                name: "IX_Routes_TrainId",
                table: "Routes");

            migrationBuilder.DropColumn(
                name: "ArrivalTime",
                table: "Routes");

            migrationBuilder.DropColumn(
                name: "DepartureTime",
                table: "Routes");

            migrationBuilder.AddColumn<DateTime>(
                name: "ArrivalTime",
                table: "Tickets",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DepartureTime",
                table: "Tickets",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
