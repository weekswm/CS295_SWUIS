﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StarWarsUniverseInfoSite.Models;

namespace StarWarsUniverseInfoSite.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20191212212950__initia")]
    partial class _initia
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("StarWarsUniverseInfoSite.Models.Planet", b =>
                {
                    b.Property<int>("PlanetID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Climate");

                    b.Property<int>("Diameter");

                    b.Property<int>("Gravity");

                    b.Property<int>("OrbitalPeriod");

                    b.Property<int?>("PlanetID1");

                    b.Property<string>("PlanetName");

                    b.Property<int>("RotationalPeriod");

                    b.Property<int?>("SpeciesID");

                    b.HasKey("PlanetID");

                    b.HasIndex("PlanetID1");

                    b.HasIndex("SpeciesID");

                    b.ToTable("Planets");
                });

            modelBuilder.Entity("StarWarsUniverseInfoSite.Models.Species", b =>
                {
                    b.Property<int>("SpeciesID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AvgHeight");

                    b.Property<int>("AvgLifeSpan");

                    b.Property<string>("Classification");

                    b.Property<string>("Designation");

                    b.Property<int?>("HomeworldPlanetID");

                    b.Property<string>("Language");

                    b.Property<int?>("SpeciesID1");

                    b.Property<string>("SpeciesName");

                    b.HasKey("SpeciesID");

                    b.HasIndex("HomeworldPlanetID");

                    b.HasIndex("SpeciesID1");

                    b.ToTable("SWSpecies");
                });

            modelBuilder.Entity("StarWarsUniverseInfoSite.Models.Starship", b =>
                {
                    b.Property<int>("StarshipID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CargoCapacity");

                    b.Property<string>("Class");

                    b.Property<int>("Consumables");

                    b.Property<int>("Cost");

                    b.Property<int>("Crew");

                    b.Property<double>("HyperdriveRating");

                    b.Property<double>("Length");

                    b.Property<string>("Manufacturer");

                    b.Property<string>("MaxAtmoshperingSpeed");

                    b.Property<string>("Model");

                    b.Property<string>("Name");

                    b.Property<int>("Passengers");

                    b.Property<int?>("StarshipID1");

                    b.HasKey("StarshipID");

                    b.HasIndex("StarshipID1");

                    b.ToTable("Starships");
                });

            modelBuilder.Entity("StarWarsUniverseInfoSite.Models.Vehicle", b =>
                {
                    b.Property<int>("VehicleID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CargoCapacity");

                    b.Property<int>("Class");

                    b.Property<int>("Consumables");

                    b.Property<int>("Cost");

                    b.Property<double>("Length");

                    b.Property<string>("Manufacturer");

                    b.Property<string>("MaxAtmoshperingSpeed");

                    b.Property<string>("Model");

                    b.Property<string>("Name");

                    b.Property<int>("Passengers");

                    b.Property<int?>("VehicleID1");

                    b.HasKey("VehicleID");

                    b.HasIndex("VehicleID1");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("StarWarsUniverseInfoSite.Models.Planet", b =>
                {
                    b.HasOne("StarWarsUniverseInfoSite.Models.Planet")
                        .WithMany("Planets")
                        .HasForeignKey("PlanetID1");

                    b.HasOne("StarWarsUniverseInfoSite.Models.Species")
                        .WithMany("Planets")
                        .HasForeignKey("SpeciesID");
                });

            modelBuilder.Entity("StarWarsUniverseInfoSite.Models.Species", b =>
                {
                    b.HasOne("StarWarsUniverseInfoSite.Models.Planet", "Homeworld")
                        .WithMany()
                        .HasForeignKey("HomeworldPlanetID");

                    b.HasOne("StarWarsUniverseInfoSite.Models.Species")
                        .WithMany("SWSpecies")
                        .HasForeignKey("SpeciesID1");
                });

            modelBuilder.Entity("StarWarsUniverseInfoSite.Models.Starship", b =>
                {
                    b.HasOne("StarWarsUniverseInfoSite.Models.Starship")
                        .WithMany("Starships")
                        .HasForeignKey("StarshipID1");
                });

            modelBuilder.Entity("StarWarsUniverseInfoSite.Models.Vehicle", b =>
                {
                    b.HasOne("StarWarsUniverseInfoSite.Models.Vehicle")
                        .WithMany("Vehicles")
                        .HasForeignKey("VehicleID1");
                });
#pragma warning restore 612, 618
        }
    }
}
