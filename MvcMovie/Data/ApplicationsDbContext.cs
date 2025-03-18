using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

    public class ApplicationsDbContext : DbContext
    {
        public ApplicationsDbContext (DbContextOptions<ApplicationsDbContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Employee> Employee { get; set; } = default!;
    }
