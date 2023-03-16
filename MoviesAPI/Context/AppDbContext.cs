using Microsoft.EntityFrameworkCore;
using MoviesAPI.Models;

namespace MoviesAPI.Context
{
    public class APIDbContext : DbContext
    {

        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }

    }
}
