using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TranslationLexicon.Models;
using Microsoft.Data.Sqlite;

namespace TranslationLexicon
{
    public class Db:DbContext
    {
        public Db()
        {
            Database.Migrate();
        }
        public DbSet<Entry> Entries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SqliteConnectionStringBuilder builder = new SqliteConnectionStringBuilder();
            builder.DataSource = "data.db";
            SqliteConnection connection = new SqliteConnection(builder.ToString());
            optionsBuilder.UseSqlite(connection);
        }
    }
}
