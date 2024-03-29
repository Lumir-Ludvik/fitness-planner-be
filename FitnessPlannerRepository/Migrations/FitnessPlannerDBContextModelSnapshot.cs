﻿// <auto-generated />
using System;
using FitnessPlannerRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FitnessPlannerRepository.Migrations
{
    [DbContext(typeof(FitnessPlannerDBContext))]
    partial class FitnessPlannerDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FitnessPlannerRepository.Entities.CalendarEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FridayId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MondayId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SaturdayId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SundayId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ThursdayId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TuesdayId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("WednesdayId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("FridayId")
                        .IsUnique();

                    b.HasIndex("MondayId")
                        .IsUnique();

                    b.HasIndex("SaturdayId")
                        .IsUnique();

                    b.HasIndex("SundayId")
                        .IsUnique();

                    b.HasIndex("ThursdayId")
                        .IsUnique();

                    b.HasIndex("TuesdayId")
                        .IsUnique();

                    b.HasIndex("WednesdayId")
                        .IsUnique();

                    b.ToTable("Calendars");
                });

            modelBuilder.Entity("FitnessPlannerRepository.Entities.ModuleEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Base64Img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("DayId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Filename")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DayId");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("FitnessPlannerRepository.Entities.base.DayBaseEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CalendarId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.HasKey("Id");

                    b.ToTable("DayBaseEntity");

                    b.HasDiscriminator<string>("Discriminator").HasValue("DayBaseEntity");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("FitnessPlannerRepository.Entities.WeekDays.FridayEntity", b =>
                {
                    b.HasBaseType("FitnessPlannerRepository.Entities.base.DayBaseEntity");

                    b.HasDiscriminator().HasValue("FridayEntity");
                });

            modelBuilder.Entity("FitnessPlannerRepository.Entities.WeekDays.MondayEntity", b =>
                {
                    b.HasBaseType("FitnessPlannerRepository.Entities.base.DayBaseEntity");

                    b.HasDiscriminator().HasValue("MondayEntity");
                });

            modelBuilder.Entity("FitnessPlannerRepository.Entities.WeekDays.SaturdayEntity", b =>
                {
                    b.HasBaseType("FitnessPlannerRepository.Entities.base.DayBaseEntity");

                    b.HasDiscriminator().HasValue("SaturdayEntity");
                });

            modelBuilder.Entity("FitnessPlannerRepository.Entities.WeekDays.SundayEntity", b =>
                {
                    b.HasBaseType("FitnessPlannerRepository.Entities.base.DayBaseEntity");

                    b.HasDiscriminator().HasValue("SundayEntity");
                });

            modelBuilder.Entity("FitnessPlannerRepository.Entities.WeekDays.ThursdayEntity", b =>
                {
                    b.HasBaseType("FitnessPlannerRepository.Entities.base.DayBaseEntity");

                    b.HasDiscriminator().HasValue("ThursdayEntity");
                });

            modelBuilder.Entity("FitnessPlannerRepository.Entities.WeekDays.TuesdayEntity", b =>
                {
                    b.HasBaseType("FitnessPlannerRepository.Entities.base.DayBaseEntity");

                    b.HasDiscriminator().HasValue("TuesdayEntity");
                });

            modelBuilder.Entity("FitnessPlannerRepository.Entities.WeekDays.WednesdayEntity", b =>
                {
                    b.HasBaseType("FitnessPlannerRepository.Entities.base.DayBaseEntity");

                    b.HasDiscriminator().HasValue("WednesdayEntity");
                });

            modelBuilder.Entity("FitnessPlannerRepository.Entities.CalendarEntity", b =>
                {
                    b.HasOne("FitnessPlannerRepository.Entities.WeekDays.FridayEntity", "Friday")
                        .WithOne("Calendar")
                        .HasForeignKey("FitnessPlannerRepository.Entities.CalendarEntity", "FridayId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("FitnessPlannerRepository.Entities.WeekDays.MondayEntity", "Monday")
                        .WithOne("Calendar")
                        .HasForeignKey("FitnessPlannerRepository.Entities.CalendarEntity", "MondayId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("FitnessPlannerRepository.Entities.WeekDays.SaturdayEntity", "Saturday")
                        .WithOne("Calendar")
                        .HasForeignKey("FitnessPlannerRepository.Entities.CalendarEntity", "SaturdayId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("FitnessPlannerRepository.Entities.WeekDays.SundayEntity", "Sunday")
                        .WithOne("Calendar")
                        .HasForeignKey("FitnessPlannerRepository.Entities.CalendarEntity", "SundayId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("FitnessPlannerRepository.Entities.WeekDays.ThursdayEntity", "Thursday")
                        .WithOne("Calendar")
                        .HasForeignKey("FitnessPlannerRepository.Entities.CalendarEntity", "ThursdayId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("FitnessPlannerRepository.Entities.WeekDays.TuesdayEntity", "Tuesday")
                        .WithOne("Calendar")
                        .HasForeignKey("FitnessPlannerRepository.Entities.CalendarEntity", "TuesdayId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("FitnessPlannerRepository.Entities.WeekDays.WednesdayEntity", "Wednesday")
                        .WithOne("Calendar")
                        .HasForeignKey("FitnessPlannerRepository.Entities.CalendarEntity", "WednesdayId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Friday");

                    b.Navigation("Monday");

                    b.Navigation("Saturday");

                    b.Navigation("Sunday");

                    b.Navigation("Thursday");

                    b.Navigation("Tuesday");

                    b.Navigation("Wednesday");
                });

            modelBuilder.Entity("FitnessPlannerRepository.Entities.ModuleEntity", b =>
                {
                    b.HasOne("FitnessPlannerRepository.Entities.base.DayBaseEntity", "Day")
                        .WithMany("Modules")
                        .HasForeignKey("DayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Day");
                });

            modelBuilder.Entity("FitnessPlannerRepository.Entities.base.DayBaseEntity", b =>
                {
                    b.Navigation("Modules");
                });

            modelBuilder.Entity("FitnessPlannerRepository.Entities.WeekDays.FridayEntity", b =>
                {
                    b.Navigation("Calendar")
                        .IsRequired();
                });

            modelBuilder.Entity("FitnessPlannerRepository.Entities.WeekDays.MondayEntity", b =>
                {
                    b.Navigation("Calendar")
                        .IsRequired();
                });

            modelBuilder.Entity("FitnessPlannerRepository.Entities.WeekDays.SaturdayEntity", b =>
                {
                    b.Navigation("Calendar")
                        .IsRequired();
                });

            modelBuilder.Entity("FitnessPlannerRepository.Entities.WeekDays.SundayEntity", b =>
                {
                    b.Navigation("Calendar")
                        .IsRequired();
                });

            modelBuilder.Entity("FitnessPlannerRepository.Entities.WeekDays.ThursdayEntity", b =>
                {
                    b.Navigation("Calendar")
                        .IsRequired();
                });

            modelBuilder.Entity("FitnessPlannerRepository.Entities.WeekDays.TuesdayEntity", b =>
                {
                    b.Navigation("Calendar")
                        .IsRequired();
                });

            modelBuilder.Entity("FitnessPlannerRepository.Entities.WeekDays.WednesdayEntity", b =>
                {
                    b.Navigation("Calendar")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
