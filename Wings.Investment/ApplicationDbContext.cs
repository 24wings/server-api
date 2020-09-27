using System;
using Microsoft.EntityFrameworkCore;
using Wings.Investment.Models.Rbac;

namespace Wings.Investment
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<RbacUser> users { get; set; }
        public DbSet<RbacRole> roles { get; set; }
        public DbSet<RbacMenu> menus { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

    }
}
