using DemoScope.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoScope.DAL
{
    public interface IStudentRepository
    {
        List<StudentModel> GetStudentsModels();
    }
}
