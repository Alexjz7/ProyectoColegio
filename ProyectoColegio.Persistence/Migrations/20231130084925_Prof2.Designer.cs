﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoColegio.Persistence.Data;

#nullable disable

namespace ProyectoColegio.Persistence.Migrations
{
    [DbContext(typeof(ColegioDBContext))]
    [Migration("20231130084925_Prof2")]
    partial class Prof2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProyectoColegio.Domain.Clases", b =>
                {
                    b.Property<int>("ClaseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClaseID"));

                    b.Property<int>("CursoID")
                        .HasColumnType("int");

                    b.Property<string>("DiaClase")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DocenteID")
                        .HasColumnType("int");

                    b.Property<int>("Grado")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("HoraFin")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("HoraInicio")
                        .HasColumnType("time");

                    b.Property<string>("TipoGrado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClaseID");

                    b.HasIndex("CursoID");

                    b.HasIndex("DocenteID");

                    b.ToTable("Clases");
                });

            modelBuilder.Entity("ProyectoColegio.Domain.ClasesEstudiantes", b =>
                {
                    b.Property<int>("ClasesEstudiantesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClasesEstudiantesID"));

                    b.Property<float>("C1")
                        .HasColumnType("real");

                    b.Property<float>("C2")
                        .HasColumnType("real");

                    b.Property<float>("C3")
                        .HasColumnType("real");

                    b.Property<float>("C4")
                        .HasColumnType("real");

                    b.Property<int>("ClasesID")
                        .HasColumnType("int");

                    b.Property<float>("Final")
                        .HasColumnType("real");

                    b.Property<int>("Grado")
                        .HasColumnType("int");

                    b.Property<string>("TipoGrado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioID")
                        .HasColumnType("int");

                    b.HasKey("ClasesEstudiantesID");

                    b.HasIndex("ClasesID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("ClasesEstudiantes");
                });

            modelBuilder.Entity("ProyectoColegio.Domain.Cursos", b =>
                {
                    b.Property<int>("CursoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CursoID"));

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CursoID");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("ProyectoColegio.Domain.Docente", b =>
                {
                    b.Property<int>("DocenteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DocenteID"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Dni")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int?>("IdLogin")
                        .HasColumnType("int");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("DocenteID");

                    b.ToTable("Docente");
                });

            modelBuilder.Entity("ProyectoColegio.Domain.Rol", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("RoleID");

                    b.ToTable("Rol");

                    b.HasData(
                        new
                        {
                            RoleID = 1,
                            Description = "Administrador"
                        },
                        new
                        {
                            RoleID = 2,
                            Description = "Docente"
                        },
                        new
                        {
                            RoleID = 3,
                            Description = "Estudiante"
                        });
                });

            modelBuilder.Entity("ProyectoColegio.Domain.Usuario", b =>
                {
                    b.Property<int>("UsuarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioID"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dni")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("Grado")
                        .HasColumnType("int");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<int?>("RoleID1")
                        .HasColumnType("int");

                    b.Property<string>("TipoGrado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsuarioID");

                    b.HasIndex("RoleID1");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ProyectoColegio.Domain.Clases", b =>
                {
                    b.HasOne("ProyectoColegio.Domain.Cursos", "curso")
                        .WithMany("clases")
                        .HasForeignKey("CursoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProyectoColegio.Domain.Docente", "docente")
                        .WithMany("Sesiones")
                        .HasForeignKey("DocenteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("curso");

                    b.Navigation("docente");
                });

            modelBuilder.Entity("ProyectoColegio.Domain.ClasesEstudiantes", b =>
                {
                    b.HasOne("ProyectoColegio.Domain.Clases", "Clases")
                        .WithMany("ClasesEstudiantes")
                        .HasForeignKey("ClasesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProyectoColegio.Domain.Usuario", "Usuario")
                        .WithMany("ClasesEstudiantes")
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clases");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ProyectoColegio.Domain.Usuario", b =>
                {
                    b.HasOne("ProyectoColegio.Domain.Rol", "Rol")
                        .WithMany("Usuarios")
                        .HasForeignKey("RoleID1");

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("ProyectoColegio.Domain.Clases", b =>
                {
                    b.Navigation("ClasesEstudiantes");
                });

            modelBuilder.Entity("ProyectoColegio.Domain.Cursos", b =>
                {
                    b.Navigation("clases");
                });

            modelBuilder.Entity("ProyectoColegio.Domain.Docente", b =>
                {
                    b.Navigation("Sesiones");
                });

            modelBuilder.Entity("ProyectoColegio.Domain.Rol", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("ProyectoColegio.Domain.Usuario", b =>
                {
                    b.Navigation("ClasesEstudiantes");
                });
#pragma warning restore 612, 618
        }
    }
}