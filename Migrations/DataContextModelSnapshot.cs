// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FINMUE.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("FINMUE.Models.Casa", b =>
                {
                    b.Property<int>("CasaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("InmuebleId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MetrosCuadrados")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NumeroDeCasa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CasaId");

                    b.HasIndex("InmuebleId");

                    b.ToTable("Casa");
                });

            modelBuilder.Entity("FINMUE.Models.Inmueble", b =>
                {
                    b.Property<int>("InmuebleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Costo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Domicilio")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("FechaActualizacion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoDeInmueble")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("InmuebleId");

                    b.ToTable("Inmueble");
                });

            modelBuilder.Entity("FINMUE.Models.Inquilino", b =>
                {
                    b.Property<int>("InquilinoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaDeAlta")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaDeBaja")
                        .HasColumnType("TEXT");

                    b.Property<string>("Identificacion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("InmuebleId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("InquilinoId");

                    b.HasIndex("InmuebleId");

                    b.ToTable("Inquilino");
                });

            modelBuilder.Entity("FINMUE.Models.Local", b =>
                {
                    b.Property<int>("LocalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("InmuebleId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MetrosCuadrados")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NumeroDeLocal")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LocalId");

                    b.HasIndex("InmuebleId");

                    b.ToTable("Local");
                });

            modelBuilder.Entity("FINMUE.Models.Movimiento", b =>
                {
                    b.Property<int>("MovimientoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Concepto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("FechaDeMovimiento")
                        .HasColumnType("TEXT");

                    b.Property<int>("InmuebleId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Monto")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MovimientoId");

                    b.HasIndex("InmuebleId");

                    b.ToTable("Movimiento");
                });

            modelBuilder.Entity("FINMUE.Models.Piso", b =>
                {
                    b.Property<int>("PisoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("InmuebleId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MetrosCuadrados")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumeroDePiso")
                        .HasColumnType("INTEGER");

                    b.HasKey("PisoId");

                    b.HasIndex("InmuebleId");

                    b.ToTable("Piso");
                });

            modelBuilder.Entity("FINMUE.Models.Recibo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("CargoAgua")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("CargoElectricidad")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("CargoGas")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("CargoTelefono")
                        .HasColumnType("TEXT");

                    b.Property<string>("Concepto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaEmision")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Importe")
                        .HasColumnType("TEXT");

                    b.Property<int>("InmuebleId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("InquilinoId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MovimientoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ValorUnicoRecibo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("InquilinoId");

                    b.HasIndex("MovimientoId");

                    b.ToTable("Recibo");
                });

            modelBuilder.Entity("FINMUE.Models.Casa", b =>
                {
                    b.HasOne("FINMUE.Models.Inmueble", null)
                        .WithMany("ListaCasas")
                        .HasForeignKey("InmuebleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FINMUE.Models.Inquilino", b =>
                {
                    b.HasOne("FINMUE.Models.Inmueble", "Inmueble")
                        .WithMany("ListaInquilinos")
                        .HasForeignKey("InmuebleId");

                    b.Navigation("Inmueble");
                });

            modelBuilder.Entity("FINMUE.Models.Local", b =>
                {
                    b.HasOne("FINMUE.Models.Inmueble", null)
                        .WithMany("ListaLocales")
                        .HasForeignKey("InmuebleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FINMUE.Models.Movimiento", b =>
                {
                    b.HasOne("FINMUE.Models.Inmueble", "Inmueble")
                        .WithMany("ListaMovimientos")
                        .HasForeignKey("InmuebleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inmueble");
                });

            modelBuilder.Entity("FINMUE.Models.Piso", b =>
                {
                    b.HasOne("FINMUE.Models.Inmueble", null)
                        .WithMany("ListaPisos")
                        .HasForeignKey("InmuebleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FINMUE.Models.Recibo", b =>
                {
                    b.HasOne("FINMUE.Models.Inquilino", null)
                        .WithMany("ListaRecibos")
                        .HasForeignKey("InquilinoId");

                    b.HasOne("FINMUE.Models.Movimiento", null)
                        .WithMany("Recibos")
                        .HasForeignKey("MovimientoId");
                });

            modelBuilder.Entity("FINMUE.Models.Inmueble", b =>
                {
                    b.Navigation("ListaCasas");

                    b.Navigation("ListaInquilinos");

                    b.Navigation("ListaLocales");

                    b.Navigation("ListaMovimientos");

                    b.Navigation("ListaPisos");
                });

            modelBuilder.Entity("FINMUE.Models.Inquilino", b =>
                {
                    b.Navigation("ListaRecibos");
                });

            modelBuilder.Entity("FINMUE.Models.Movimiento", b =>
                {
                    b.Navigation("Recibos");
                });
#pragma warning restore 612, 618
        }
    }
}
