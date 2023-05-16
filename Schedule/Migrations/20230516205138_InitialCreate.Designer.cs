﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Schedule.Models;

#nullable disable

namespace Schedule.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20230516205138_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("Schedule.Models.Discipline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Disciplines");
                });

            modelBuilder.Entity("Schedule.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Schedule.Models.IssuingHours", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Hours")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("LoadId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("LoadId");

                    b.ToTable("IssuingHours");
                });

            modelBuilder.Entity("Schedule.Models.LessonType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("LessonTypes");
                });

            modelBuilder.Entity("Schedule.Models.Load", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DisciplineId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DistributeHours")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("GroupId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HoursBalance")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("LessonTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SubGroupId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TeacherId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DisciplineId");

                    b.HasIndex("GroupId");

                    b.HasIndex("LessonTypeId");

                    b.HasIndex("SubGroupId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Loads");
                });

            modelBuilder.Entity("Schedule.Models.SubGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("GroupId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("SubGroups");
                });

            modelBuilder.Entity("Schedule.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Schedule.Models.IssuingHours", b =>
                {
                    b.HasOne("Schedule.Models.Load", "Load")
                        .WithMany()
                        .HasForeignKey("LoadId");

                    b.Navigation("Load");
                });

            modelBuilder.Entity("Schedule.Models.Load", b =>
                {
                    b.HasOne("Schedule.Models.Discipline", "Discipline")
                        .WithMany()
                        .HasForeignKey("DisciplineId");

                    b.HasOne("Schedule.Models.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId");

                    b.HasOne("Schedule.Models.LessonType", "LessonType")
                        .WithMany()
                        .HasForeignKey("LessonTypeId");

                    b.HasOne("Schedule.Models.SubGroup", "SubGroup")
                        .WithMany()
                        .HasForeignKey("SubGroupId");

                    b.HasOne("Schedule.Models.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId");

                    b.Navigation("Discipline");

                    b.Navigation("Group");

                    b.Navigation("LessonType");

                    b.Navigation("SubGroup");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Schedule.Models.SubGroup", b =>
                {
                    b.HasOne("Schedule.Models.Group", "Group")
                        .WithMany("SubGroups")
                        .HasForeignKey("GroupId");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("Schedule.Models.Group", b =>
                {
                    b.Navigation("SubGroups");
                });
#pragma warning restore 612, 618
        }
    }
}
