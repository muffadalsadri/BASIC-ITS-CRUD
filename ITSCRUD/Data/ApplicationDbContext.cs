using ITSCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace ITSCRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<member> members { get; set; }
    }
}