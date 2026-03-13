using Microsoft.EntityFrameworkCore;
using MonkeyCards.Models;
using System.Collections.Generic;

namespace MonkeyCards.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Monkey> Monkeys => Set<Monkey>();
    }
}