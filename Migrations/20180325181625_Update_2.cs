using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SportsStore.Migrations
{
    public partial class Update_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "StudentDetail",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address2",
                table: "StudentDetail",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "StudentDetail",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "StudentDetail",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "StudentDetail",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Zip",
                table: "StudentDetail",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "SchoolTournamentDetail",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "SchoolTournamentDetail",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ShootDayID",
                table: "SchoolTournamentDetail",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShootTime",
                table: "SchoolTournamentDetail",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "CoachDetail",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SchoolTournamentDetail_ShootDayID",
                table: "SchoolTournamentDetail",
                column: "ShootDayID");

            migrationBuilder.AddForeignKey(
                name: "FK_SchoolTournamentDetail_ShootDay_ShootDayID",
                table: "SchoolTournamentDetail",
                column: "ShootDayID",
                principalTable: "ShootDay",
                principalColumn: "ShootDayID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SchoolTournamentDetail_ShootDay_ShootDayID",
                table: "SchoolTournamentDetail");

            migrationBuilder.DropIndex(
                name: "IX_SchoolTournamentDetail_ShootDayID",
                table: "SchoolTournamentDetail");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "StudentDetail");

            migrationBuilder.DropColumn(
                name: "Address2",
                table: "StudentDetail");

            migrationBuilder.DropColumn(
                name: "City",
                table: "StudentDetail");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "StudentDetail");

            migrationBuilder.DropColumn(
                name: "State",
                table: "StudentDetail");

            migrationBuilder.DropColumn(
                name: "Zip",
                table: "StudentDetail");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "SchoolTournamentDetail");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "SchoolTournamentDetail");

            migrationBuilder.DropColumn(
                name: "ShootDayID",
                table: "SchoolTournamentDetail");

            migrationBuilder.DropColumn(
                name: "ShootTime",
                table: "SchoolTournamentDetail");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "CoachDetail");
        }
    }
}
