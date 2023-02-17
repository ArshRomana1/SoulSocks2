using Microsoft.EntityFrameworkCore;
using SoulSocks.Models;

namespace SoulSocks.Data
{
    public class SoulSocksContext : DbContext
    {
        public SoulSocksContext(DbContextOptions<SoulSocksContext> options)
            : base(options)
        {
        }

        public DbSet<Sock> Sock { get; set; }
    }
}