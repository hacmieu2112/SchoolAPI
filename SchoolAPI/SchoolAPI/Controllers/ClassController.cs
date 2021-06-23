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
    public class ClassController : ControllerBase
    {
        IClassRepository classRepository;
        public ClassController(IClassRepository _classRepository)
        {
            classRepository = _classRepository;
        }

        [HttpGet]
        [Route("GetClass")]
        public async Task<IActionResult> GetClass()
        {
            try
            {
                var class1 = await classRepository.GetClass();
                if (class1 == null)
                {
                    return NotFound();
                }

                return new OkObjectResult(class1);
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }
        [HttpGet]
        [Route("GetClassByID")]
        public async Task<IActionResult> GetClassByID(int classId)
        {
            if (classId == null)
            {
                return BadRequest();
            }

            try
            {
                var class1 = await classRepository.GetClassByID(classId);

                if (class1 == null)
                {
                    return NotFound();
                }

                return Ok(class1);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("AddClass")]
        public async Task<IActionResult> AddClass([FromBody] Class class1)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var classId = await classRepository.AddClass(class1);
                    if (classId != null)
                    {
                        return Ok(classId);
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
        [Route("DeleteClass")]
        public async Task<IActionResult> DeleteClass(int classId)
        {
            int result = 0;

            if (classId == null)
            {
                return BadRequest();
            }

            try
            {
                result = await classRepository.DeleteClass(classId);
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
        [Route("UpdateClass")]
        public async Task<IActionResult> UpdateClass([FromBody] Class class1)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await classRepository.UpdateClass(class1);

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
