using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace ActivityCenter.Models
{
    public class ActivityContext : DbContext
    {
        public ActivityContext(DbContextOptions<ActivityContext> options) : base(options) { }
        public DbSet<User> Users {get; set;}
        public DbSet<Activ> Activities {get; set;}
        public DbSet<Participate> Participate {get; set;}
    }
}