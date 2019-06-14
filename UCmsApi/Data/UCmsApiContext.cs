using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UCmsApi.Model;

namespace UCmsApi.Data
{
    public class UCmsApiContext : DbContext 
    {
        public UCmsApiContext(DbContextOptions<UCmsApiContext> options) : base(options)
        {

        }

        public DbSet<Page> Pages { get; set; }
        public DbSet<Sidebar> Sidebar { get; set; }
        public DbSet<User> Users{ get; set; }

    }
}
