using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoCrafts.Website.Models
{
    public class ConnectionDBClass :DbContext
    {
        public ConnectionDBClass(DbContextOptions<ConnectionDBClass> options) :base(options)
        {

        }

        public DbSet<AccountClass> account { get; set; }
    }
}
