using GreenMountain.Models;
using Microsoft.EntityFrameworkCore;

namespace GreenMountain.DataAccess
{
    public class GreenMountainContext : DbContext 
    {
        public DbSet<Trail> Trails { get; set; }

        public GreenMountainContext(DbContextOptions<GreenMountainContext> options) : base(options)
        {

        }
    }
}
