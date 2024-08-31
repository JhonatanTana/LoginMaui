using LoginMaui.Components.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginMaui.Data {
    public class AppDbContext : DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
        }

        public DbSet<RegistroModel> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
                optionsBuilder.UseSqlite("Data Source=LoginMaui.db");
            }
        }
    }
}