﻿// <auto-generated />
using JalgrattaEksamMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JalgrattaEksamMVC.Migrations
{
    [DbContext(typeof(JalgrattaEksamMVCContext))]
    partial class JalgrattaEksamMVCContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JalgrattaEksamMVC.Models.Eksam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Eesnimi")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Luba")
                        .HasColumnType("int");

                    b.Property<string>("Perekonnanimi")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Ring")
                        .HasColumnType("int");

                    b.Property<int>("Slaloom")
                        .HasColumnType("int");

                    b.Property<int>("Teooria")
                        .HasColumnType("int");

                    b.Property<int>("Tänav")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Eesnimi", "Perekonnanimi")
                        .IsUnique();

                    b.ToTable("Eksam");
                });
#pragma warning restore 612, 618
        }
    }
}
