﻿// <auto-generated />
using ListaDeTarefasAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ListaDeTarefasAPI.Migrations
{
    [DbContext(typeof(listaTarefasContext))]
    partial class listaTarefasContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ListaDeTarefasAPI.Models.Tarefa", b =>
                {
                    b.Property<int>("TarefaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TarefaId"));

                    b.Property<bool>("Concluida")
                        .HasColumnType("bit");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoTarefaId")
                        .HasColumnType("int");

                    b.HasKey("TarefaId");

                    b.HasIndex("TipoTarefaId");

                    b.ToTable("Tarefas");
                });

            modelBuilder.Entity("ListaDeTarefasAPI.Models.TipoTarefa", b =>
                {
                    b.Property<int>("TipoTarefaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoTarefaId"));

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipoTarefaId");

                    b.ToTable("TipoTarefas");
                });

            modelBuilder.Entity("ListaDeTarefasAPI.Models.Tarefa", b =>
                {
                    b.HasOne("ListaDeTarefasAPI.Models.TipoTarefa", "TipoTarefa")
                        .WithMany()
                        .HasForeignKey("TipoTarefaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoTarefa");
                });
#pragma warning restore 612, 618
        }
    }
}
