using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Video_Production.Data.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "client",
                table: "Production",
                newName: "Client");

            migrationBuilder.AddColumn<string>(
                name: "ProductionName",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Budget",
                table: "Production",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Production",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Production",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ProductionName",
                table: "Client",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductionName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Budget",
                table: "Production");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Production");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Production");

            migrationBuilder.DropColumn(
                name: "ProductionName",
                table: "Client");

            migrationBuilder.RenameColumn(
                name: "Client",
                table: "Production",
                newName: "client");
        }
    }
}
