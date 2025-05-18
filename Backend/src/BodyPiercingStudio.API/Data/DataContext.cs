using BodyPiercingStudio.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BodyPiercingStudio.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Jewelry> Jewelries { get; set; }
    }
}