using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.Encodings.Web;

namespace Day2_Nguyễn_Thị_Kim_Dung.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int id = 1, int numtime = 1)
        {
            ViewBag.Message = "HELLO " +name;
            ViewBag.ID = "ID của bạn là " + id;
            ViewBag.numtime = numtime;
            return View();

        }

        [Route("Xin Chao Attribute Routing")]
        public IActionResult TestRouting()
        {
            return Content("Thành công! Đây là trang Attribute Routing.");
        }
    }
}
