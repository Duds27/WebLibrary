using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DDD.Infra.Persistence
{
    public class FonteDeDados : IDesignTimeDbContextFactory<LibraryContext>
    {
        private const string CONNECTIONSTRING = @"Server=DESKTOP-TGA2QF7;Database=LivrariaHbsis;Trusted_Connection=True;";

        public FonteDeDados()
        {

        }

        public LibraryContext CreateDbContext(string[] args)
        {
            var construtor = new DbContextOptionsBuilder<LibraryContext>();
            construtor.UseSqlServer(CONNECTIONSTRING);
            return new LibraryContext(construtor.Options);
        }
    }
}