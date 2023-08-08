﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WPF_APP;

#nullable disable

namespace WPF_APP.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230808041711_edg")]
    partial class edg
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WPF_APP.Modelos.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumHoras")
                        .HasColumnType("int");

                    b.Property<int?>("ProfesorId")
                        .HasColumnType("int");

                    b.Property<string>("TipoCurso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProfesorId");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("WPF_APP.Modelos.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("WPF_APP.Modelos.Profesor", b =>
                {
                    b.HasBaseType("WPF_APP.Modelos.Persona");

                    b.Property<string>("Especializacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumEMpleado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Personas");

                    b.HasDiscriminator().HasValue("Profesor");
                });

            modelBuilder.Entity("WPF_APP.Modelos.Curso", b =>
                {
                    b.HasOne("WPF_APP.Modelos.Profesor", null)
                        .WithMany("Cursos")
                        .HasForeignKey("ProfesorId");
                });

            modelBuilder.Entity("WPF_APP.Modelos.Profesor", b =>
                {
                    b.Navigation("Cursos");
                });
#pragma warning restore 612, 618
        }
    }
}
