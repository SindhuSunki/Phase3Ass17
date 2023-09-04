using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment17.Model;

namespace Assignment17.Data
{
    public class Assignment17DbContext : DbContext
    {
        public Assignment17DbContext (DbContextOptions<Assignment17DbContext> options)
            : base(options)
        {
        }

        public DbSet<Assignment17.Model.Movie> Movie { get; set; } = default!;
    }
}
