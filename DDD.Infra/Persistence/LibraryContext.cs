using DDD.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DDD.Infra.Persistence
{
    public class LibraryContext : DbContext
    {
        public LibraryContext()
        {
            
        }

        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
                
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Exemplary> Exemplarys { get; set; }

        private void ConfiguraBook(ModelBuilder construtorDeModelos)
        {
            construtorDeModelos.Entity<Book>(etd =>
            {
                etd.ToTable("BOOK");
                etd.HasKey(b => b.Id).HasName("book_id");
                etd.Property(b => b.Id).HasColumnName("book_id").UseSqlServerIdentityColumn().ValueGeneratedOnAdd();
                etd.HasIndex(b => b.Book_Title.Title).IsUnique();
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

        protected override void OnModelCreating(ModelBuilder construtorDeModelos)
        {
            construtorDeModelos.ForSqlServerUseIdentityColumns();
            construtorDeModelos.HasDefaultSchema("LivrariaHbsis");

            ConfiguraBook(construtorDeModelos);
            ConfiguraExemplary(construtorDeModelos);
        }
    }
}