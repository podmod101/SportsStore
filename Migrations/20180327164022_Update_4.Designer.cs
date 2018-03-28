﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using TournamentManagement.Models;
using System;

namespace TournamentManagement.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20180327164022_Update_4")]
    partial class Update_4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TournamentManagement.Models.CoachDetail", b =>
                {
                    b.Property<int>("CoachDetailID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CellPhone");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<int?>("SchoolID");

                    b.Property<string>("Telephone");

                    b.HasKey("CoachDetailID");

                    b.HasIndex("SchoolID");

                    b.ToTable("CoachDetail");
                });

            modelBuilder.Entity("TournamentManagement.Models.County", b =>
                {
                    b.Property<int>("CountyID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("CountyID");

                    b.ToTable("County");
                });

            modelBuilder.Entity("TournamentManagement.Models.Division", b =>
                {
                    b.Property<int>("DivisionID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("DivisionID");

                    b.ToTable("Division");
                });

            modelBuilder.Entity("TournamentManagement.Models.Grade", b =>
                {
                    b.Property<int>("GradeID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("GradeID");

                    b.ToTable("Grade");
                });

            modelBuilder.Entity("TournamentManagement.Models.Level", b =>
                {
                    b.Property<int>("LevelID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("LevelID");

                    b.ToTable("Level");
                });

            modelBuilder.Entity("TournamentManagement.Models.Product", b =>
                {
                    b.Property<long>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<long?>("SupplierId");

                    b.HasKey("ProductId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("TournamentManagement.Models.Rating", b =>
                {
                    b.Property<long>("RatingId")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("ProductId");

                    b.Property<int>("Stars");

                    b.HasKey("RatingId");

                    b.HasIndex("ProductId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("TournamentManagement.Models.School", b =>
                {
                    b.Property<int>("SchoolID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Address2");

                    b.Property<string>("City");

                    b.Property<int?>("CountyID");

                    b.Property<string>("Name");

                    b.Property<string>("State");

                    b.Property<string>("Zip");

                    b.HasKey("SchoolID");

                    b.HasIndex("CountyID");

                    b.ToTable("School");
                });

            modelBuilder.Entity("TournamentManagement.Models.SchoolDetail", b =>
                {
                    b.Property<int>("SchoolDetailID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<int?>("DivisionID");

                    b.Property<int?>("LevelID");

                    b.Property<int?>("SchoolID");

                    b.Property<int?>("SectorID");

                    b.HasKey("SchoolDetailID");

                    b.HasIndex("DivisionID");

                    b.HasIndex("LevelID");

                    b.HasIndex("SchoolID");

                    b.HasIndex("SectorID");

                    b.ToTable("SchoolDetail");
                });

            modelBuilder.Entity("TournamentManagement.Models.SchoolTournamentDetail", b =>
                {
                    b.Property<int>("SchoolTournamentDetailID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<DateTime>("CreateDate");

                    b.Property<int?>("SchoolID");

                    b.Property<int?>("ShootDayID");

                    b.Property<System.TimeSpan>("ShootTime");

                    b.Property<int?>("TournamentID");

                    b.HasKey("SchoolTournamentDetailID");

                    b.HasIndex("SchoolID");

                    b.HasIndex("ShootDayID");

                    b.HasIndex("TournamentID");

                    b.ToTable("SchoolTournamentDetail");
                });

            modelBuilder.Entity("TournamentManagement.Models.Sector", b =>
                {
                    b.Property<int>("SectorID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("SectorID");

                    b.ToTable("Sector");
                });

            modelBuilder.Entity("TournamentManagement.Models.ShootDay", b =>
                {
                    b.Property<int>("ShootDayID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ShootDayID");

                    b.ToTable("ShootDay");
                });

            modelBuilder.Entity("TournamentManagement.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomerNumber");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender");

                    b.Property<string>("HuntingLicenseNumber");

                    b.Property<int>("LastFourSSN");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleInitial");

                    b.HasKey("StudentID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("TournamentManagement.Models.StudentDetail", b =>
                {
                    b.Property<int>("StudentDetailID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Address2");

                    b.Property<string>("City");

                    b.Property<int?>("CountyID");

                    b.Property<DateTime>("CreateDate");

                    b.Property<int?>("GradeID");

                    b.Property<int?>("SchoolID");

                    b.Property<string>("State");

                    b.Property<int?>("StudentID");

                    b.Property<string>("Zip");

                    b.HasKey("StudentDetailID");

                    b.HasIndex("CountyID");

                    b.HasIndex("GradeID");

                    b.HasIndex("SchoolID");

                    b.HasIndex("StudentID");

                    b.ToTable("StudentDetail");
                });

            modelBuilder.Entity("TournamentManagement.Models.StudentTournamentDetail", b =>
                {
                    b.Property<int>("StudentTournamentDetailID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<int?>("StudentID");

                    b.Property<int?>("TournamentID");

                    b.HasKey("StudentTournamentDetailID");

                    b.HasIndex("StudentID");

                    b.HasIndex("TournamentID");

                    b.ToTable("StudentTournamentDetail");
                });

            modelBuilder.Entity("TournamentManagement.Models.Supplier", b =>
                {
                    b.Property<long>("SupplierId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Name");

                    b.Property<string>("State");

                    b.HasKey("SupplierId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("TournamentManagement.Models.Tournament", b =>
                {
                    b.Property<int>("TournamentID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("State");

                    b.Property<bool>("StateChampionship");

                    b.Property<string>("Zip");

                    b.HasKey("TournamentID");

                    b.ToTable("Tournament");
                });

            modelBuilder.Entity("TournamentManagement.Models.CoachDetail", b =>
                {
                    b.HasOne("TournamentManagement.Models.School", "School")
                        .WithMany()
                        .HasForeignKey("SchoolID");
                });

            modelBuilder.Entity("TournamentManagement.Models.Product", b =>
                {
                    b.HasOne("TournamentManagement.Models.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId");
                });

            modelBuilder.Entity("TournamentManagement.Models.Rating", b =>
                {
                    b.HasOne("TournamentManagement.Models.Product", "Product")
                        .WithMany("Ratings")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("TournamentManagement.Models.School", b =>
                {
                    b.HasOne("TournamentManagement.Models.County", "County")
                        .WithMany()
                        .HasForeignKey("CountyID");
                });

            modelBuilder.Entity("TournamentManagement.Models.SchoolDetail", b =>
                {
                    b.HasOne("TournamentManagement.Models.Division", "Division")
                        .WithMany()
                        .HasForeignKey("DivisionID");

                    b.HasOne("TournamentManagement.Models.Level", "Level")
                        .WithMany()
                        .HasForeignKey("LevelID");

                    b.HasOne("TournamentManagement.Models.School", "School")
                        .WithMany("SchoolDetails")
                        .HasForeignKey("SchoolID");

                    b.HasOne("TournamentManagement.Models.Sector", "Sector")
                        .WithMany()
                        .HasForeignKey("SectorID");
                });

            modelBuilder.Entity("TournamentManagement.Models.SchoolTournamentDetail", b =>
                {
                    b.HasOne("TournamentManagement.Models.School", "School")
                        .WithMany("SchoolTournamentDetails")
                        .HasForeignKey("SchoolID");

                    b.HasOne("TournamentManagement.Models.ShootDay", "ShootDay")
                        .WithMany()
                        .HasForeignKey("ShootDayID");

                    b.HasOne("TournamentManagement.Models.Tournament", "Tournament")
                        .WithMany("SchoolTournamentDetails")
                        .HasForeignKey("TournamentID");
                });

            modelBuilder.Entity("TournamentManagement.Models.StudentDetail", b =>
                {
                    b.HasOne("TournamentManagement.Models.County", "County")
                        .WithMany()
                        .HasForeignKey("CountyID");

                    b.HasOne("TournamentManagement.Models.Grade", "Grade")
                        .WithMany()
                        .HasForeignKey("GradeID");

                    b.HasOne("TournamentManagement.Models.School", "School")
                        .WithMany()
                        .HasForeignKey("SchoolID");

                    b.HasOne("TournamentManagement.Models.Student", "Student")
                        .WithMany("StudentDetails")
                        .HasForeignKey("StudentID");
                });

            modelBuilder.Entity("TournamentManagement.Models.StudentTournamentDetail", b =>
                {
                    b.HasOne("TournamentManagement.Models.Student", "Student")
                        .WithMany("StudentTournamentDetails")
                        .HasForeignKey("StudentID");

                    b.HasOne("TournamentManagement.Models.Tournament", "Tournament")
                        .WithMany("StudentTournamentDetails")
                        .HasForeignKey("TournamentID");
                });
#pragma warning restore 612, 618
        }
    }
}
