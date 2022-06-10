using _10IyunTask.Models;
using Microsoft.EntityFrameworkCore;

namespace _10IyunTask.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<DbContext> options):base(options)
        {
        }
        public DbSet<Slider> sliders { get; set; }
    }   
}
