﻿// <auto-generated />
using System;
using AppWebSistemaClinica.C1Model.C1ModelContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppWebSistemaClinica.Migrations
{
    [DbContext(typeof(C1ModelContextContexto))]
    [Migration("20230826193314_gru")]
    partial class gru
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AppWebSistemaClinica.C1Model.C1ModelCita", b =>
                {
                    b.Property<int>("IdCita")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCita"));

                    b.Property<string>("EstadoCita")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCita")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HoraFinCita")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HoraInicioCita")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdClinica")
                        .HasColumnType("int");

                    b.Property<int>("IdMedico")
                        .HasColumnType("int");

                    b.HasKey("IdCita");

                    b.HasIndex("IdClinica");

                    b.HasIndex("IdMedico");

                    b.ToTable("CITAS");
                });

            modelBuilder.Entity("AppWebSistemaClinica.C1Model.C1ModelClinica", b =>
                {
                    b.Property<int>("IdClinica")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdClinica"));

                    b.Property<int>("CapacidadClinica")
                        .HasColumnType("int");

                    b.Property<string>("NombreClinica")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PrecioConsultaClinica")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UbicacionClinica")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdClinica");

                    b.ToTable("CLINICAS");
                });

            modelBuilder.Entity("AppWebSistemaClinica.C1Model.C1ModelDetalleFactura", b =>
                {
                    b.Property<int>("IdDetalleFactura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDetalleFactura"));

                    b.Property<string>("DescripcionDetalleFactura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCita")
                        .HasColumnType("int");

                    b.Property<int>("IdFactura")
                        .HasColumnType("int");

                    b.Property<decimal>("IvaDetalleFactura")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OtroImpuesto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PrecioTotalDetalleFactura")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PrecioUnitarioDetalleFactura")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdDetalleFactura");

                    b.HasIndex("IdCita");

                    b.HasIndex("IdFactura");

                    b.ToTable("DETALLESFACTURAS");
                });

            modelBuilder.Entity("AppWebSistemaClinica.C1Model.C1ModelEquipoMedico", b =>
                {
                    b.Property<int>("IdEquipoMedico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEquipoMedico"));

                    b.Property<string>("DescripcionEquipoMedico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreEquipoMedico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEquipoMedico");

                    b.ToTable("EQUIPOSMEDICOS");
                });

            modelBuilder.Entity("AppWebSistemaClinica.C1Model.C1ModelEquipoMedicoClinica", b =>
                {
                    b.Property<int>("IdEquipoMedico")
                        .HasColumnType("int");

                    b.Property<int>("IdClinica")
                        .HasColumnType("int");

                    b.HasKey("IdEquipoMedico", "IdClinica");

                    b.HasIndex("IdClinica");

                    b.ToTable("EQUIPOSMEDICOSCLINICAS");
                });

            modelBuilder.Entity("AppWebSistemaClinica.C1Model.C1ModelEspecialidad", b =>
                {
                    b.Property<int>("IdEspecialidad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEspecialidad"));

                    b.Property<string>("DescripcionEspecialidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PrecioEspecialidad")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdEspecialidad");

                    b.ToTable("ESPECIALIDADES");
                });

            modelBuilder.Entity("AppWebSistemaClinica.C1Model.C1ModelFactura", b =>
                {
                    b.Property<int>("IdFactura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFactura"));

                    b.Property<string>("EstadoPagoFactura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaFactura")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdPaciente")
                        .HasColumnType("int");

                    b.Property<int>("IdPago")
                        .HasColumnType("int");

                    b.Property<decimal>("MontoTotalFctura")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdFactura");

                    b.HasIndex("IdPaciente");

                    b.HasIndex("IdPago");

                    b.ToTable("FACTURAS");
                });

            modelBuilder.Entity("AppWebSistemaClinica.C1Model.C1ModelHistorialClinico", b =>
                {
                    b.Property<int>("Id_HistorialClinico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_HistorialClinico"));

                    b.Property<string>("DescripcionHisClinico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdPaciente")
                        .HasColumnType("int");

                    b.Property<string>("ListEnfermedadesRecientHisClinico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NotasMedicasHisClinico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_HistorialClinico");

                    b.HasIndex("IdPaciente");

                    b.ToTable("HISTORIALESCLINICOS");
                });

            modelBuilder.Entity("AppWebSistemaClinica.C1Model.C1ModelMedico", b =>
                {
                    b.Property<int>("IdMedico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMedico"));

                    b.Property<string>("ApellidoMedico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorreoMedico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HorarioMedico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdEspecialidad")
                        .HasColumnType("int");

                    b.Property<string>("NombreMedico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TelefonoMedico")
                        .HasColumnType("int");

                    b.HasKey("IdMedico");

                    b.HasIndex("IdEspecialidad");

                    b.ToTable("MEDICOS");
                });

            modelBuilder.Entity("AppWebSistemaClinica.C1Model.C1ModelPaciente", b =>
                {
                    b.Property<int>("idPaciente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idPaciente"));

                    b.Property<string>("ApellidoPaciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CedulaPaciente")
                        .HasColumnType("int");

                    b.Property<string>("CorreoPaciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EdadPaciente")
                        .HasColumnType("int");

                    b.Property<string>("EstadoCivilPaciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimientoPaciente")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombrePaciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TelefonoPaciente")
                        .HasColumnType("int");

                    b.HasKey("idPaciente");

                    b.ToTable("PACIENTES");
                });

            modelBuilder.Entity("AppWebSistemaClinica.C1Model.C1ModelPago", b =>
                {
                    b.Property<int>("IdPago")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPago"));

                    b.Property<string>("DescripcionPago")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FormaPago")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPago");

                    b.ToTable("PAGOS");
                });

            modelBuilder.Entity("AppWebSistemaClinica.C1Model.C1ModelPerfil", b =>
                {
                    b.Property<int>("IdPerfil")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPerfil"));

                    b.Property<int>("IdRol")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.HasKey("IdPerfil");

                    b.HasIndex("IdRol");

                    b.HasIndex("IdUsuario");

                    b.ToTable("PERFILES");
                });

            modelBuilder.Entity("AppWebSistemaClinica.C1Model.C1ModelRegistroMedico", b =>
                {
                    b.Property<int>("IdRegistroMedico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRegistroMedico"));

                    b.Property<int>("C1ModelHistorialClinicoId_HistorialClinico")
                        .HasColumnType("int");

                    b.Property<string>("DetallesRegistroMedico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdHistorialClinico")
                        .HasColumnType("int");

                    b.HasKey("IdRegistroMedico");

                    b.HasIndex("C1ModelHistorialClinicoId_HistorialClinico");

                    b.ToTable("REGISTROSMEDICOS");
                });

            modelBuilder.Entity("AppWebSistemaClinica.C1Model.C1ModelRol", b =>
                {
                    b.Property<int>("IdRol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRol"));

                    b.Property<string>("DescripcionRol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreRol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdRol");

                    b.ToTable("ROLES");
                });

            modelBuilder.Entity("AppWebSistemaClinica.C1Model.C1ModelUsuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUsuario"));

                    b.Property<string>("ApellidoUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContrasenaUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorreoElectronico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUsuario");

                    b.ToTable("USUARIOS");
                });

            modelBuilder.Entity("AppWebSistemaClinica.C1Model.C1ModelCita", b =>
                {
                    b.HasOne("AppWebSistemaClinica.C1Model.C1ModelClinica", "C1ModelClinica")
                        .WithMany("C1ModelCita")
                        .HasForeignKey("IdClinica")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppWebSistemaClinica.C1Model.C1ModelMedico", "C1ModelMedico")
                        .WithMany()
                        .HasForeignKey("IdMedico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("C1ModelClinica");

                    b.Navigation("C1ModelMedico");
                });

            modelBuilder.Entity("AppWebSistemaClinica.C1Model.C1ModelDetalleFactura", b =>
                {
                    b.HasOne("AppWebSistemaClinica.C1Model.C1ModelCita", "C1ModelCita")
                        .WithMany("C1ModelDetalleFactura")
                        .HasForeignKey("IdCita")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppWebSistemaClinica.C1Model.C1ModelFactura", "C1ModelFactura")
                        .WithMany("C1ModelDetalleFactura")
                        .HasForeignKey("IdFactura")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("C1ModelCita");

                    b.Navigation("C1ModelFactura");
                });

            modelBuilder.Entity("AppWebSistemaClinica.C1Model.C1ModelEquipoMedicoClinica", b =>
                {
                    b.HasOne("AppWebSistemaClinica.C1Model.C1ModelClinica", "C1ModelClinica")
                        .WithMany("C1ModelEquipoMedicoClinica")
                        .HasForeignKey("IdClinica")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppWebSistemaClinica.C1Model.C1ModelEquipoMedico", "C1ModelEquipoMedico")
                        .WithMany("C1ModelEquipoMedicoClinica")
                        .HasForeignKey("IdEquipoMedico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("C1ModelClinica");

                    b.Navigation("C1ModelEquipoMedico");
                });

            modelBuilder.Entity("AppWebSistemaClinica.C1Model.C1ModelFactura", b =>
                {
                    b.HasOne("AppWebSistemaClinica.C1Model.C1ModelPaciente", "C1ModelPaciente")
                        .WithMany("C1ModelFactura")
                        .HasForeignKey("IdPaciente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppWebSistemaClinica.C1Model.C1ModelPago", "C1ModelPago")
                        .WithMany("C1ModelFactura")
                        .HasForeignKey("IdPago")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("C1ModelPaciente");

                    b.Navigation("C1ModelPago");
                });

            modelBuilder.Entity("AppWebSistemaClinica.C1Model.C1ModelHistorialClinico", b =>
                {
                    b.HasOne("AppWebSistemaClinica.C1Model.C1ModelPaciente", "C1ModelPaciente")
                        .WithMany("C1ModelHistorialClinico")
                        .HasForeignKey("IdPaciente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("C1ModelPaciente");
                });

            modelBuilder.Entity("AppWebSistemaClinica.C1Model.C1ModelMedico", b =>
                {
                    b.HasOne("AppWebSistemaClinica.C1Model.C1ModelEspecialidad", "C1ModelEspecialidad")
                        .WithMany("C1ModelMedico")
                        .HasForeignKey("IdEspecialidad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("C1ModelEspecialidad");
                });

            modelBuilder.Entity("AppWebSistemaClinica.C1Model.C1ModelPerfil", b =>
                {
                    b.HasOne("AppWebSistemaClinica.C1Model.C1ModelRol", "C1ModelRol")
                        .WithMany("C1ModelPerfil")
                        .HasForeignKey("IdRol")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppWebSistemaClinica.C1Model.C1ModelUsuario", "C1ModelUsuario")
                        .WithMany("C1ModelPerfil")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("C1ModelRol");

                    b.Navigation("C1ModelUsuario");
                });

            modelBuilder.Entity("AppWebSistemaClinica.C1Model.C1ModelRegistroMedico", b =>
                {
                    b.HasOne("AppWebSistemaClinica.C1Model.C1ModelHistorialClinico", "C1ModelHistorialClinico")
                        .WithMany("C1ModelRegistroMedico")
                        .HasForeignKey("C1ModelHistorialClinicoId_HistorialClinico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("C1ModelHistorialClinico");
                });

            modelBuilder.Entity("AppWebSistemaClinica.C1Model.C1ModelCita", b =>
                {
                    b.Navigation("C1ModelDetalleFactura");
                });

            modelBuilder.Entity("AppWebSistemaClinica.C1Model.C1ModelClinica", b =>
                {
                    b.Navigation("C1ModelCita");

                    b.Navigation("C1ModelEquipoMedicoClinica");
                });

            modelBuilder.Entity("AppWebSistemaClinica.C1Model.C1ModelEquipoMedico", b =>
                {
                    b.Navigation("C1ModelEquipoMedicoClinica");
                });

            modelBuilder.Entity("AppWebSistemaClinica.C1Model.C1ModelEspecialidad", b =>
                {
                    b.Navigation("C1ModelMedico");
                });

            modelBuilder.Entity("AppWebSistemaClinica.C1Model.C1ModelFactura", b =>
                {
                    b.Navigation("C1ModelDetalleFactura");
                });

            modelBuilder.Entity("AppWebSistemaClinica.C1Model.C1ModelHistorialClinico", b =>
                {
                    b.Navigation("C1ModelRegistroMedico");
                });

            modelBuilder.Entity("AppWebSistemaClinica.C1Model.C1ModelPaciente", b =>
                {
                    b.Navigation("C1ModelFactura");

                    b.Navigation("C1ModelHistorialClinico");
                });

            modelBuilder.Entity("AppWebSistemaClinica.C1Model.C1ModelPago", b =>
                {
                    b.Navigation("C1ModelFactura");
                });

            modelBuilder.Entity("AppWebSistemaClinica.C1Model.C1ModelRol", b =>
                {
                    b.Navigation("C1ModelPerfil");
                });

            modelBuilder.Entity("AppWebSistemaClinica.C1Model.C1ModelUsuario", b =>
                {
                    b.Navigation("C1ModelPerfil");
                });
#pragma warning restore 612, 618
        }
    }
}
