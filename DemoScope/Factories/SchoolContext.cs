using DemoScope.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoScope.Factories
{
    public class SchoolContext : DbContext
    {
        public DbSet<StudentModel> Students { get; set; }

        public DbSet<TeacherModel> Teachers { get; set; }
      
        public SchoolContext(DbContextOptions<SchoolContext> dc) : base(dc)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          
        }
    }
}
