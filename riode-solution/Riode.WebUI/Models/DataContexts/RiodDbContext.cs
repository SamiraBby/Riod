using Microsoft.EntityFrameworkCore;
using Riode.WebUI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Riode.WebUI.Models.DataContexts
{
    public class RiodDbContext : DbContext
    {
        public RiodDbContext(DbContextOptions options)
            :base(options)
        {
                
        }
        public DbSet<Contact> Contacts { get; set; }
    }
}
