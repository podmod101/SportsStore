using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SportsStore.Migrations
{
    public partial class Update_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "County",
                columns: table => new
                {
                    CountyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_County", x => x.CountyID);
                });

            migrationBuilder.CreateTable(
                name: "Division",
                columns: table => new
                {
                    DivisionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Division", x => x.DivisionID);
                });

            migrationBuilder.CreateTable(
                name: "Grade",
                columns: table => new
                {
                    GradeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grade", x => x.GradeID);
                });

            migrationBuilder.CreateTable(
                name: "Level",
                columns: table => new
                {
                    LevelID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Level", x => x.LevelID);
                });

            migrationBuilder.CreateTable(
                name: "SchoolTournamentDetail",
                columns: table => new
                {
                    SchoolTournamentDetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolTournamentDetail", x => x.SchoolTournamentDetailID);
                });

            migrationBuilder.CreateTable(
                name: "Sector",
                columns: table => new
                {
                    SectorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sector", x => x.SectorID);
                });

            migrationBuilder.CreateTable(
                name: "ShootDay",
                columns: table => new
                {
                    ShootDayID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShootDay", x => x.ShootDayID);
                });

            migrationBuilder.CreateTable(
                name: "StudentTournamentDetail",
                columns: table => new
                {
                    StudentTournamentDetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentTournamentDetail", x => x.StudentTournamentDetailID);
                });

            migrationBuilder.CreateTable(
                name: "School",
                columns: table => new
                {
                    SchoolID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    Address2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    CountyID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    SchoolTournamentDetailID = table.Column<int>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School", x => x.SchoolID);
                    table.ForeignKey(
                        name: "FK_School_County_CountyID",
                        column: x => x.CountyID,
                        principalTable: "County",
                        principalColumn: "CountyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_School_SchoolTournamentDetail_SchoolTournamentDetailID",
                        column: x => x.SchoolTournamentDetailID,
                        principalTable: "SchoolTournamentDetail",
                        principalColumn: "SchoolTournamentDetailID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerNumber = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    HuntingLicenseNumber = table.Column<string>(nullable: true),
                    LastFourSSN = table.Column<int>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    MiddleInitial = table.Column<string>(nullable: true),
                    StudentTournamentDetailID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentID);
                    table.ForeignKey(
                        name: "FK_Student_StudentTournamentDetail_StudentTournamentDetailID",
                        column: x => x.StudentTournamentDetailID,
                        principalTable: "StudentTournamentDetail",
                        principalColumn: "StudentTournamentDetailID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tournament",
                columns: table => new
                {
                    TournamentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    SchoolTournamentDetailID = table.Column<int>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    State = table.Column<string>(nullable: true),
                    StateChampion = table.Column<bool>(nullable: false),
                    StudentTournamentDetailID = table.Column<int>(nullable: true),
                    Zip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournament", x => x.TournamentID);
                    table.ForeignKey(
                        name: "FK_Tournament_SchoolTournamentDetail_SchoolTournamentDetailID",
                        column: x => x.SchoolTournamentDetailID,
                        principalTable: "SchoolTournamentDetail",
                        principalColumn: "SchoolTournamentDetailID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tournament_StudentTournamentDetail_StudentTournamentDetailID",
                        column: x => x.StudentTournamentDetailID,
                        principalTable: "StudentTournamentDetail",
                        principalColumn: "StudentTournamentDetailID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CoachDetail",
                columns: table => new
                {
                    CoachDetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CellPhone = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    SchoolID = table.Column<int>(nullable: true),
                    Telephone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoachDetail", x => x.CoachDetailID);
                    table.ForeignKey(
                        name: "FK_CoachDetail_School_SchoolID",
                        column: x => x.SchoolID,
                        principalTable: "School",
                        principalColumn: "SchoolID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SchoolDetail",
                columns: table => new
                {
                    SchoolDetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    DivisionID = table.Column<int>(nullable: true),
                    LevelID = table.Column<int>(nullable: true),
                    SchoolID = table.Column<int>(nullable: true),
                    SectorID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolDetail", x => x.SchoolDetailID);
                    table.ForeignKey(
                        name: "FK_SchoolDetail_Division_DivisionID",
                        column: x => x.DivisionID,
                        principalTable: "Division",
                        principalColumn: "DivisionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SchoolDetail_Level_LevelID",
                        column: x => x.LevelID,
                        principalTable: "Level",
                        principalColumn: "LevelID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SchoolDetail_School_SchoolID",
                        column: x => x.SchoolID,
                        principalTable: "School",
                        principalColumn: "SchoolID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SchoolDetail_Sector_SectorID",
                        column: x => x.SectorID,
                        principalTable: "Sector",
                        principalColumn: "SectorID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentDetail",
                columns: table => new
                {
                    StudentDetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountyID = table.Column<int>(nullable: true),
                    GradeID = table.Column<int>(nullable: true),
                    SchoolID = table.Column<int>(nullable: true),
                    StudentID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentDetail", x => x.StudentDetailID);
                    table.ForeignKey(
                        name: "FK_StudentDetail_County_CountyID",
                        column: x => x.CountyID,
                        principalTable: "County",
                        principalColumn: "CountyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentDetail_Grade_GradeID",
                        column: x => x.GradeID,
                        principalTable: "Grade",
                        principalColumn: "GradeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentDetail_School_SchoolID",
                        column: x => x.SchoolID,
                        principalTable: "School",
                        principalColumn: "SchoolID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentDetail_Student_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Student",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CoachDetail_SchoolID",
                table: "CoachDetail",
                column: "SchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_School_CountyID",
                table: "School",
                column: "CountyID");

            migrationBuilder.CreateIndex(
                name: "IX_School_SchoolTournamentDetailID",
                table: "School",
                column: "SchoolTournamentDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolDetail_DivisionID",
                table: "SchoolDetail",
                column: "DivisionID");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolDetail_LevelID",
                table: "SchoolDetail",
                column: "LevelID");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolDetail_SchoolID",
                table: "SchoolDetail",
                column: "SchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolDetail_SectorID",
                table: "SchoolDetail",
                column: "SectorID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_StudentTournamentDetailID",
                table: "Student",
                column: "StudentTournamentDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentDetail_CountyID",
                table: "StudentDetail",
                column: "CountyID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentDetail_GradeID",
                table: "StudentDetail",
                column: "GradeID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentDetail_SchoolID",
                table: "StudentDetail",
                column: "SchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentDetail_StudentID",
                table: "StudentDetail",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_SchoolTournamentDetailID",
                table: "Tournament",
                column: "SchoolTournamentDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_StudentTournamentDetailID",
                table: "Tournament",
                column: "StudentTournamentDetailID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoachDetail");

            migrationBuilder.DropTable(
                name: "SchoolDetail");

            migrationBuilder.DropTable(
                name: "ShootDay");

            migrationBuilder.DropTable(
                name: "StudentDetail");

            migrationBuilder.DropTable(
                name: "Tournament");

            migrationBuilder.DropTable(
                name: "Division");

            migrationBuilder.DropTable(
                name: "Level");

            migrationBuilder.DropTable(
                name: "Sector");

            migrationBuilder.DropTable(
                name: "Grade");

            migrationBuilder.DropTable(
                name: "School");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "County");

            migrationBuilder.DropTable(
                name: "SchoolTournamentDetail");

            migrationBuilder.DropTable(
                name: "StudentTournamentDetail");
        }
    }
}
