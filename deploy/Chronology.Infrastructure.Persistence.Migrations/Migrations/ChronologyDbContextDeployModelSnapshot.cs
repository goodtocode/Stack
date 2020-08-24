﻿// <auto-generated />
using System;
using GoodToCode.Chronology.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GoodToCode.Chronology.Infrastructure.Persistence.Migrations.Migrations
{
    [DbContext(typeof(ChronologyDbContextDeploy))]
    partial class ChronologyDbContextDeployModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GoodToCode.Chronology.Models.AssociateSchedule", b =>
                {
                    b.Property<Guid>("AssociateScheduleKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AssociateKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ScheduleKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ScheduleTypeKey")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AssociateScheduleKey");

                    b.HasIndex("AssociateScheduleKey")
                        .IsUnique()
                        .HasName("IX_AssociateSchedule_Key");

                    b.HasIndex("AssociateKey", "ScheduleKey")
                        .IsUnique()
                        .HasName("IX_AssociateSchedule_All");

                    b.ToTable("AssociateSchedule","Chronology");
                });

            modelBuilder.Entity("GoodToCode.Chronology.Models.AssociateTimeRecurring", b =>
                {
                    b.Property<Guid>("AssociateTimeRecurringKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AssociateKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("TimeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<Guid>("TimeRecurringKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TimeTypeKey")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AssociateTimeRecurringKey");

                    b.HasIndex("AssociateTimeRecurringKey")
                        .IsUnique()
                        .HasName("IX_AssociateTimeRecurring_Key");

                    b.HasIndex("AssociateKey", "TimeRecurringKey")
                        .IsUnique()
                        .HasName("IX_AssociateTimeRecurring_All");

                    b.ToTable("AssociateTimeRecurring","Chronology");
                });

            modelBuilder.Entity("GoodToCode.Chronology.Models.LocationTimeRecurring", b =>
                {
                    b.Property<Guid>("LocationTimeRecurringKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<Guid>("LocationKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TimeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<Guid>("TimeRecurringKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TimeTypeKey")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LocationTimeRecurringKey");

                    b.HasIndex("LocationTimeRecurringKey")
                        .IsUnique()
                        .HasName("IX_LocationTimeRecurring_Location");

                    b.HasIndex("LocationKey", "TimeRecurringKey")
                        .IsUnique()
                        .HasName("IX_LocationTimeRecurring_All");

                    b.ToTable("LocationTimeRecurring","Chronology");
                });

            modelBuilder.Entity("GoodToCode.Chronology.Models.ResourceSchedule", b =>
                {
                    b.Property<Guid>("ResourceScheduleKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ResourceKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ScheduleKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ScheduleTypeKey")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ResourceScheduleKey");

                    b.HasIndex("ResourceScheduleKey")
                        .IsUnique()
                        .HasName("IX_ResourceSchedule_Key");

                    b.HasIndex("ResourceKey", "ScheduleKey")
                        .IsUnique()
                        .HasName("IX_ResourceSchedule_All");

                    b.ToTable("ResourceSchedule","Chronology");
                });

            modelBuilder.Entity("GoodToCode.Chronology.Models.ResourceTimeRecurring", b =>
                {
                    b.Property<Guid>("ResourceTimeRecurringKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<Guid>("ResourceKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TimeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<Guid>("TimeRecurringKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TimeTypeKey")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ResourceTimeRecurringKey");

                    b.HasIndex("ResourceTimeRecurringKey")
                        .IsUnique()
                        .HasName("IX_ResourceTimeRecurring_Resource");

                    b.HasIndex("ResourceKey", "TimeRecurringKey")
                        .IsUnique()
                        .HasName("IX_ResourceTimeRecurring_All");

                    b.ToTable("ResourceTimeRecurring","Chronology");
                });

            modelBuilder.Entity("GoodToCode.Chronology.Models.Schedule", b =>
                {
                    b.Property<Guid>("ScheduleKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ScheduleDescription")
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<string>("ScheduleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("ScheduleKey");

                    b.HasIndex("ScheduleKey")
                        .IsUnique();

                    b.ToTable("Schedule","Chronology");
                });

            modelBuilder.Entity("GoodToCode.Chronology.Models.ScheduleSlot", b =>
                {
                    b.Property<Guid>("ScheduleSlotKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ScheduleKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SlotKey")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ScheduleSlotKey");

                    b.HasIndex("ScheduleKey")
                        .HasName("IX_ScheduleSlot_Schedule");

                    b.HasIndex("ScheduleSlotKey")
                        .IsUnique()
                        .HasName("IX_ScheduleSlot_Key");

                    b.HasIndex("SlotKey")
                        .HasName("IX_ScheduleSlot_Slot");

                    b.HasIndex("SlotKey", "ScheduleKey")
                        .IsUnique()
                        .HasName("IX_ScheduleSlot_All");

                    b.ToTable("ScheduleSlot","Chronology");
                });

            modelBuilder.Entity("GoodToCode.Chronology.Models.ScheduleType", b =>
                {
                    b.Property<Guid>("ScheduleTypeKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ScheduleTypeDescription")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("ScheduleTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("ScheduleTypeKey");

                    b.HasIndex("ScheduleTypeKey")
                        .IsUnique()
                        .HasName("IX_ScheduleType_Key");

                    b.ToTable("ScheduleType","Chronology");
                });

            modelBuilder.Entity("GoodToCode.Chronology.Models.Slot", b =>
                {
                    b.Property<Guid>("SlotKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SlotDescription")
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<string>("SlotName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("SlotKey");

                    b.HasIndex("SlotKey")
                        .IsUnique();

                    b.ToTable("Slot","Chronology");
                });

            modelBuilder.Entity("GoodToCode.Chronology.Models.SlotLocation", b =>
                {
                    b.Property<Guid>("SlotLocationKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LocationKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("LocationTypeKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SlotKey")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("SlotLocationKey");

                    b.HasIndex("SlotKey")
                        .HasName("IX_SlotLocation_Slot");

                    b.HasIndex("SlotLocationKey")
                        .IsUnique()
                        .HasName("IX_SlotLocation_Key");

                    b.HasIndex("SlotKey", "LocationKey")
                        .IsUnique()
                        .HasName("IX_SlotLocation_All");

                    b.ToTable("SlotLocation","Chronology");
                });

            modelBuilder.Entity("GoodToCode.Chronology.Models.SlotResource", b =>
                {
                    b.Property<Guid>("SlotResourceKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ResourceKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ResourceTypeKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SlotKey")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("SlotResourceKey");

                    b.HasIndex("ResourceKey")
                        .HasName("IX_SlotResource_Resource");

                    b.HasIndex("SlotKey")
                        .HasName("IX_SlotResource_Slot");

                    b.HasIndex("SlotResourceKey")
                        .IsUnique();

                    b.HasIndex("ResourceKey", "SlotKey")
                        .IsUnique()
                        .HasName("IX_SlotResource_All");

                    b.ToTable("SlotResource","Chronology");
                });

            modelBuilder.Entity("GoodToCode.Chronology.Models.SlotTimeRange", b =>
                {
                    b.Property<Guid>("SlotTimeRangeKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SlotKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TimeRangeKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TimeTypeKey")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("SlotTimeRangeKey");

                    b.HasIndex("SlotKey")
                        .HasName("IX_SlotTimeRange_Slot");

                    b.HasIndex("SlotKey", "TimeRangeKey")
                        .IsUnique()
                        .HasName("IX_SlotTime_All");

                    b.ToTable("SlotTimeRange","Chronology");
                });

            modelBuilder.Entity("GoodToCode.Chronology.Models.SlotTimeRecurring", b =>
                {
                    b.Property<Guid>("SlotTimeRecurringKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SlotKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TimeRecurringKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TimeTypeKey")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("SlotTimeRecurringKey");

                    b.HasIndex("SlotKey")
                        .HasName("IX_SlotTimeRecurring_Slot");

                    b.HasIndex("SlotKey", "TimeRecurringKey")
                        .IsUnique()
                        .HasName("IX_SlotTime_All");

                    b.ToTable("SlotTimeRecurring","Chronology");
                });

            modelBuilder.Entity("GoodToCode.Chronology.Models.TimeCycle", b =>
                {
                    b.Property<Guid>("TimeCycleKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Days")
                        .HasColumnType("int");

                    b.Property<int>("Interval")
                        .HasColumnType("int");

                    b.Property<string>("TimeCycleDescription")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("TimeCycleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("TimeCycleKey");

                    b.HasIndex("TimeCycleKey")
                        .IsUnique()
                        .HasName("IX_TimeCycle_Key");

                    b.ToTable("TimeCycle","Chronology");
                });

            modelBuilder.Entity("GoodToCode.Chronology.Models.TimeRange", b =>
                {
                    b.Property<Guid>("TimeRangeKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BeginDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime");

                    b.HasKey("TimeRangeKey");

                    b.HasIndex("TimeRangeKey")
                        .IsUnique();

                    b.HasIndex("BeginDate", "EndDate")
                        .IsUnique()
                        .HasName("IX_TimeRange_All");

                    b.ToTable("TimeRange","Chronology");
                });

            modelBuilder.Entity("GoodToCode.Chronology.Models.TimeRecurring", b =>
                {
                    b.Property<Guid>("TimeRecurringKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BeginDay")
                        .HasColumnType("int");

                    b.Property<DateTime>("BeginTime")
                        .HasColumnType("datetime");

                    b.Property<int>("EndDay")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime");

                    b.Property<int>("Interval")
                        .HasColumnType("int");

                    b.Property<Guid>("TimeCycleKey")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TimeRecurringKey");

                    b.HasIndex("TimeRecurringKey")
                        .IsUnique();

                    b.HasIndex("BeginDay", "EndDay", "BeginTime", "EndTime", "Interval", "TimeCycleKey")
                        .IsUnique()
                        .HasName("IX_TimeRecurring_All");

                    b.ToTable("TimeRecurring","Chronology");
                });

            modelBuilder.Entity("GoodToCode.Chronology.Models.TimeType", b =>
                {
                    b.Property<Guid>("TimeTypeKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TimeBehavior")
                        .HasColumnType("int");

                    b.Property<string>("TimeTypeDescription")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("TimeTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("TimeTypeKey");

                    b.HasIndex("TimeTypeKey")
                        .IsUnique()
                        .HasName("IX_TimeType_Key");

                    b.ToTable("TimeType","Chronology");
                });

            modelBuilder.Entity("GoodToCode.Chronology.Models.VentureSchedule", b =>
                {
                    b.Property<Guid>("VentureScheduleKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ScheduleKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ScheduleTypeKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("VentureKey")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("VentureScheduleKey");

                    b.HasIndex("VentureScheduleKey")
                        .IsUnique()
                        .HasName("IX_VentureSchedule_Key");

                    b.HasIndex("VentureKey", "ScheduleKey")
                        .IsUnique()
                        .HasName("IX_VentureSchedule_All");

                    b.ToTable("VentureSchedule","Chronology");
                });

            modelBuilder.Entity("GoodToCode.Chronology.Models.VentureTimeRecurring", b =>
                {
                    b.Property<Guid>("VentureTimeRecurringKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("TimeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<Guid>("TimeRecurringKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TimeTypeKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("VentureKey")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("VentureTimeRecurringKey");

                    b.HasIndex("VentureTimeRecurringKey")
                        .IsUnique()
                        .HasName("IX_VentureTimeRecurring_Venture");

                    b.HasIndex("VentureKey", "TimeRecurringKey")
                        .IsUnique()
                        .HasName("IX_VentureTimeRecurring_All");

                    b.ToTable("VentureTimeRecurring","Chronology");
                });
#pragma warning restore 612, 618
        }
    }
}