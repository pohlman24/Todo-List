using Microsoft.EntityFrameworkCore;
using Rocky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Data
{
    public class ApplicationDbContext : DbContext
    {
        // this is just some basic setup for the database
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        // When ever you make a new model and want to add it to the DB then you add this code 
        // Categories is the name of column in the DB 
        public DbSet<Category> Categories{ get; set; }
        public DbSet<ApplicationType> ApplicationType { get; set; }

    }
}
