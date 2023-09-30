using Core_WebAPI.Models;
using Core_WebAPI.TestUnit;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Core_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        // Định nghĩa ra biến danh sách sinh viên; Để lưu sinh viên khi được add thêm mới
        static List<Student> ds_sinhvien2 = new List<Student>();

        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            // Trả về kết quả cho giao diện API
            return ds_sinhvien2.OrderByDescending(i => i.Ten).AsEnumerable();
        }

        // GET api/<StudentController>/221070001
        [HttpGet("{msv}")]
        public Student Get(string msv)
        {
            return ds_sinhvien2.FirstOrDefault(i => i.Msv == msv);
        }

        // GET api/<StudentController>/search/keyword
        [HttpGet("search/{keyword}")]
        public IEnumerable<Student> Search(string keyword)
        {
            return ds_sinhvien2.Where(i => i.Ten.ToLower().Contains(keyword.ToLower()));
        }

        //// POST api/<StudentController>
        //[HttpPost]
        //public IActionResult Post([FromBody] Student sinhvien)
        //{
        //    try
        //    {
        //        ds_sinhvien2.Add(sinhvien);
        //        return Ok(ds_sinhvien2);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Content(ex.ToString());
        //    }
        //}

        // POST api/<StudentController>
        [HttpPost]
        public HttpResponseMessage Post([FromBody] Student sinhvien)
        {
            try
            {
                ds_sinhvien2.Add(sinhvien);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
