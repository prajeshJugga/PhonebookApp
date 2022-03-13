using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Phonebook.Models;
using System.IO;

namespace PhoneBook_Web_API.Context
{
    public class PhoneBookContext : DbContext
    {
        public PhoneBookContext() { }

        public PhoneBookContext(DbContextOptions<PhoneBookContext> options) : base(options) { }

        public DbSet<Entry> Entry { get; set; }

        public DbSet<PhoneBook> PhoneBook { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PhoneBook>()
                        .HasMany(phoneBook => phoneBook.Entries)
                        .WithOne(entry => entry.PhoneBook)
                        .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PhoneBook>()
                        .HasIndex(entry => entry.Name)
                        .IsUnique();

            modelBuilder.Entity<Entry>()
                        .HasIndex(entry => entry.Name)
                        .IsUnique();
        }

        public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<PhoneBookContext>
        {
            public PhoneBookContext CreateDbContext(string[] args)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.Development.json")
                    .Build();

                var builder = new DbContextOptionsBuilder<PhoneBookContext>();

                var connectionString = configuration["CONNECTION_STRING"];
                builder.UseSqlServer(connectionString);

                return new PhoneBookContext(builder.Options);
            }
        }
    }
}
