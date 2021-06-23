using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolAPI.Models;
using SchoolAPI.Respository;

namespace SchoolAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentInClassController : ControllerBase
    {
        IStudentInClassRepository studentinclassRepository;
        public StudentInClassController(IStudentInClassRepository _studentinclassRepository)
        {
            studentinclassRepository = _studentinclassRepository;
        }

        [HttpGet]
        [Route("GetStudent")]
        public async Task<IActionResult> GetStudentInClass()
        {
            try
            {
                var student = await studentinclassRepository.GetStudentInClass();
                if (student == null)
                {
                    return NotFound();
                }

                return new OkObjectResult(student);
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }
        [HttpGet]
        [Route("GetStudentByID")]
        public async Task<IActionResult> GetStudentInClassByName(string classname, string studentname)
        {
            if (classname == null && studentname == null)
            {
                return BadRequest();
            }

            try
            {
                var student = await studentinclassRepository.GetStudentInClassByName(classname, studentname);

                if (student == null)
                {
                    return NotFound();
                }

                return Ok(student);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("AddStudent")]
        public async Task<IActionResult> AddStudentToClass([FromBody] StudentInClass student)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var studentinclass = await studentinclassRepository.AddStudentToClass(student);
                    if (studentinclass != null)
                    {
                        return Ok(studentinclass);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (Exception)
                {

                    return BadRequest();
                }

            }

            return BadRequest();
        }

        [HttpDelete]
        [Route("DeleteStudent")]
        public async Task<IActionResult> DeleteStudent(string classname, string studentname)
        {
            int result = 0;

            if (classname == null&&studentname == null)
            {
                return BadRequest();
            }

            try
            {
                result = await studentinclassRepository.DeleteStudentInClass(classname,studentname);
                if (result == 0)
                {
                    return NotFound();
                }
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }


        [HttpPost]
        [Route("UpdateStudent")]
        public async Task<IActionResult> UpdateStudent([FromBody] StudentInClass student)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await studentinclassRepository.UpdateStudentInClass(student);

                    return Ok();
                }
                catch (Exception ex)
                {
                    if (ex.GetType().FullName == "Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException")
                    {
                        return NotFound();
                    }

                    return BadRequest();
                }
            }

            return BadRequest();
        }
    }
}
