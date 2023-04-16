﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Template.Domain.Persistance;

#nullable disable

namespace Template.Domain.Migrations
{
    [DbContext(typeof(TemplateDbContext))]
    partial class TemplateDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Template.Domain.Entities.TemplateEntity1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TemplateProperty1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TemplateProperty2")
                        .HasColumnType("int");

                    b.Property<bool>("TemplateProperty3")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("TemplateTable1");
                });

            modelBuilder.Entity("Template.Domain.Entities.TemplateEntity2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TemplateProperty4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TemplateProperty5")
                        .HasColumnType("int");

                    b.Property<bool>("TemplateProperty6")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("TemplateTable2");
                });
#pragma warning restore 612, 618
        }
    }
}
