﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Model;

namespace Model.Migrations
{
    [DbContext(typeof(SurveyContext))]
    partial class SurveyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.Batch", b =>
                {
                    b.Property<int>("BatchID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BatchCode");

                    b.HasKey("BatchID");

                    b.ToTable("Batch");
                });

            modelBuilder.Entity("Model.Coordinates", b =>
                {
                    b.Property<int>("LocationID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<int>("SurveyIndex");

                    b.HasKey("LocationID");

                    b.ToTable("Coordinates");
                });

            modelBuilder.Entity("Model.Fish", b =>
                {
                    b.Property<string>("ScientificName")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CommonName");

                    b.Property<string>("Family");

                    b.Property<int>("FishID");

                    b.Property<int>("TrophicID");

                    b.HasKey("ScientificName");

                    b.ToTable("Fish");
                });

            modelBuilder.Entity("Model.FishData", b =>
                {
                    b.Property<int>("FishID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FishCount");

                    b.Property<double>("FishLength");

                    b.Property<int>("LocationID");

                    b.Property<int>("StructureID");

                    b.HasKey("FishID");

                    b.ToTable("FishData");
                });

            modelBuilder.Entity("Model.Location", b =>
                {
                    b.Property<string>("StudyArea")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LocationID");

                    b.Property<int>("RegionID");

                    b.Property<string>("SubRegion");

                    b.HasKey("StudyArea");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("Model.Region", b =>
                {
                    b.Property<int>("RegionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Management");

                    b.Property<string>("RegionName");

                    b.HasKey("RegionID");

                    b.ToTable("Region");
                });

            modelBuilder.Entity("Model.Structure", b =>
                {
                    b.Property<int>("StructureID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StructureType");

                    b.HasKey("StructureID");

                    b.ToTable("Structure");
                });

            modelBuilder.Entity("Model.SurveyData", b =>
                {
                    b.Property<int>("SurveyDate")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BatchID");

                    b.Property<string>("ScientificName");

                    b.Property<int>("SurveyIndex");

                    b.HasKey("SurveyDate");

                    b.ToTable("SurveyData");
                });

            modelBuilder.Entity("Model.Trophic", b =>
                {
                    b.Property<int>("TrophicID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TrophicCode")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.HasKey("TrophicID");

                    b.ToTable("Trophic");
                });
#pragma warning restore 612, 618
        }
    }
}