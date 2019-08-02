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

                    b.Property<bool>("Android");

                    b.Property<bool>("Desarrollo");

                    b.Property<bool>("Gaming");

                    b.Property<bool>("Hardware");

                    b.Property<bool>("Linux");

                    b.Property<bool>("Macos");

                    b.Property<bool>("Otra");

                    b.Property<bool>("Windows");

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
#pragma warning restore 612, 618
        }
    }
}
