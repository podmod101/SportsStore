using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SportsStore.Migrations
{
    public partial class Update_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_School_SchoolTournamentDetail_SchoolTournamentDetailID",
                table: "School");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_StudentTournamentDetail_StudentTournamentDetailID",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Tournament_SchoolTournamentDetail_SchoolTournamentDetailID",
                table: "Tournament");

            migrationBuilder.DropForeignKey(
                name: "FK_Tournament_StudentTournamentDetail_StudentTournamentDetailID",
                table: "Tournament");

            migrationBuilder.DropIndex(
                name: "IX_Tournament_SchoolTournamentDetailID",
                table: "Tournament");

            migrationBuilder.DropIndex(
                name: "IX_Tournament_StudentTournamentDetailID",
                table: "Tournament");

            migrationBuilder.DropIndex(
                name: "IX_Student_StudentTournamentDetailID",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_School_SchoolTournamentDetailID",
                table: "School");

            migrationBuilder.DropColumn(
                name: "SchoolTournamentDetailID",
                table: "Tournament");

            migrationBuilder.DropColumn(
                name: "StudentTournamentDetailID",
                table: "Tournament");

            migrationBuilder.DropColumn(
                name: "StudentTournamentDetailID",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "SchoolTournamentDetailID",
                table: "School");

            migrationBuilder.RenameColumn(
                name: "StateChampion",
                table: "Tournament",
                newName: "StateChampionship");

            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "StudentTournamentDetail",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TournamentID",
                table: "StudentTournamentDetail",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SchoolID",
                table: "SchoolTournamentDetail",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TournamentID",
                table: "SchoolTournamentDetail",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentTournamentDetail_StudentID",
                table: "StudentTournamentDetail",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentTournamentDetail_TournamentID",
                table: "StudentTournamentDetail",
                column: "TournamentID");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolTournamentDetail_SchoolID",
                table: "SchoolTournamentDetail",
                column: "SchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolTournamentDetail_TournamentID",
                table: "SchoolTournamentDetail",
                column: "TournamentID");

            migrationBuilder.AddForeignKey(
                name: "FK_SchoolTournamentDetail_School_SchoolID",
                table: "SchoolTournamentDetail",
                column: "SchoolID",
                principalTable: "School",
                principalColumn: "SchoolID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SchoolTournamentDetail_Tournament_TournamentID",
                table: "SchoolTournamentDetail",
                column: "TournamentID",
                principalTable: "Tournament",
                principalColumn: "TournamentID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTournamentDetail_Student_StudentID",
                table: "StudentTournamentDetail",
                column: "StudentID",
                principalTable: "Student",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTournamentDetail_Tournament_TournamentID",
                table: "StudentTournamentDetail",
                column: "TournamentID",
                principalTable: "Tournament",
                principalColumn: "TournamentID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SchoolTournamentDetail_School_SchoolID",
                table: "SchoolTournamentDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_SchoolTournamentDetail_Tournament_TournamentID",
                table: "SchoolTournamentDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentTournamentDetail_Student_StudentID",
                table: "StudentTournamentDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentTournamentDetail_Tournament_TournamentID",
                table: "StudentTournamentDetail");

            migrationBuilder.DropIndex(
                name: "IX_StudentTournamentDetail_StudentID",
                table: "StudentTournamentDetail");

            migrationBuilder.DropIndex(
                name: "IX_StudentTournamentDetail_TournamentID",
                table: "StudentTournamentDetail");

            migrationBuilder.DropIndex(
                name: "IX_SchoolTournamentDetail_SchoolID",
                table: "SchoolTournamentDetail");

            migrationBuilder.DropIndex(
                name: "IX_SchoolTournamentDetail_TournamentID",
                table: "SchoolTournamentDetail");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "StudentTournamentDetail");

            migrationBuilder.DropColumn(
                name: "TournamentID",
                table: "StudentTournamentDetail");

            migrationBuilder.DropColumn(
                name: "SchoolID",
                table: "SchoolTournamentDetail");

            migrationBuilder.DropColumn(
                name: "TournamentID",
                table: "SchoolTournamentDetail");

            migrationBuilder.RenameColumn(
                name: "StateChampionship",
                table: "Tournament",
                newName: "StateChampion");

            migrationBuilder.AddColumn<int>(
                name: "SchoolTournamentDetailID",
                table: "Tournament",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentTournamentDetailID",
                table: "Tournament",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentTournamentDetailID",
                table: "Student",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ShootTime",
                table: "SchoolTournamentDetail",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<int>(
                name: "SchoolTournamentDetailID",
                table: "School",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_SchoolTournamentDetailID",
                table: "Tournament",
                column: "SchoolTournamentDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_StudentTournamentDetailID",
                table: "Tournament",
                column: "StudentTournamentDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_StudentTournamentDetailID",
                table: "Student",
                column: "StudentTournamentDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_School_SchoolTournamentDetailID",
                table: "School",
                column: "SchoolTournamentDetailID");

            migrationBuilder.AddForeignKey(
                name: "FK_School_SchoolTournamentDetail_SchoolTournamentDetailID",
                table: "School",
                column: "SchoolTournamentDetailID",
                principalTable: "SchoolTournamentDetail",
                principalColumn: "SchoolTournamentDetailID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_StudentTournamentDetail_StudentTournamentDetailID",
                table: "Student",
                column: "StudentTournamentDetailID",
                principalTable: "StudentTournamentDetail",
                principalColumn: "StudentTournamentDetailID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tournament_SchoolTournamentDetail_SchoolTournamentDetailID",
                table: "Tournament",
                column: "SchoolTournamentDetailID",
                principalTable: "SchoolTournamentDetail",
                principalColumn: "SchoolTournamentDetailID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tournament_StudentTournamentDetail_StudentTournamentDetailID",
                table: "Tournament",
                column: "StudentTournamentDetailID",
                principalTable: "StudentTournamentDetail",
                principalColumn: "StudentTournamentDetailID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
