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

        public static Student GetStudentByMsv(string msv)
        {
            //return ds_sinhvien2.Find(i => i.Msv == msv);
            return ds_sinhvien2.Where(i => i.Msv.ToLower().Contains(msv.ToLower())).First();
        }

        public static Student GetStudentByEmail(string email)
        {
            //return ds_sinhvien2.Find(i => i.Msv == msv);
            return ds_sinhvien2.Where(i => i.Email.ToLower().Contains(email.ToLower())).First();
        }

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
        public HttpResponseMessage Post([FromBody] Student sv)
        {
            try
            {
                ds_sinhvien2.Add(sv);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }

        // PUT api/<StudentController>/5
        [HttpPut("{msv}")]
        public IActionResult Put(string msv, [FromBody] Student sv)
        {
            // PUT là dể update: Khi sử dụng phải gửi 1 bản ghi đầy đủ các trường thông tin để yêu cầu cập nhật.
            // Lưu ý: Nếu các trường thông tin khác để trống --> khi cập nhật sẽ xóa (bỏ trống hoặc chứa giá trị null)
            try
            {
                // B1: Kiểm tra sự tồn tài của đối tượng theo id
                if (msv != sv.Msv)
                    return BadRequest("Msg: Mã sinh viên không tồn tại");

                var sv_old = StudentController.GetStudentByMsv(msv);
                var sv_new = sv;

                // B2: Cập nhật các trường thông tin
                ds_sinhvien2.Remove(sv_old);
                ds_sinhvien2.Add(sv_new);

                // B3: Thông báo kết quả
                return Ok(ds_sinhvien2);
            }
            catch (Exception ex)
            {
                return Content(ex.ToString());
            }
        }


        // PATCH api/<StudentController>/5
        [HttpPatch("{msv}")]
        public IActionResult Patch(string msv, [FromBody] Student sv)
        {
            try
            {
                // B1: Kiểm tra sự tồn tài của đối tượng theo id
                if (msv != sv.Msv)
                    return BadRequest("Msg: Mã sinh viên không tồn tại");

                var sv_old = StudentController.GetStudentByMsv(msv);
                var sv_new = sv;

                // B2: Cập nhật các trường thông tin
                ds_sinhvien2.Remove(sv_old);
                ds_sinhvien2.Add(sv_new);

                // B3: Thông báo kết quả
                return Ok(ds_sinhvien2);
            }
            catch (Exception ex)
            {
                return Content(ex.ToString());
            }
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
