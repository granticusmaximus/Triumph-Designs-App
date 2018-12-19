using System;
using Microsoft.EntityFrameworkCore;
using Triumph.Web.Entities;

namespace Triumph.Web.Data
{
    public class TriumphDbContext : DbContext
    {
        public TriumphDbContext(DbContextOptions<TriumphDbContext> options)
            : base(options)
        {
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Employees> Employee { get; set; }
    }
}
