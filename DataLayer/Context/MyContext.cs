using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Context
{
    public class MyContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<List>  Lists { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Task> Tasks { get; set; }

    }
}
