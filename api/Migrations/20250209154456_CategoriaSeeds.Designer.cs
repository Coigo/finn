﻿// <auto-generated />
using System;
using Infra.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace api.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20250209154456_CategoriaSeeds")]
    partial class CategoriaSeeds
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.12");

            modelBuilder.Entity("Movimentacoes.Models.MovimentacaoCategoriaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("MovimentacoesCategorias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CriadoEm = new DateTime(2025, 2, 9, 11, 44, 56, 433, DateTimeKind.Local).AddTicks(2975),
                            Nome = "Comida",
                            Tipo = "SAIDA"
                        },
                        new
                        {
                            Id = 2,
                            CriadoEm = new DateTime(2025, 2, 9, 11, 44, 56, 433, DateTimeKind.Local).AddTicks(3011),
                            Nome = "Educação",
                            Tipo = "SAIDA"
                        });
                });

            modelBuilder.Entity("Movimentacoes.Models.MovimentacaoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Valor")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("criadoEm")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("movimentacao");
                });

            modelBuilder.Entity("Movimentacoes.Models.MovimentacaoParcelaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<int>("MovimentacaoIdId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Valor")
                        .HasColumnType("REAL");

                    b.Property<int>("Vumero")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MovimentacaoIdId");

                    b.ToTable("MovimentacaoParcelas");
                });

            modelBuilder.Entity("Movimentacoes.Models.MovimentacaoModel", b =>
                {
                    b.HasOne("Movimentacoes.Models.MovimentacaoCategoriaModel", "Categoria")
                        .WithMany("Movimentacoes")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("Movimentacoes.Models.MovimentacaoParcelaModel", b =>
                {
                    b.HasOne("Movimentacoes.Models.MovimentacaoModel", "MovimentacaoId")
                        .WithMany()
                        .HasForeignKey("MovimentacaoIdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MovimentacaoId");
                });

            modelBuilder.Entity("Movimentacoes.Models.MovimentacaoCategoriaModel", b =>
                {
                    b.Navigation("Movimentacoes");
                });
#pragma warning restore 612, 618
        }
    }
}
