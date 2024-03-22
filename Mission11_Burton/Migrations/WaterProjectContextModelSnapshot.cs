﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission11_Burton.Models;

#nullable disable

namespace Mission11_Burton.Migrations
{
    [DbContext(typeof(WaterProjectContext))]
    partial class WaterProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("Mission11_Burton.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProgramName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectImpact")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ProjectInstallation")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectPhase")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}