using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourSoutienApp2.Models
{
    public class CoursDbContext:DbContext
    {
        public CoursDbContext(DbContextOptions<CoursDbContext>options) : base(options)
        {}
        public DbSet<Cours>Cours { get; set; }
    }
}
