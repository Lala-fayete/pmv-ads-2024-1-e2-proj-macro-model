using Microsoft.EntityFrameworkCore;

namespace Macro_Model.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Cadastro> Cadastro { get; set; }
		public DbSet<Login> Login { get; set; }


	}
}
