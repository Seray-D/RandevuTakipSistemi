using Microsoft.EntityFrameworkCore;
using Main.Entities; 

namespace Main.Data
{
    public class AppDbContext : DbContext
    {
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        
        public DbSet<Appointment> Appointments { get; set; }
        public Dbgit add.Set<Category> Categories { get; set; }
        public DbSet<Note> Notes { get; set; }
    }
}