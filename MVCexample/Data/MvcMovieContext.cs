using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCexample.Models;

namespace MVCexample.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<MVCexample.Models.Movie> Movie { get; set; }
    }
}