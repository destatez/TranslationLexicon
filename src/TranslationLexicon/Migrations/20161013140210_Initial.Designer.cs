using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TranslationLexicon;

namespace TranslationLexicon.Migrations
{
    [DbContext(typeof(Db))]
    [Migration("20161013140210_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1");

            modelBuilder.Entity("TranslationLexicon.Models.Entry", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("CheckedBy");

                    b.Property<string>("CheckedOn");

                    b.Property<string>("Definition");

                    b.HasKey("Id");

                    b.ToTable("Entries");
                });
        }
    }
}
