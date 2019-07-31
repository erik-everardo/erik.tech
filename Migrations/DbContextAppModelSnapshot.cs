﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using erik_tech.Models;

namespace erik_tech.Migrations
{
    [DbContext(typeof(DbContextApp))]
    partial class DbContextAppModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("erik_tech.Models.Articulo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("autor_id");

                    b.Property<string>("cuerpo");

                    b.Property<string>("encabezado");

                    b.Property<DateTime>("fecha_publicacion");

                    b.Property<string>("titulo_publicacion");

                    b.HasKey("Id");

                    b.ToTable("articulo");
                });

            modelBuilder.Entity("erik_tech.Models.Cuenta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("email");

                    b.Property<string>("password");

                    b.Property<string>("username");

                    b.HasKey("Id");

                    b.ToTable("cuenta");
                });

            modelBuilder.Entity("erik_tech.Models.android", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("id_articulo");

                    b.HasKey("Id");

                    b.ToTable("android");
                });

            modelBuilder.Entity("erik_tech.Models.desarrollo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("id_articulo");

                    b.HasKey("Id");

                    b.ToTable("desarrollo");
                });

            modelBuilder.Entity("erik_tech.Models.gaming", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("id_articulo");

                    b.HasKey("Id");

                    b.ToTable("gaming");
                });

            modelBuilder.Entity("erik_tech.Models.hardware", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("id_articulo");

                    b.HasKey("Id");

                    b.ToTable("hardware");
                });

            modelBuilder.Entity("erik_tech.Models.linux", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("id_articulo");

                    b.HasKey("Id");

                    b.ToTable("linux");
                });

            modelBuilder.Entity("erik_tech.Models.macos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("id_articulo");

                    b.HasKey("Id");

                    b.ToTable("macos");
                });

            modelBuilder.Entity("erik_tech.Models.sinCategoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("id_articulo");

                    b.HasKey("Id");

                    b.ToTable("sin_categoria");
                });

            modelBuilder.Entity("erik_tech.Models.windows", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("id_articulo");

                    b.HasKey("Id");

                    b.ToTable("windows");
                });
#pragma warning restore 612, 618
        }
    }
}
