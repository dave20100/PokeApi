﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PokeApi.Models;

namespace PokeApi.Migrations
{
    [DbContext(typeof(PokedexContext))]
    [Migration("20190709202040_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("PokeApi.Models.Move", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DamageTypeId");

                    b.Property<string>("Name");

                    b.Property<int?>("PokemonId");

                    b.HasKey("Id");

                    b.HasIndex("DamageTypeId");

                    b.HasIndex("PokemonId");

                    b.ToTable("Move");
                });

            modelBuilder.Entity("PokeApi.Models.Pokedex", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Pokedexes");
                });

            modelBuilder.Entity("PokeApi.Models.Pokemon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Attack");

                    b.Property<int>("Defense");

                    b.Property<int?>("FirstTypeId");

                    b.Property<int>("Hp");

                    b.Property<string>("Name");

                    b.Property<int?>("PokedexId");

                    b.Property<int?>("PokemonId");

                    b.Property<int?>("SecondTypeId");

                    b.Property<int>("Sp_Atk");

                    b.Property<int>("Sp_Def");

                    b.Property<int>("Speed");

                    b.HasKey("Id");

                    b.HasIndex("FirstTypeId");

                    b.HasIndex("PokedexId");

                    b.HasIndex("PokemonId");

                    b.HasIndex("SecondTypeId");

                    b.ToTable("Pokemon");
                });

            modelBuilder.Entity("PokeApi.Models.PokeType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("PokeType");
                });

            modelBuilder.Entity("PokeApi.Models.Move", b =>
                {
                    b.HasOne("PokeApi.Models.PokeType", "DamageType")
                        .WithMany()
                        .HasForeignKey("DamageTypeId");

                    b.HasOne("PokeApi.Models.Pokemon")
                        .WithMany("Moves")
                        .HasForeignKey("PokemonId");
                });

            modelBuilder.Entity("PokeApi.Models.Pokemon", b =>
                {
                    b.HasOne("PokeApi.Models.PokeType", "FirstType")
                        .WithMany()
                        .HasForeignKey("FirstTypeId");

                    b.HasOne("PokeApi.Models.Pokedex")
                        .WithMany("Pokemons")
                        .HasForeignKey("PokedexId");

                    b.HasOne("PokeApi.Models.Pokemon")
                        .WithMany("Evolutions")
                        .HasForeignKey("PokemonId");

                    b.HasOne("PokeApi.Models.PokeType", "SecondType")
                        .WithMany()
                        .HasForeignKey("SecondTypeId");
                });
#pragma warning restore 612, 618
        }
    }
}
