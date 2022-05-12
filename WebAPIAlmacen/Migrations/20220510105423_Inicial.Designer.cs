﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPIAlmacen;

#nullable disable

namespace WebAPIAlmacen.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220510105423_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DistribuidorProducto", b =>
                {
                    b.Property<int>("DistribuidoresId")
                        .HasColumnType("int");

                    b.Property<int>("ProductosId")
                        .HasColumnType("int");

                    b.HasKey("DistribuidoresId", "ProductosId");

                    b.HasIndex("ProductosId");

                    b.ToTable("DistribuidorProducto");
                });

            modelBuilder.Entity("WebAPIAlmacen.Entidades.Distribuidor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Distribuidores");
                });

            modelBuilder.Entity("WebAPIAlmacen.Entidades.DistribuidorProducto", b =>
                {
                    b.Property<int>("DistribuidorId")
                        .HasColumnType("int");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int>("UnidadesVendidas")
                        .HasColumnType("int");

                    b.HasKey("DistribuidorId", "ProductoId");

                    b.HasIndex("ProductoId");

                    b.ToTable("DistribuidoresProductos");
                });

            modelBuilder.Entity("WebAPIAlmacen.Entidades.Familia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Familias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Tecnología"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Moda"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Hogar"
                        });
                });

            modelBuilder.Entity("WebAPIAlmacen.Entidades.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Descatalogado")
                        .HasColumnType("bit");

                    b.Property<int>("FamiliaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("date");

                    b.Property<string>("FotoURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<decimal>("Precio")
                        .HasPrecision(9, 2)
                        .HasColumnType("decimal(9,2)");

                    b.HasKey("Id");

                    b.HasIndex("FamiliaId");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descatalogado = false,
                            FamiliaId = 1,
                            FechaAlta = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Portátil",
                            Precio = 1000m
                        },
                        new
                        {
                            Id = 2,
                            Descatalogado = false,
                            FamiliaId = 1,
                            FechaAlta = new DateTime(2020, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Impresora",
                            Precio = 100m
                        },
                        new
                        {
                            Id = 3,
                            Descatalogado = true,
                            FamiliaId = 1,
                            FechaAlta = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "IBM",
                            Precio = 1800m
                        },
                        new
                        {
                            Id = 4,
                            Descatalogado = false,
                            FamiliaId = 2,
                            FechaAlta = new DateTime(2021, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Camisa",
                            Precio = 10m
                        },
                        new
                        {
                            Id = 5,
                            Descatalogado = false,
                            FamiliaId = 2,
                            FechaAlta = new DateTime(2020, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Pantalón",
                            Precio = 20m
                        },
                        new
                        {
                            Id = 6,
                            Descatalogado = true,
                            FamiliaId = 2,
                            FechaAlta = new DateTime(2010, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Traje",
                            Precio = 150m
                        },
                        new
                        {
                            Id = 7,
                            Descatalogado = false,
                            FamiliaId = 3,
                            FechaAlta = new DateTime(2018, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Lavadora",
                            Precio = 800m
                        },
                        new
                        {
                            Id = 8,
                            Descatalogado = false,
                            FamiliaId = 3,
                            FechaAlta = new DateTime(2017, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Microondas",
                            Precio = 120m
                        },
                        new
                        {
                            Id = 9,
                            Descatalogado = true,
                            FamiliaId = 3,
                            FechaAlta = new DateTime(2008, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Cafetera",
                            Precio = 150m
                        });
                });

            modelBuilder.Entity("WebAPIAlmacen.Entidades.UbicacionProducto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Estateria")
                        .HasColumnType("int");

                    b.Property<int>("Pasillo")
                        .HasColumnType("int");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductoId")
                        .IsUnique();

                    b.ToTable("UbicacionesProductos");
                });

            modelBuilder.Entity("DistribuidorProducto", b =>
                {
                    b.HasOne("WebAPIAlmacen.Entidades.Distribuidor", null)
                        .WithMany()
                        .HasForeignKey("DistribuidoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPIAlmacen.Entidades.Producto", null)
                        .WithMany()
                        .HasForeignKey("ProductosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebAPIAlmacen.Entidades.DistribuidorProducto", b =>
                {
                    b.HasOne("WebAPIAlmacen.Entidades.Distribuidor", "Distribuidor")
                        .WithMany("DistribuidoresProductos")
                        .HasForeignKey("DistribuidorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPIAlmacen.Entidades.Producto", "Producto")
                        .WithMany("DistribuidoresProductos")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Distribuidor");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("WebAPIAlmacen.Entidades.Producto", b =>
                {
                    b.HasOne("WebAPIAlmacen.Entidades.Familia", "Familia")
                        .WithMany("Productos")
                        .HasForeignKey("FamiliaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Familia");
                });

            modelBuilder.Entity("WebAPIAlmacen.Entidades.UbicacionProducto", b =>
                {
                    b.HasOne("WebAPIAlmacen.Entidades.Producto", null)
                        .WithOne("UbicacionProducto")
                        .HasForeignKey("WebAPIAlmacen.Entidades.UbicacionProducto", "ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebAPIAlmacen.Entidades.Distribuidor", b =>
                {
                    b.Navigation("DistribuidoresProductos");
                });

            modelBuilder.Entity("WebAPIAlmacen.Entidades.Familia", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("WebAPIAlmacen.Entidades.Producto", b =>
                {
                    b.Navigation("DistribuidoresProductos");

                    b.Navigation("UbicacionProducto");
                });
#pragma warning restore 612, 618
        }
    }
}
