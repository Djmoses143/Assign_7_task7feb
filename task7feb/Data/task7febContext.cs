using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using task7feb.Models;

namespace task7feb.Data
{
    public class task7febContext : DbContext
    {
        public task7febContext (DbContextOptions<task7febContext> options)
            : base(options)
        {
        }

        public DbSet<task7feb.Models.Movie> Movie { get; set; } = default!;
    }
}
