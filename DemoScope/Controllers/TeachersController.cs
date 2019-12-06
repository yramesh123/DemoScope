using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoScope.DAL;
using DemoScope.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using DemoScope.Filters;

namespace DemoScope.Controllers
{
    [EnableCors("AllowOrigin")]
    [CustomLog]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private IStudentRepository studentRepository;

        
        public TeachersController(IStudentRepository _studentRepository)
        {
            studentRepository = _studentRepository;
        }

        [Route("api/Teachers/Get")]
        public ActionResult<IEnumerable<TeacherModel>> GetTeachers()
        {
            return studentRepository.GetTeachersModels();

        }

        // GET api/values/5        
        [Route("api/Teachers/Get/{id}")]
        public ActionResult<TeacherModel> GetTeacher(int id)
        {
            return studentRepository.GetTeachersModels().FirstOrDefault(m => m.EmpId == id);
        }

    }
}
