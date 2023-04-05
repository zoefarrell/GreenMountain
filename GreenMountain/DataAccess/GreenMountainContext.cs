using Microsoft.EntityFrameworkCore;

namespace GreenMountain.DataAccess
{
    public class GreenMountainContext : DbContext 
    {
        public GreenMountainContext(DbContextOptions<GreenMountainContext> options) : base(options)
        {

        }
    }
}
