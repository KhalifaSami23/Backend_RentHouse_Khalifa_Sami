﻿// <auto-generated />
using System;
using Backend_RentHouse_Khalifa_Sami.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Backend_RentHouse_Khalifa_Sami.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Backend_RentHouse_Khalifa_Sami.Model.Client", b =>
                {
                    b.Property<int>("IdClient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Civility")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HaveAlreadyRentedHouse")
                        .HasColumnType("bit");

                    b.Property<bool>("IsClient")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalRegister")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdClient");

                    b.ToTable("CommandClient");
                });

            modelBuilder.Entity("Backend_RentHouse_Khalifa_Sami.Model.Contract", b =>
                {
                    b.Property<int>("IdContract")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("BaseIndex")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("BeginContract")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<float>("BeginIndexElectricity")
                        .HasColumnType("real");

                    b.Property<float>("BeginIndexGaz")
                        .HasColumnType("real");

                    b.Property<float>("BeginIndexWater")
                        .HasColumnType("real");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<byte>("Duration")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("EndContract")
                        .HasColumnType("datetime2");

                    b.Property<float>("EndIndexElectricity")
                        .HasColumnType("real");

                    b.Property<float>("EndIndexGaz")
                        .HasColumnType("real");

                    b.Property<float>("EndIndexWater")
                        .HasColumnType("real");

                    b.Property<DateTime>("EntryDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime>("GaranteePaidDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("GuaranteeAmount")
                        .HasColumnType("real");

                    b.Property<bool>("IsFirstMountPaid")
                        .HasColumnType("bit");

                    b.Property<bool>("IsGuaranteePaid")
                        .HasColumnType("bit");

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("SignatureDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("IdContract");

                    b.HasIndex("ClientId");

                    b.HasIndex("PropertyId");

                    b.ToTable("CommandContract");
                });

            modelBuilder.Entity("Backend_RentHouse_Khalifa_Sami.Model.Property", b =>
                {
                    b.Property<int>("IdProperty")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DiningRoomArea")
                        .HasColumnType("int");

                    b.Property<float>("FixedChargesCost")
                        .HasColumnType("real");

                    b.Property<byte>("Floor")
                        .HasColumnType("tinyint");

                    b.Property<int>("IdProprio")
                        .HasColumnType("int");

                    b.Property<string>("ImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KitchenArea")
                        .HasColumnType("int");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<int>("NbLocator")
                        .HasColumnType("int");

                    b.Property<byte>("NbRoom")
                        .HasColumnType("tinyint");

                    b.Property<float>("RentCost")
                        .HasColumnType("real");

                    b.Property<int>("TotalArea")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdProperty");

                    b.ToTable("CommandProperty");
                });

            modelBuilder.Entity("Backend_RentHouse_Khalifa_Sami.Model.Contract", b =>
                {
                    b.HasOne("Backend_RentHouse_Khalifa_Sami.Model.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend_RentHouse_Khalifa_Sami.Model.Property", "Property")
                        .WithMany()
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Backend_RentHouse_Khalifa_Sami.Model.Property", b =>
                {
                    b.OwnsMany("Backend_RentHouse_Khalifa_Sami.Model.Room", "RoomsDetails", b1 =>
                        {
                            b1.Property<int>("IdRoom")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("PropertyIdProperty")
                                .HasColumnType("int");

                            b1.HasKey("IdRoom");

                            b1.HasIndex("PropertyIdProperty");

                            b1.ToTable("Room");

                            b1.WithOwner()
                                .HasForeignKey("PropertyIdProperty");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
