﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetCare.API.Data;

#nullable disable

namespace PetCare.API.Migrations
{
    [DbContext(typeof(PetDbContext))]
    partial class PetDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PetCare.API.Models.Cita", b =>
                {
                    b.Property<int>("IdCita")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCita"));

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdMascota")
                        .HasColumnType("int");

                    b.Property<int>("IdServicio")
                        .HasColumnType("int");

                    b.Property<int>("MascotaIdMascota")
                        .HasColumnType("int");

                    b.Property<int>("ServicioIdServicio")
                        .HasColumnType("int");

                    b.HasKey("IdCita");

                    b.HasIndex("MascotaIdMascota");

                    b.HasIndex("ServicioIdServicio");

                    b.ToTable("Citas");
                });

            modelBuilder.Entity("PetCare.API.Models.CitaProducto", b =>
                {
                    b.Property<int>("IdCita")
                        .HasColumnType("int");

                    b.Property<int>("IdProducto")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.HasKey("IdCita", "IdProducto");

                    b.HasIndex("IdProducto");

                    b.ToTable("CitaProductos");
                });

            modelBuilder.Entity("PetCare.API.Models.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("IdCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("PetCare.API.Models.Mascota", b =>
                {
                    b.Property<int>("IdMascota")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMascota"));

                    b.Property<int>("ClienteIdCliente")
                        .HasColumnType("int");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Especie")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Raza")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdMascota");

                    b.HasIndex("ClienteIdCliente");

                    b.ToTable("Mascotas");
                });

            modelBuilder.Entity("PetCare.API.Models.Producto", b =>
                {
                    b.Property<int>("IdProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProducto"));

                    b.Property<int?>("IdProveedor")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProveedorIdProveedor")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("IdProducto");

                    b.HasIndex("ProveedorIdProveedor");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("PetCare.API.Models.Proveedor", b =>
                {
                    b.Property<int>("IdProveedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProveedor"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("IdProveedor");

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("PetCare.API.Models.Servicio", b =>
                {
                    b.Property<int>("IdServicio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdServicio"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdServicio");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("PetCare.API.Models.Cita", b =>
                {
                    b.HasOne("PetCare.API.Models.Mascota", "Mascota")
                        .WithMany("Citas")
                        .HasForeignKey("MascotaIdMascota")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetCare.API.Models.Servicio", "Servicio")
                        .WithMany("Citas")
                        .HasForeignKey("ServicioIdServicio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mascota");

                    b.Navigation("Servicio");
                });

            modelBuilder.Entity("PetCare.API.Models.CitaProducto", b =>
                {
                    b.HasOne("PetCare.API.Models.Cita", "Cita")
                        .WithMany("CitaProductos")
                        .HasForeignKey("IdCita")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetCare.API.Models.Producto", "Producto")
                        .WithMany("CitaProductos")
                        .HasForeignKey("IdProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cita");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("PetCare.API.Models.Mascota", b =>
                {
                    b.HasOne("PetCare.API.Models.Cliente", "Cliente")
                        .WithMany("Mascotas")
                        .HasForeignKey("ClienteIdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("PetCare.API.Models.Producto", b =>
                {
                    b.HasOne("PetCare.API.Models.Proveedor", "Proveedor")
                        .WithMany("Productos")
                        .HasForeignKey("ProveedorIdProveedor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proveedor");
                });

            modelBuilder.Entity("PetCare.API.Models.Cita", b =>
                {
                    b.Navigation("CitaProductos");
                });

            modelBuilder.Entity("PetCare.API.Models.Cliente", b =>
                {
                    b.Navigation("Mascotas");
                });

            modelBuilder.Entity("PetCare.API.Models.Mascota", b =>
                {
                    b.Navigation("Citas");
                });

            modelBuilder.Entity("PetCare.API.Models.Producto", b =>
                {
                    b.Navigation("CitaProductos");
                });

            modelBuilder.Entity("PetCare.API.Models.Proveedor", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("PetCare.API.Models.Servicio", b =>
                {
                    b.Navigation("Citas");
                });
#pragma warning restore 612, 618
        }
    }
}
