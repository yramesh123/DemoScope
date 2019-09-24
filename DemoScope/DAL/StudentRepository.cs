using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using DemoScope.Factories;
using Microsoft.EntityFrameworkCore;
using DemoScope.Models;

namespace DemoScope.DAL
{
    public class StudentRepository : IStudentRepository
    {
        private IConfiguration configuration;
        private SchoolContext schoolContext;

        public StudentRepository(IConfiguration Configuration, SchoolContext dbContext)
        {
            configuration = Configuration;
            schoolContext = dbContext;
        }

        public List<StudentModel> GetStudentsModels()
        {
            return schoolContext.Students.ToList();            
        }
            
    }
}
