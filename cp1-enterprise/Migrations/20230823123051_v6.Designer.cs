﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using cp1_enterprise.Persistence;

#nullable disable

namespace cp1_enterprise.Migrations
{
    [DbContext(typeof(OracleDbContext))]
    [Migration("20230823123051_v6")]
    partial class v6
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("cp1_enterprise.Models.Hospede", b =>
                {
                    b.Property<int>("HospedeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HospedeId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("HospedeId");

                    b.ToTable("TB_HOSPEDE");
                });

            modelBuilder.Entity("cp1_enterprise.Models.Pagamento", b =>
                {
                    b.Property<int>("IdPagamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPagamento"));

                    b.Property<DateTime>("DataPagamento")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int>("IdReserva")
                        .HasColumnType("NUMBER(10)");

                    b.Property<float>("Valor")
                        .HasColumnType("BINARY_FLOAT");

                    b.HasKey("IdPagamento");

                    b.HasIndex("IdReserva");

                    b.ToTable("TB_PAGAMENTO");
                });

            modelBuilder.Entity("cp1_enterprise.Models.Quarto", b =>
                {
                    b.Property<int>("QuartoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuartoId"));

                    b.Property<int>("IdTipoQuarto")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("NumeroQuarto")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<float>("PrecoPorNoite")
                        .HasColumnType("BINARY_FLOAT");

                    b.HasKey("QuartoId");

                    b.HasIndex("IdTipoQuarto");

                    b.ToTable("TB_QUARTO");
                });

            modelBuilder.Entity("cp1_enterprise.Models.Reserva", b =>
                {
                    b.Property<int>("IdReserva")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdReserva"));

                    b.Property<DateTime>("DataEntrada")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime>("DataSaida")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int>("IdHospede")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("IdPagamento")
                        .HasColumnType("NUMBER(10)");

                    b.Property<float>("ValorTotal")
                        .HasColumnType("BINARY_FLOAT");

                    b.HasKey("IdReserva");

                    b.HasIndex("IdHospede");

                    b.HasIndex("IdPagamento");

                    b.ToTable("TB_RESERVA");
                });

            modelBuilder.Entity("cp1_enterprise.Models.TipoQuarto", b =>
                {
                    b.Property<int>("IdTipoQuarto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoQuarto"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("IdTipoQuarto");

                    b.ToTable("TB_TIPOQUARTO");
                });

            modelBuilder.Entity("cp1_enterprise.Models.Pagamento", b =>
                {
                    b.HasOne("cp1_enterprise.Models.Reserva", "Reserva")
                        .WithMany()
                        .HasForeignKey("IdReserva")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reserva");
                });

            modelBuilder.Entity("cp1_enterprise.Models.Quarto", b =>
                {
                    b.HasOne("cp1_enterprise.Models.TipoQuarto", "TipoQuarto")
                        .WithMany()
                        .HasForeignKey("IdTipoQuarto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoQuarto");
                });

            modelBuilder.Entity("cp1_enterprise.Models.Reserva", b =>
                {
                    b.HasOne("cp1_enterprise.Models.Hospede", "Hospede")
                        .WithMany()
                        .HasForeignKey("IdHospede")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cp1_enterprise.Models.Pagamento", "Pagamento")
                        .WithMany()
                        .HasForeignKey("IdPagamento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hospede");

                    b.Navigation("Pagamento");
                });
#pragma warning restore 612, 618
        }
    }
}
