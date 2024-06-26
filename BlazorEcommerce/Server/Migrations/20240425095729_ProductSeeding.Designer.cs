﻿// <auto-generated />
using BlazorEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240425095729_ProductSeeding")]
    partial class ProductSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "The Witcher (Polish: Wiedźmin, pronounced [ˈvjɛd͡ʑmin]) is a series of six fantasy novels and 15 short stories written by Polish author Andrzej Sapkowski. The series revolves around the eponymous 'Witcher', Geralt of Rivia. 'Witchers' are monster hunters given superhuman abilities for the purpose of killing dangerous creatures. The Witcher began with a titular 1986 short story that Sapkowski entered into a competition held by Fantastyka magazine, marking his debut as an author. Due to reader demand, Sapkowski wrote 14 more stories before starting a series of novels in 1994. Known as The Witcher Saga, he wrote one book a year until the fifth and final installment in 1999. A standalone prequel novel, Season of Storms, was published in 2013.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/3/33/Wiedzmin_1990.png",
                            Price = 9.99m,
                            Title = "Mert's Advantures in Serbia"
                        },
                        new
                        {
                            Id = 2,
                            Description = "The Witcher (Polish: Wiedźmin, pronounced [ˈvjɛd͡ʑmin]) is a series of six fantasy novels and 15 short stories written by Polish author Andrzej Sapkowski. The series revolves around the eponymous 'Witcher', Geralt of Rivia. 'Witchers' are monster hunters given superhuman abilities for the purpose of killing dangerous creatures. The Witcher began with a titular 1986 short story that Sapkowski entered into a competition held by Fantastyka magazine, marking his debut as an author. Due to reader demand, Sapkowski wrote 14 more stories before starting a series of novels in 1994. Known as The Witcher Saga, he wrote one book a year until the fifth and final installment in 1999. A standalone prequel novel, Season of Storms, was published in 2013.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/3/33/Wiedzmin_1990.png",
                            Price = 9.99m,
                            Title = "Mert's Advantures in Turkey"
                        },
                        new
                        {
                            Id = 3,
                            Description = "The Witcher (Polish: Wiedźmin, pronounced [ˈvjɛd͡ʑmin]) is a series of six fantasy novels and 15 short stories written by Polish author Andrzej Sapkowski. The series revolves around the eponymous 'Witcher', Geralt of Rivia. 'Witchers' are monster hunters given superhuman abilities for the purpose of killing dangerous creatures. The Witcher began with a titular 1986 short story that Sapkowski entered into a competition held by Fantastyka magazine, marking his debut as an author. Due to reader demand, Sapkowski wrote 14 more stories before starting a series of novels in 1994. Known as The Witcher Saga, he wrote one book a year until the fifth and final installment in 1999. A standalone prequel novel, Season of Storms, was published in 2013.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/3/33/Wiedzmin_1990.png",
                            Price = 9.99m,
                            Title = "Mert's Advantures in India"
                        },
                        new
                        {
                            Id = 4,
                            Description = "The Witcher (Polish: Wiedźmin, pronounced [ˈvjɛd͡ʑmin]) is a series of six fantasy novels and 15 short stories written by Polish author Andrzej Sapkowski. The series revolves around the eponymous 'Witcher', Geralt of Rivia. 'Witchers' are monster hunters given superhuman abilities for the purpose of killing dangerous creatures. The Witcher began with a titular 1986 short story that Sapkowski entered into a competition held by Fantastyka magazine, marking his debut as an author. Due to reader demand, Sapkowski wrote 14 more stories before starting a series of novels in 1994. Known as The Witcher Saga, he wrote one book a year until the fifth and final installment in 1999. A standalone prequel novel, Season of Storms, was published in 2013.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/3/33/Wiedzmin_1990.png",
                            Price = 9.99m,
                            Title = "Mert's Experience in Bahrein"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
