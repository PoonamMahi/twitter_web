// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Twitter.DataAccess;

namespace Twitter.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Twitter.Models.Register", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Email")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("password")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("userName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Register");
            });

            modelBuilder.Entity("Twitter.Models.TweetModel", b =>
            {
                b.Property<int>("TweetId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("TweetDescription")
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("UserId")
                    .HasColumnType("int");

                b.Property<string>("UserName")
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("commentsCount")
                    .HasColumnType("int");

                b.Property<DateTime>("createdAt")
                    .HasColumnType("datetime2");

                b.Property<int>("likesCount")
                    .HasColumnType("int");

                b.Property<DateTime>("updatedAt")
                    .HasColumnType("datetime2");

                b.HasKey("TweetId");

                b.ToTable("TweetsData");
            });
#pragma warning restore 612, 618
        }
    }
}