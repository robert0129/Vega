using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebApplicationBasic.Persistence;

namespace Vega.Migrations
{
    [DbContext(typeof(VegaDbContext))]
    [Migration("20170515114125_InitModels")]
    partial class InitModels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplicationBasic.Core.Models.Feature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("WebApplicationBasic.Core.Models.Make", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Makes");
                });

            modelBuilder.Entity("WebApplicationBasic.Core.Models.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("MakeId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("MakeId");

                    b.ToTable("Modles");
                });

            modelBuilder.Entity("WebApplicationBasic.Core.Models.Model", b =>
                {
                    b.HasOne("WebApplicationBasic.Core.Models.Make")
                        .WithMany("Models")
                        .HasForeignKey("MakeId");
                });
        }
    }
}
