﻿// <auto-generated />
using System;
using Backend_RentHouse_Khalifa_Sami.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Backend_RentHouse_Khalifa_Sami.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20201009085822_HistoryContractUpdate")]
    partial class HistoryContractUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Backend_RentHouse_Khalifa_Sami.Model.Client.Client", b =>
                {
                    b.Property<int>("idClient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("civility")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nationalRegister")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("placeOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("postalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idClient");

                    b.ToTable("CommandCli");
                });

            modelBuilder.Entity("Backend_RentHouse_Khalifa_Sami.Model.Contract", b =>
                {
                    b.Property<int>("idContract")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("baseIndex")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("beginContract")
                        .HasColumnType("datetime2");

                    b.Property<float>("beginIndexElectricity")
                        .HasColumnType("real");

                    b.Property<float>("beginIndexGaz")
                        .HasColumnType("real");

                    b.Property<float>("beginIndexWater")
                        .HasColumnType("real");

                    b.Property<int>("clientId")
                        .HasColumnType("int");

                    b.Property<byte>("duration")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("endContract")
                        .HasColumnType("datetime2");

                    b.Property<float>("endIndexElectricity")
                        .HasColumnType("real");

                    b.Property<float>("endIndexGaz")
                        .HasColumnType("real");

                    b.Property<float>("endIndexWater")
                        .HasColumnType("real");

                    b.Property<DateTime>("entryDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("garanteeAmount")
                        .HasColumnType("real");

                    b.Property<DateTime>("garanteePaidDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isFirstMountPaid")
                        .HasColumnType("bit");

                    b.Property<bool>("isGuaranteePaid")
                        .HasColumnType("bit");

                    b.Property<int>("propertyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("releaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("idContract");

                    b.ToTable("CommandContr");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Contract");
                });

            modelBuilder.Entity("Backend_RentHouse_Khalifa_Sami.Model.Property.Property", b =>
                {
                    b.Property<int>("idProperty")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("diningRoomArea")
                        .HasColumnType("int");

                    b.Property<float>("fixedChargesCost")
                        .HasColumnType("real");

                    b.Property<byte?>("floor")
                        .HasColumnType("tinyint");

                    b.Property<string>("imageLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isCurrentlyRented")
                        .HasColumnType("bit");

                    b.Property<int>("kitchenArea")
                        .HasColumnType("int");

                    b.Property<byte>("nbRoom")
                        .HasColumnType("tinyint");

                    b.Property<float>("rentCost")
                        .HasColumnType("real");

                    b.Property<DateTime>("signatureDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("totalArea")
                        .HasColumnType("int");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idProperty");

                    b.ToTable("CommandProp");
                });

            modelBuilder.Entity("Backend_RentHouse_Khalifa_Sami.Model.HistoryContract", b =>
                {
                    b.HasBaseType("Backend_RentHouse_Khalifa_Sami.Model.Contract");

                    b.HasDiscriminator().HasValue("HistoryContract");
                });

            modelBuilder.Entity("Backend_RentHouse_Khalifa_Sami.Model.Property.Property", b =>
                {
                    b.OwnsMany("Backend_RentHouse_Khalifa_Sami.Model.Property.Room", "roomsDetails", b1 =>
                        {
                            b1.Property<int>("idRoom")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("PropertyidProperty")
                                .HasColumnType("int");

                            b1.HasKey("idRoom");

                            b1.HasIndex("PropertyidProperty");

                            b1.ToTable("Room");

                            b1.WithOwner()
                                .HasForeignKey("PropertyidProperty");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
