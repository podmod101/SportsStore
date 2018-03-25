﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SportsStore.Models;
using System;

namespace SportsStore.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SportsStore.Models.CoachDetail", b =>
                {
                    b.Property<int>("CoachDetailID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CellPhone");

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Name");

                    b.Property<int?>("SchoolID");

                    b.Property<string>("Telephone");

                    b.HasKey("CoachDetailID");

                    b.HasIndex("SchoolID");

                    b.ToTable("CoachDetail");
                });

            modelBuilder.Entity("SportsStore.Models.County", b =>
                {
                    b.Property<int>("CountyID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("CountyID");

                    b.ToTable("County");
                });

            modelBuilder.Entity("SportsStore.Models.Division", b =>
                {
                    b.Property<int>("DivisionID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("DivisionID");

                    b.ToTable("Division");
                });

            modelBuilder.Entity("SportsStore.Models.Grade", b =>
                {
                    b.Property<int>("GradeID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("GradeID");

                    b.ToTable("Grade");
                });

            modelBuilder.Entity("SportsStore.Models.Level", b =>
                {
                    b.Property<int>("LevelID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("LevelID");

                    b.ToTable("Level");
                });

            modelBuilder.Entity("SportsStore.Models.Product", b =>
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

            modelBuilder.Entity("SportsStore.Models.Rating", b =>
                {
                    b.Property<long>("RatingId")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("ProductId");

                    b.Property<int>("Stars");

                    b.HasKey("RatingId");

                    b.HasIndex("ProductId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("SportsStore.Models.School", b =>
                {
                    b.Property<int>("SchoolID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Address2");

                    b.Property<string>("City");

                    b.Property<int?>("CountyID");

                    b.Property<string>("Name");

                    b.Property<int?>("SchoolTournamentDetailID");

                    b.Property<string>("State");

                    b.Property<string>("Zip");

                    b.HasKey("SchoolID");

                    b.HasIndex("CountyID");

                    b.HasIndex("SchoolTournamentDetailID");

                    b.ToTable("School");
                });

            modelBuilder.Entity("SportsStore.Models.SchoolDetail", b =>
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

            modelBuilder.Entity("SportsStore.Models.SchoolTournamentDetail", b =>
                {
                    b.Property<int>("SchoolTournamentDetailID")
                        .ValueGeneratedOnAdd();

                    b.HasKey("SchoolTournamentDetailID");

                    b.ToTable("SchoolTournamentDetail");
                });

            modelBuilder.Entity("SportsStore.Models.Sector", b =>
                {
                    b.Property<int>("SectorID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("SectorID");

                    b.ToTable("Sector");
                });

            modelBuilder.Entity("SportsStore.Models.ShootDay", b =>
                {
                    b.Property<int>("ShootDayID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ShootDayID");

                    b.ToTable("ShootDay");
                });

            modelBuilder.Entity("SportsStore.Models.Student", b =>
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

                    b.Property<int?>("StudentTournamentDetailID");

                    b.HasKey("StudentID");

                    b.HasIndex("StudentTournamentDetailID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("SportsStore.Models.StudentDetail", b =>
                {
                    b.Property<int>("StudentDetailID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CountyID");

                    b.Property<int?>("GradeID");

                    b.Property<int?>("SchoolID");

                    b.Property<int?>("StudentID");

                    b.HasKey("StudentDetailID");

                    b.HasIndex("CountyID");

                    b.HasIndex("GradeID");

                    b.HasIndex("SchoolID");

                    b.HasIndex("StudentID");

                    b.ToTable("StudentDetail");
                });

            modelBuilder.Entity("SportsStore.Models.StudentTournamentDetail", b =>
                {
                    b.Property<int>("StudentTournamentDetailID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.HasKey("StudentTournamentDetailID");

                    b.ToTable("StudentTournamentDetail");
                });

            modelBuilder.Entity("SportsStore.Models.Supplier", b =>
                {
                    b.Property<long>("SupplierId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Name");

                    b.Property<string>("State");

                    b.HasKey("SupplierId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("SportsStore.Models.Tournament", b =>
                {
                    b.Property<int>("TournamentID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.Property<int?>("SchoolTournamentDetailID");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("State");

                    b.Property<bool>("StateChampion");

                    b.Property<int?>("StudentTournamentDetailID");

                    b.Property<string>("Zip");

                    b.HasKey("TournamentID");

                    b.HasIndex("SchoolTournamentDetailID");

                    b.HasIndex("StudentTournamentDetailID");

                    b.ToTable("Tournament");
                });

            modelBuilder.Entity("SportsStore.Models.CoachDetail", b =>
                {
                    b.HasOne("SportsStore.Models.School", "School")
                        .WithMany()
                        .HasForeignKey("SchoolID");
                });

            modelBuilder.Entity("SportsStore.Models.Product", b =>
                {
                    b.HasOne("SportsStore.Models.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId");
                });

            modelBuilder.Entity("SportsStore.Models.Rating", b =>
                {
                    b.HasOne("SportsStore.Models.Product", "Product")
                        .WithMany("Ratings")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("SportsStore.Models.School", b =>
                {
                    b.HasOne("SportsStore.Models.County", "County")
                        .WithMany()
                        .HasForeignKey("CountyID");

                    b.HasOne("SportsStore.Models.SchoolTournamentDetail")
                        .WithMany("Schools")
                        .HasForeignKey("SchoolTournamentDetailID");
                });

            modelBuilder.Entity("SportsStore.Models.SchoolDetail", b =>
                {
                    b.HasOne("SportsStore.Models.Division", "Division")
                        .WithMany()
                        .HasForeignKey("DivisionID");

                    b.HasOne("SportsStore.Models.Level", "Level")
                        .WithMany()
                        .HasForeignKey("LevelID");

                    b.HasOne("SportsStore.Models.School", "School")
                        .WithMany()
                        .HasForeignKey("SchoolID");

                    b.HasOne("SportsStore.Models.Sector", "Sector")
                        .WithMany()
                        .HasForeignKey("SectorID");
                });

            modelBuilder.Entity("SportsStore.Models.Student", b =>
                {
                    b.HasOne("SportsStore.Models.StudentTournamentDetail")
                        .WithMany("Students")
                        .HasForeignKey("StudentTournamentDetailID");
                });

            modelBuilder.Entity("SportsStore.Models.StudentDetail", b =>
                {
                    b.HasOne("SportsStore.Models.County", "County")
                        .WithMany()
                        .HasForeignKey("CountyID");

                    b.HasOne("SportsStore.Models.Grade", "Grade")
                        .WithMany()
                        .HasForeignKey("GradeID");

                    b.HasOne("SportsStore.Models.School", "School")
                        .WithMany()
                        .HasForeignKey("SchoolID");

                    b.HasOne("SportsStore.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID");
                });

            modelBuilder.Entity("SportsStore.Models.Tournament", b =>
                {
                    b.HasOne("SportsStore.Models.SchoolTournamentDetail")
                        .WithMany("Tournaments")
                        .HasForeignKey("SchoolTournamentDetailID");

                    b.HasOne("SportsStore.Models.StudentTournamentDetail")
                        .WithMany("Tournaments")
                        .HasForeignKey("StudentTournamentDetailID");
                });
#pragma warning restore 612, 618
        }
    }
}
