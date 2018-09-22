using System.IO;
using DDD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DDD.Infra.Persistence
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options)
            :base(options) { }
        public LibraryContext(){ }
        public DbSet<Exemplary> Exemplary { get; set; }
        public DbSet<Book> Book { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ForSqlServerUseIdentityColumns();
            builder.HasDefaultSchema("LivrariaHbsis");

            ConfiguraBook(builder);
            ConfiguraExemplary(builder);
        }

        private void ConfiguraBook(ModelBuilder modelFactory)
        {
            modelFactory.Entity<Book>(etd =>
            {
                etd.ToTable("BOOK");
                etd.HasKey(b => b.Id).HasName("book_id");
                etd.Property(b => b.Id).HasColumnName("book_id").UseSqlServerIdentityColumn().ValueGeneratedOnAdd();
                etd.HasIndex(b => b.Book_Title).IsUnique();
                etd.Property(b => b.Book_Title).HasColumnName("book_title").HasMaxLength(200).IsRequired();
                etd.Property(b => b.Book_Description).HasColumnName("book_description").HasMaxLength(200).IsRequired();
                etd.Property(b => b.Book_Author).HasColumnName("book_author").HasMaxLength(200).IsRequired();
                etd.Property(b => b.Book_Publishing_Company).HasColumnName("book_publishing_company").HasMaxLength(200).IsRequired();
                etd.Property(b => b.Book_Price).HasColumnName("book_price").IsRequired();
            });
        }

        private void ConfiguraExemplary(ModelBuilder construtorDeModelos) 
        {
            construtorDeModelos.Entity<Exemplary>(edt => 
            {
                edt.ToTable("EXEMPLARY");
                edt.HasKey(e => e.Id).HasName("exemplary_id");
                edt.Property(e => e.Id).HasColumnName("exemplary_id").UseSqlServerIdentityColumn().ValueGeneratedOnAdd();
                edt.Property(e => e.Book_Id).HasColumnName("book_id");
                edt.Property(e => e.Exemplary_Count).HasColumnName("exemplary_count");
            });
        }
    }
}