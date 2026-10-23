using Microsoft.AspNetCore.Mvc;
using System;

namespace Day2_Nguyễn_Thị_Kim_Dung.ViewComponents
{
    public class TimeViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            return View("Default", currentTime);
        }
    }
}