﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Site.test.Models.Data;

#nullable disable

namespace Correios.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20240321202004_Criacao-Inicial")]
    partial class CriacaoInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Site.test.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Data");

                    b.Property<string>("Destinatario")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Destinatario");

                    b.Property<string>("Destino")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Destino");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Marca");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Nome");

                    b.HasKey("Id");

                    b.ToTable("produto");
                });
#pragma warning restore 612, 618
        }
    }
}
