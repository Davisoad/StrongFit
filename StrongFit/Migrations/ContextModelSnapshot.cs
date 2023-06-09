﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StrongFit.Models;

#nullable disable

namespace StrongFit.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StrongFit.Models.Aluno", b =>
                {
                    b.Property<int>("AlunoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AlunoID"));

                    b.Property<DateTime>("Data_Nascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("E_Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instagram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacoes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonalID")
                        .HasColumnType("int");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AlunoID");

                    b.HasIndex("PersonalID");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("StrongFit.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoriaID"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoriaID");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("StrongFit.Models.Exercicio", b =>
                {
                    b.Property<int>("ExercicioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExercicioID"));

                    b.Property<int>("CategoriaID")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExercicioID");

                    b.HasIndex("CategoriaID");

                    b.ToTable("Exercicios");
                });

            modelBuilder.Entity("StrongFit.Models.ExercicioTreino", b =>
                {
                    b.Property<int>("ExercicioTreinoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExercicioTreinoID"));

                    b.Property<int>("ExercicioID")
                        .HasColumnType("int");

                    b.Property<int>("TreinoID")
                        .HasColumnType("int");

                    b.HasKey("ExercicioTreinoID");

                    b.HasIndex("ExercicioID");

                    b.HasIndex("TreinoID");

                    b.ToTable("ExercicioTreinos");
                });

            modelBuilder.Entity("StrongFit.Models.Personal", b =>
                {
                    b.Property<int>("PersonalID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonalID"));

                    b.Property<string>("Especialidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonalID");

                    b.ToTable("Personals");
                });

            modelBuilder.Entity("StrongFit.Models.Treino", b =>
                {
                    b.Property<int>("TreinoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TreinoID"));

                    b.Property<int>("AlunoID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Hora")
                        .HasColumnType("datetime2");

                    b.HasKey("TreinoID");

                    b.HasIndex("AlunoID");

                    b.ToTable("Treinos");
                });

            modelBuilder.Entity("StrongFit.Models.Aluno", b =>
                {
                    b.HasOne("StrongFit.Models.Personal", "personal")
                        .WithMany("Alunos")
                        .HasForeignKey("PersonalID");

                    b.Navigation("personal");
                });

            modelBuilder.Entity("StrongFit.Models.Exercicio", b =>
                {
                    b.HasOne("StrongFit.Models.Categoria", "Categoria")
                        .WithMany("Exercicios")
                        .HasForeignKey("CategoriaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("StrongFit.Models.ExercicioTreino", b =>
                {
                    b.HasOne("StrongFit.Models.Exercicio", "exercicio")
                        .WithMany("exercicioTreino")
                        .HasForeignKey("ExercicioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StrongFit.Models.Treino", "treino")
                        .WithMany("ExercicioTreino")
                        .HasForeignKey("TreinoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("exercicio");

                    b.Navigation("treino");
                });

            modelBuilder.Entity("StrongFit.Models.Treino", b =>
                {
                    b.HasOne("StrongFit.Models.Aluno", "aluno")
                        .WithMany("Treinos")
                        .HasForeignKey("AlunoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("aluno");
                });

            modelBuilder.Entity("StrongFit.Models.Aluno", b =>
                {
                    b.Navigation("Treinos");
                });

            modelBuilder.Entity("StrongFit.Models.Categoria", b =>
                {
                    b.Navigation("Exercicios");
                });

            modelBuilder.Entity("StrongFit.Models.Exercicio", b =>
                {
                    b.Navigation("exercicioTreino");
                });

            modelBuilder.Entity("StrongFit.Models.Personal", b =>
                {
                    b.Navigation("Alunos");
                });

            modelBuilder.Entity("StrongFit.Models.Treino", b =>
                {
                    b.Navigation("ExercicioTreino");
                });
#pragma warning restore 612, 618
        }
    }
}
