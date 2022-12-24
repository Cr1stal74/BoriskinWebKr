using BoriskinWebKr.DAO.Models;
using Microsoft.EntityFrameworkCore;

namespace BoriskinWebKr.DAO.Contexts
{
    public class PictureDbContext : DbContext 
    {
        public DbSet<Picture> Pictures { get; set; }

        public PictureDbContext(DbContextOptions<PictureDbContext> options) : base(options)
        {
        }
    }
}
