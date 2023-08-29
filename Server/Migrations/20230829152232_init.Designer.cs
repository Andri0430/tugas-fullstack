﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using server.Data;

#nullable disable

namespace server.Migrations
{
    [DbContext(typeof(EkostContext))]
    [Migration("20230829152232_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("server.Models.Account", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Email");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("server.Models.DetailGeneralFacility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GeneralFacilityId")
                        .HasColumnType("int");

                    b.Property<int>("KostId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GeneralFacilityId");

                    b.HasIndex("KostId");

                    b.ToTable("DetailGeneralFacilities");
                });

            modelBuilder.Entity("server.Models.DetailRoomFacility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("KostId")
                        .HasColumnType("int");

                    b.Property<int>("RoomFacilityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KostId");

                    b.HasIndex("RoomFacilityId");

                    b.ToTable("DetailRoomFacilities");
                });

            modelBuilder.Entity("server.Models.DetailToiletFacility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ToiletFacilityId")
                        .HasColumnType("int");

                    b.Property<int>("kostId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ToiletFacilityId");

                    b.HasIndex("kostId");

                    b.ToTable("DetailToiletFacilities");
                });

            modelBuilder.Entity("server.Models.Favorit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KostId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Favorits");
                });

            modelBuilder.Entity("server.Models.GeneralFacility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NamaFasilitas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GeneralFacilities");
                });

            modelBuilder.Entity("server.Models.Kost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KostImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KostName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KostPrice")
                        .HasColumnType("int");

                    b.Property<string>("KostType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerEmail")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("QtyRoom")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OwnerEmail");

                    b.ToTable("Kosts");
                });

            modelBuilder.Entity("server.Models.KostTenant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccountEmail")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("KostId")
                        .HasColumnType("int");

                    b.Property<int>("LamaKost")
                        .HasColumnType("int");

                    b.Property<string>("TanggalMasuk")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalBiaya")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountEmail");

                    b.HasIndex("KostId");

                    b.ToTable("KostTenants");
                });

            modelBuilder.Entity("server.Models.RoomFacility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NamaFasilitas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoomFacilities");
                });

            modelBuilder.Entity("server.Models.ToiletFacility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NamaFasilitas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ToiletFacilities");
                });

            modelBuilder.Entity("server.Models.DetailGeneralFacility", b =>
                {
                    b.HasOne("server.Models.GeneralFacility", "GeneralFacility")
                        .WithMany()
                        .HasForeignKey("GeneralFacilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("server.Models.Kost", "Kost")
                        .WithMany()
                        .HasForeignKey("KostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GeneralFacility");

                    b.Navigation("Kost");
                });

            modelBuilder.Entity("server.Models.DetailRoomFacility", b =>
                {
                    b.HasOne("server.Models.Kost", "Kost")
                        .WithMany()
                        .HasForeignKey("KostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("server.Models.RoomFacility", "RoomFacility")
                        .WithMany()
                        .HasForeignKey("RoomFacilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kost");

                    b.Navigation("RoomFacility");
                });

            modelBuilder.Entity("server.Models.DetailToiletFacility", b =>
                {
                    b.HasOne("server.Models.ToiletFacility", "ToiletFacility")
                        .WithMany()
                        .HasForeignKey("ToiletFacilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("server.Models.Kost", "kost")
                        .WithMany()
                        .HasForeignKey("kostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ToiletFacility");

                    b.Navigation("kost");
                });

            modelBuilder.Entity("server.Models.Kost", b =>
                {
                    b.HasOne("server.Models.Account", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerEmail");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("server.Models.KostTenant", b =>
                {
                    b.HasOne("server.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountEmail");

                    b.HasOne("server.Models.Kost", "Kost")
                        .WithMany()
                        .HasForeignKey("KostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Kost");
                });
#pragma warning restore 612, 618
        }
    }
}
