#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ConsoleAppProject.App03;
using Web.Pages.Network;

namespace Web.Data
{
    public class WebContext : DbContext
    {
        public WebContext (DbContextOptions<WebContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }

        public DbSet<Post> Posts { get; set; }
        public DbSet<PhotoPost> Photos { get; set; }
        public DbSet<MessagePost> Messages { get; set; }
    }
}
