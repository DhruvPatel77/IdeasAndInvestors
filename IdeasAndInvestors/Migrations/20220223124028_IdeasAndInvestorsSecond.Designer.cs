﻿// <auto-generated />
using System;
using IdeasAndInvestors.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IdeasAndInvestors.Migrations
{
    [DbContext(typeof(IdeasAndInvestorsDbContext))]
    [Migration("20220223124028_IdeasAndInvestorsSecond")]
    partial class IdeasAndInvestorsSecond
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("IdeasAndInvestors.Models.CategoryMaster", b =>
                {
                    b.Property<int>("Catid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Catid"), 1L, 1);

                    b.Property<string>("Catname")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Catid");

                    b.ToTable("CategoryMasters");
                });

            modelBuilder.Entity("IdeasAndInvestors.Models.ComplainMaster", b =>
                {
                    b.Property<int>("Compid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Compid"), 1L, 1);

                    b.Property<string>("Cdetails")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<int>("Pid")
                        .HasColumnType("int");

                    b.HasKey("Compid");

                    b.ToTable("ComplainMasters");
                });

            modelBuilder.Entity("IdeasAndInvestors.Models.DonorMaster", b =>
                {
                    b.Property<int>("Did")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Did"), 1L, 1);

                    b.Property<string>("Damount")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Dcomment")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Ddate")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Iid")
                        .HasColumnType("int");

                    b.HasKey("Did");

                    b.ToTable("DonorMasters");
                });

            modelBuilder.Entity("IdeasAndInvestors.Models.FeedbackMaster", b =>
                {
                    b.Property<int>("Fid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Fid"), 1L, 1);

                    b.Property<string>("Experiencerate")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime>("Fdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fdetails")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<int>("Pid")
                        .HasColumnType("int");

                    b.HasKey("Fid");

                    b.ToTable("FeedbackMasters");
                });

            modelBuilder.Entity("IdeasAndInvestors.Models.IdeaMaster", b =>
                {
                    b.Property<int>("Iid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Iid"), 1L, 1);

                    b.Property<int>("Catid")
                        .HasColumnType("int");

                    b.Property<string>("IRFLT10Pnt")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("IRFLT20Pnt")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Idate")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Idescription")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Iimage")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("IinvestmentDuration")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("IinvestmentNeeded")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Ititle")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Ividurl")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<int>("Pid")
                        .HasColumnType("int");

                    b.HasKey("Iid");

                    b.ToTable("IdeaMasters");
                });

            modelBuilder.Entity("IdeasAndInvestors.Models.InvestmentMaster", b =>
                {
                    b.Property<int>("Insid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Insid"), 1L, 1);

                    b.Property<int>("Iid")
                        .HasColumnType("int");

                    b.Property<int>("Insamount")
                        .HasColumnType("int");

                    b.Property<DateTime>("Insdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Instime")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Instype")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Pid")
                        .HasColumnType("int");

                    b.HasKey("Insid");

                    b.ToTable("InvestmentMasters");
                });

            modelBuilder.Entity("IdeasAndInvestors.Models.PersonMaster", b =>
                {
                    b.Property<int>("Pid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Pid"), 1L, 1);

                    b.Property<string>("Paddress")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Panswer")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Pdob")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Pemail")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Pgender")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Pimage")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Pname")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Ppassword")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Pphone")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("Pqid")
                        .HasColumnType("int");

                    b.Property<string>("Pqualification")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Prollid")
                        .HasColumnType("int");

                    b.HasKey("Pid");

                    b.ToTable("PersonMasters");
                });

            modelBuilder.Entity("IdeasAndInvestors.Models.QuestionMaster", b =>
                {
                    b.Property<int>("Qid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Qid"), 1L, 1);

                    b.Property<string>("Questiontext")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Qid");

                    b.ToTable("QuestionMasters");
                });
#pragma warning restore 612, 618
        }
    }
}
