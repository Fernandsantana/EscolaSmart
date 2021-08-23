﻿// <auto-generated />
using System;
using EscolaSmart.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EscolaSmart.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210822124011_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("EscolaSmart.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataIni")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataNasc")
                        .HasColumnType("TEXT");

                    b.Property<int>("Matricula")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Alunos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataIni = new DateTime(2021, 8, 22, 9, 40, 10, 775, DateTimeKind.Local).AddTicks(6736),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 1,
                            Nome = "Marta",
                            Sobrenome = "Kent",
                            Status = true,
                            Telefone = "33225555"
                        },
                        new
                        {
                            Id = 2,
                            DataIni = new DateTime(2021, 8, 22, 9, 40, 10, 775, DateTimeKind.Local).AddTicks(8390),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 2,
                            Nome = "Paula",
                            Sobrenome = "Isabela",
                            Status = true,
                            Telefone = "3354288"
                        },
                        new
                        {
                            Id = 3,
                            DataIni = new DateTime(2021, 8, 22, 9, 40, 10, 775, DateTimeKind.Local).AddTicks(8448),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 3,
                            Nome = "Laura",
                            Sobrenome = "Antonia",
                            Status = true,
                            Telefone = "55668899"
                        },
                        new
                        {
                            Id = 4,
                            DataIni = new DateTime(2021, 8, 22, 9, 40, 10, 775, DateTimeKind.Local).AddTicks(8453),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 4,
                            Nome = "Luiza",
                            Sobrenome = "Maria",
                            Status = true,
                            Telefone = "6565659"
                        },
                        new
                        {
                            Id = 5,
                            DataIni = new DateTime(2021, 8, 22, 9, 40, 10, 775, DateTimeKind.Local).AddTicks(8457),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 5,
                            Nome = "Lucas",
                            Sobrenome = "Machado",
                            Status = true,
                            Telefone = "565685415"
                        },
                        new
                        {
                            Id = 6,
                            DataIni = new DateTime(2021, 8, 22, 9, 40, 10, 775, DateTimeKind.Local).AddTicks(8467),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 6,
                            Nome = "Pedro",
                            Sobrenome = "Alvares",
                            Status = true,
                            Telefone = "456454545"
                        },
                        new
                        {
                            Id = 7,
                            DataIni = new DateTime(2021, 8, 22, 9, 40, 10, 775, DateTimeKind.Local).AddTicks(8471),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 7,
                            Nome = "Paulo",
                            Sobrenome = "José",
                            Status = true,
                            Telefone = "9874512"
                        });
                });

            modelBuilder.Entity("EscolaSmart.Models.AlunoCurso", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CursoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataIni")
                        .HasColumnType("TEXT");

                    b.HasKey("AlunoId", "CursoId");

                    b.HasIndex("CursoId");

                    b.ToTable("AlunosCursos");
                });

            modelBuilder.Entity("EscolaSmart.Models.AlunoDisciplina", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DisciplinaId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataIni")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Nota")
                        .HasColumnType("INTEGER");

                    b.HasKey("AlunoId", "DisciplinaId");

                    b.HasIndex("DisciplinaId");

                    b.ToTable("AlunosDisciplinas");

                    b.HasData(
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 2,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 8, 22, 9, 40, 10, 775, DateTimeKind.Local).AddTicks(9715)
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 4,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 8, 22, 9, 40, 10, 776, DateTimeKind.Local).AddTicks(213)
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 5,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 8, 22, 9, 40, 10, 776, DateTimeKind.Local).AddTicks(249)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 1,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 8, 22, 9, 40, 10, 776, DateTimeKind.Local).AddTicks(250)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 2,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 8, 22, 9, 40, 10, 776, DateTimeKind.Local).AddTicks(252)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 5,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 8, 22, 9, 40, 10, 776, DateTimeKind.Local).AddTicks(255)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 1,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 8, 22, 9, 40, 10, 776, DateTimeKind.Local).AddTicks(257)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 2,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 8, 22, 9, 40, 10, 776, DateTimeKind.Local).AddTicks(258)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 3,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 8, 22, 9, 40, 10, 776, DateTimeKind.Local).AddTicks(259)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 1,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 8, 22, 9, 40, 10, 776, DateTimeKind.Local).AddTicks(262)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 4,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 8, 22, 9, 40, 10, 776, DateTimeKind.Local).AddTicks(263)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 5,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 8, 22, 9, 40, 10, 776, DateTimeKind.Local).AddTicks(264)
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 4,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 8, 22, 9, 40, 10, 776, DateTimeKind.Local).AddTicks(265)
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 5,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 8, 22, 9, 40, 10, 776, DateTimeKind.Local).AddTicks(267)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 1,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 8, 22, 9, 40, 10, 776, DateTimeKind.Local).AddTicks(268)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 2,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 8, 22, 9, 40, 10, 776, DateTimeKind.Local).AddTicks(269)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 3,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 8, 22, 9, 40, 10, 776, DateTimeKind.Local).AddTicks(271)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 4,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 8, 22, 9, 40, 10, 776, DateTimeKind.Local).AddTicks(273)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 1,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 8, 22, 9, 40, 10, 776, DateTimeKind.Local).AddTicks(274)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 2,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 8, 22, 9, 40, 10, 776, DateTimeKind.Local).AddTicks(275)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 3,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 8, 22, 9, 40, 10, 776, DateTimeKind.Local).AddTicks(277)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 4,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 8, 22, 9, 40, 10, 776, DateTimeKind.Local).AddTicks(278)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 5,
                            DataFim = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataIni = new DateTime(2021, 8, 22, 9, 40, 10, 776, DateTimeKind.Local).AddTicks(279)
                        });
                });

            modelBuilder.Entity("EscolaSmart.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cursos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Tecnologia da Informação"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Sistemas de Informação"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Ciência da Computação"
                        });
                });

            modelBuilder.Entity("EscolaSmart.Models.Disciplina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CargaHoraria")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CursoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PrerequisitoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.HasIndex("PrerequisitoId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Disciplinas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Matemática",
                            ProfessorId = 1
                        },
                        new
                        {
                            Id = 2,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Matemática",
                            ProfessorId = 1
                        },
                        new
                        {
                            Id = 3,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Física",
                            ProfessorId = 2
                        },
                        new
                        {
                            Id = 4,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Português",
                            ProfessorId = 3
                        },
                        new
                        {
                            Id = 5,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 6,
                            CargaHoraria = 0,
                            CursoId = 2,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 7,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 8,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Programação",
                            ProfessorId = 5
                        },
                        new
                        {
                            Id = 9,
                            CargaHoraria = 0,
                            CursoId = 2,
                            Nome = "Programação",
                            ProfessorId = 5
                        },
                        new
                        {
                            Id = 10,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Programação",
                            ProfessorId = 5
                        });
                });

            modelBuilder.Entity("EscolaSmart.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataIni")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("Registro")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Professores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataIni = new DateTime(2021, 8, 22, 9, 40, 10, 772, DateTimeKind.Local).AddTicks(372),
                            Nome = "Lauro",
                            Registro = 1,
                            Sobrenome = "Oliveira",
                            Status = true
                        },
                        new
                        {
                            Id = 2,
                            DataIni = new DateTime(2021, 8, 22, 9, 40, 10, 772, DateTimeKind.Local).AddTicks(9759),
                            Nome = "Roberto",
                            Registro = 2,
                            Sobrenome = "Soares",
                            Status = true
                        },
                        new
                        {
                            Id = 3,
                            DataIni = new DateTime(2021, 8, 22, 9, 40, 10, 772, DateTimeKind.Local).AddTicks(9800),
                            Nome = "Ronaldo",
                            Registro = 3,
                            Sobrenome = "Marconi",
                            Status = true
                        },
                        new
                        {
                            Id = 4,
                            DataIni = new DateTime(2021, 8, 22, 9, 40, 10, 772, DateTimeKind.Local).AddTicks(9802),
                            Nome = "Rodrigo",
                            Registro = 4,
                            Sobrenome = "Carvalho",
                            Status = true
                        },
                        new
                        {
                            Id = 5,
                            DataIni = new DateTime(2021, 8, 22, 9, 40, 10, 772, DateTimeKind.Local).AddTicks(9803),
                            Nome = "Alexandre",
                            Registro = 5,
                            Sobrenome = "Montanha",
                            Status = true
                        });
                });

            modelBuilder.Entity("EscolaSmart.Models.AlunoCurso", b =>
                {
                    b.HasOne("EscolaSmart.Models.Aluno", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EscolaSmart.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EscolaSmart.Models.AlunoDisciplina", b =>
                {
                    b.HasOne("EscolaSmart.Models.Aluno", "Aluno")
                        .WithMany("AlunosDisciplinas")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EscolaSmart.Models.Disciplina", "Disciplina")
                        .WithMany("AlunosDisciplinas")
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EscolaSmart.Models.Disciplina", b =>
                {
                    b.HasOne("EscolaSmart.Models.Curso", "Curso")
                        .WithMany("Disciplinas")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EscolaSmart.Models.Disciplina", "Prerequisito")
                        .WithMany()
                        .HasForeignKey("PrerequisitoId");

                    b.HasOne("EscolaSmart.Models.Professor", "Professor")
                        .WithMany("Disciplinas")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
