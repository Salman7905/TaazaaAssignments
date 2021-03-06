// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieManagement.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MovieManagement.Migrations
{
    [DbContext(typeof(movieDbContext))]
    [Migration("20210917130203_phase1")]
    partial class phase1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("MovieManagement.Models.Movie", b =>
                {
                    b.Property<int>("movieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("movieName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("moviePrice")
                        .HasMaxLength(3)
                        .HasColumnType("integer");

                    b.HasKey("movieID");

                    b.ToTable("movies");
                });
#pragma warning restore 612, 618
        }
    }
}
