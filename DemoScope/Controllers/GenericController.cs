﻿using System;
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
    [Route("api/[controller]")]
    [EnableCors("AllowOrigin")]
    [CustomLog]
    [ApiController]
    public class GenericController : ControllerBase
    {
        private IStudentRepository studentRepository;

        public GenericController(IStudentRepository _studentRepository)
        {
            studentRepository = _studentRepository;
        }

        // GET api/values
        [EnableCors("AllowOrigin")]
        [HttpGet]
        public ActionResult<IEnumerable<StudentModel>> Get()
        {
            return studentRepository.GetStudentsModels();   

        }

       
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<StudentModel> Get(int id)
        {
            return studentRepository.GetStudentsModels().FirstOrDefault(m => m.RollNumber == id);
        }

    
        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
