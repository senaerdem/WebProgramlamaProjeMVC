﻿// <auto-generated />
using System;
using FlightTicket.Data.Concreate.EfCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FlightTicket.Data.Migrations
{
    [DbContext(typeof(Context_FlightTicket))]
    [Migration("20221104132334_EntityUpdateTicket")]
    partial class EntityUpdateTicket
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("FlightTicket.Entity.Bus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Capacity")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HasSeatScreen")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HasUSB")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HasWifi")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Buses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 10,
                            HasSeatScreen = false,
                            HasUSB = false,
                            HasWifi = true
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 15,
                            HasSeatScreen = false,
                            HasUSB = true,
                            HasWifi = false
                        },
                        new
                        {
                            Id = 3,
                            Capacity = 20,
                            HasSeatScreen = true,
                            HasUSB = true,
                            HasWifi = true
                        });
                });

            modelBuilder.Entity("FlightTicket.Entity.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Metro Turizm"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Kamil Koç"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Lüks Artvin"
                        });
                });

            modelBuilder.Entity("FlightTicket.Entity.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Age")
                        .HasColumnType("TEXT");

                    b.Property<string>("Contact")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("LName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = "26",
                            Contact = "05556667770",
                            Email = "mertsimsek@gmail.com",
                            FName = "Mert",
                            Gender = "Male",
                            LName = "Simsek"
                        },
                        new
                        {
                            Id = 2,
                            Age = "27",
                            Contact = "05556667771",
                            Email = "cansunur@gmail.com",
                            FName = "Cansu Nur",
                            Gender = "Female",
                            LName = "Ürek"
                        },
                        new
                        {
                            Id = 3,
                            Age = "35",
                            Contact = "05556667772",
                            Email = "ali@gmail.com",
                            FName = "Ali",
                            Gender = "Male",
                            LName = "Cesur"
                        },
                        new
                        {
                            Id = 4,
                            Age = "40",
                            Contact = "05556667773",
                            Email = "ayse@gmail.com",
                            FName = "Ayşe",
                            Gender = "Female",
                            LName = "Yavaş"
                        });
                });

            modelBuilder.Entity("FlightTicket.Entity.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Contact")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Drivers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Contact = "+905556668880",
                            Name = "Niyazi Hızlı"
                        },
                        new
                        {
                            Id = 2,
                            Contact = "+905556668881",
                            Name = "Murat Seyrek"
                        },
                        new
                        {
                            Id = 3,
                            Contact = "+905556668882",
                            Name = "Berk Entel"
                        });
                });

            modelBuilder.Entity("FlightTicket.Entity.Line", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Destination")
                        .HasColumnType("TEXT");

                    b.Property<string>("StartingPoint")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Lines");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Destination = "Adana",
                            StartingPoint = "İstanbul"
                        },
                        new
                        {
                            Id = 2,
                            Destination = "Hatay",
                            StartingPoint = "Rize"
                        },
                        new
                        {
                            Id = 3,
                            Destination = "Antalya",
                            StartingPoint = "Sinop"
                        });
                });

            modelBuilder.Entity("FlightTicket.Entity.MidLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Destination")
                        .HasColumnType("TEXT");

                    b.Property<int>("LineId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MidLineOrder")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StartingPoint")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("LineId");

                    b.ToTable("MidLines");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Destination = "Gebze",
                            LineId = 1,
                            MidLineOrder = 1,
                            StartingPoint = "İstanbul"
                        },
                        new
                        {
                            Id = 2,
                            Destination = "Sakarya",
                            LineId = 1,
                            MidLineOrder = 2,
                            StartingPoint = "Gebze"
                        },
                        new
                        {
                            Id = 3,
                            Destination = "Ankara",
                            LineId = 1,
                            MidLineOrder = 3,
                            StartingPoint = "Sakarya"
                        },
                        new
                        {
                            Id = 4,
                            Destination = "Adana",
                            LineId = 1,
                            MidLineOrder = 4,
                            StartingPoint = "Ankara"
                        },
                        new
                        {
                            Id = 5,
                            Destination = "Trabzon",
                            LineId = 2,
                            MidLineOrder = 1,
                            StartingPoint = "Rize"
                        },
                        new
                        {
                            Id = 6,
                            Destination = "Erzincan",
                            LineId = 2,
                            MidLineOrder = 2,
                            StartingPoint = "Trabzon"
                        },
                        new
                        {
                            Id = 7,
                            Destination = "Sivas",
                            LineId = 2,
                            MidLineOrder = 3,
                            StartingPoint = "Erzincan"
                        },
                        new
                        {
                            Id = 8,
                            Destination = "Gaziantep",
                            LineId = 2,
                            MidLineOrder = 4,
                            StartingPoint = "Sivas"
                        },
                        new
                        {
                            Id = 9,
                            Destination = "Hatay",
                            LineId = 2,
                            MidLineOrder = 5,
                            StartingPoint = "Gaziantep"
                        },
                        new
                        {
                            Id = 10,
                            Destination = "Kastamonu",
                            LineId = 3,
                            MidLineOrder = 1,
                            StartingPoint = "Sinop"
                        },
                        new
                        {
                            Id = 11,
                            Destination = "Karabük",
                            LineId = 3,
                            MidLineOrder = 2,
                            StartingPoint = "Kastamonu"
                        },
                        new
                        {
                            Id = 12,
                            Destination = "Afyon",
                            LineId = 3,
                            MidLineOrder = 3,
                            StartingPoint = "Karabük"
                        },
                        new
                        {
                            Id = 13,
                            Destination = "Burdur",
                            LineId = 3,
                            MidLineOrder = 4,
                            StartingPoint = "Afyon"
                        },
                        new
                        {
                            Id = 14,
                            Destination = "Antalya",
                            LineId = 3,
                            MidLineOrder = 5,
                            StartingPoint = "Burdur"
                        });
                });

            modelBuilder.Entity("FlightTicket.Entity.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("FlightTicket.Entity.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsBooked")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PnrNo")
                        .HasColumnType("TEXT");

                    b.Property<int>("SeatNo")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TripId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("TripId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("FlightTicket.Entity.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ArrivalTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("DepartureTime")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("FareAmount")
                        .HasColumnType("TEXT");

                    b.Property<int>("MidLineId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Remarks")
                        .HasColumnType("TEXT");

                    b.Property<string>("ScheduleDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("TripDetailId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MidLineId");

                    b.HasIndex("TripDetailId");

                    b.ToTable("Trips");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArrivalTime = "14:00",
                            DepartureTime = "11:30",
                            FareAmount = 50m,
                            MidLineId = 1,
                            ScheduleDate = "01.11.2022",
                            TripDetailId = 1
                        },
                        new
                        {
                            Id = 2,
                            ArrivalTime = "15:20",
                            DepartureTime = "14:00",
                            MidLineId = 2,
                            ScheduleDate = "01.11.2022",
                            TripDetailId = 1
                        },
                        new
                        {
                            Id = 3,
                            ArrivalTime = "21:30",
                            DepartureTime = "15:20",
                            FareAmount = 120m,
                            MidLineId = 3,
                            ScheduleDate = "01.11.2022",
                            TripDetailId = 1
                        },
                        new
                        {
                            Id = 4,
                            ArrivalTime = "21:30",
                            DepartureTime = "15:20",
                            FareAmount = 150m,
                            MidLineId = 4,
                            ScheduleDate = "01.11.2022",
                            TripDetailId = 1
                        },
                        new
                        {
                            Id = 5,
                            ArrivalTime = "21:30",
                            DepartureTime = "15:20",
                            FareAmount = 70m,
                            MidLineId = 5,
                            ScheduleDate = "01.11.2022",
                            TripDetailId = 1
                        },
                        new
                        {
                            Id = 6,
                            ArrivalTime = "21:30",
                            DepartureTime = "15:20",
                            FareAmount = 150m,
                            MidLineId = 6,
                            ScheduleDate = "01.11.2022",
                            TripDetailId = 2
                        },
                        new
                        {
                            Id = 7,
                            ArrivalTime = "21:30",
                            DepartureTime = "15:20",
                            FareAmount = 110m,
                            MidLineId = 7,
                            ScheduleDate = "01.11.2022",
                            TripDetailId = 2
                        },
                        new
                        {
                            Id = 8,
                            ArrivalTime = "21:30",
                            DepartureTime = "15:20",
                            FareAmount = 60m,
                            MidLineId = 8,
                            ScheduleDate = "01.11.2022",
                            TripDetailId = 2
                        },
                        new
                        {
                            Id = 9,
                            ArrivalTime = "21:30",
                            DepartureTime = "15:20",
                            FareAmount = 90m,
                            MidLineId = 9,
                            ScheduleDate = "01.11.2022",
                            TripDetailId = 2
                        },
                        new
                        {
                            Id = 10,
                            ArrivalTime = "21:30",
                            DepartureTime = "15:20",
                            FareAmount = 40m,
                            MidLineId = 10,
                            ScheduleDate = "01.11.2022",
                            TripDetailId = 3
                        },
                        new
                        {
                            Id = 11,
                            ArrivalTime = "21:30",
                            DepartureTime = "15:20",
                            FareAmount = 75m,
                            MidLineId = 11,
                            ScheduleDate = "01.11.2022",
                            TripDetailId = 3
                        },
                        new
                        {
                            Id = 12,
                            ArrivalTime = "21:30",
                            DepartureTime = "15:20",
                            FareAmount = 115m,
                            MidLineId = 12,
                            ScheduleDate = "01.11.2022",
                            TripDetailId = 3
                        },
                        new
                        {
                            Id = 13,
                            ArrivalTime = "21:30",
                            DepartureTime = "15:20",
                            FareAmount = 120m,
                            MidLineId = 13,
                            ScheduleDate = "01.11.2022",
                            TripDetailId = 3
                        },
                        new
                        {
                            Id = 14,
                            ArrivalTime = "21:30",
                            DepartureTime = "15:20",
                            FareAmount = 60m,
                            MidLineId = 14,
                            ScheduleDate = "01.11.2022",
                            TripDetailId = 3
                        });
                });

            modelBuilder.Entity("FlightTicket.Entity.TripDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BusId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DriverId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BusId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("DriverId");

                    b.ToTable("TripDetails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BusId = 1,
                            DriverId = 1
                        },
                        new
                        {
                            Id = 2,
                            BusId = 1,
                            DriverId = 1
                        },
                        new
                        {
                            Id = 3,
                            BusId = 1,
                            DriverId = 1
                        });
                });

            modelBuilder.Entity("FlightTicket.Entity.MidLine", b =>
                {
                    b.HasOne("FlightTicket.Entity.Line", "Line")
                        .WithMany("MidLines")
                        .HasForeignKey("LineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Line");
                });

            modelBuilder.Entity("FlightTicket.Entity.Ticket", b =>
                {
                    b.HasOne("FlightTicket.Entity.Customer", "Customer")
                        .WithMany("Tickets")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FlightTicket.Entity.Trip", "Trip")
                        .WithMany("Tickets")
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Trip");
                });

            modelBuilder.Entity("FlightTicket.Entity.Trip", b =>
                {
                    b.HasOne("FlightTicket.Entity.MidLine", "MidLine")
                        .WithMany("Trips")
                        .HasForeignKey("MidLineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FlightTicket.Entity.TripDetail", "TripDetail")
                        .WithMany("Trips")
                        .HasForeignKey("TripDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MidLine");

                    b.Navigation("TripDetail");
                });

            modelBuilder.Entity("FlightTicket.Entity.TripDetail", b =>
                {
                    b.HasOne("FlightTicket.Entity.Bus", "Bus")
                        .WithMany("TripDetails")
                        .HasForeignKey("BusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FlightTicket.Entity.Company", "Company")
                        .WithMany("TripDetails")
                        .HasForeignKey("CompanyId");

                    b.HasOne("FlightTicket.Entity.Driver", "Driver")
                        .WithMany("TripDetails")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bus");

                    b.Navigation("Company");

                    b.Navigation("Driver");
                });

            modelBuilder.Entity("FlightTicket.Entity.Bus", b =>
                {
                    b.Navigation("TripDetails");
                });

            modelBuilder.Entity("FlightTicket.Entity.Company", b =>
                {
                    b.Navigation("TripDetails");
                });

            modelBuilder.Entity("FlightTicket.Entity.Customer", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("FlightTicket.Entity.Driver", b =>
                {
                    b.Navigation("TripDetails");
                });

            modelBuilder.Entity("FlightTicket.Entity.Line", b =>
                {
                    b.Navigation("MidLines");
                });

            modelBuilder.Entity("FlightTicket.Entity.MidLine", b =>
                {
                    b.Navigation("Trips");
                });

            modelBuilder.Entity("FlightTicket.Entity.Trip", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("FlightTicket.Entity.TripDetail", b =>
                {
                    b.Navigation("Trips");
                });
#pragma warning restore 612, 618
        }
    }
}
