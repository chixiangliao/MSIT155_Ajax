using AjaxDemoV2.Models;
using Microsoft.AspNetCore.Mvc;

namespace AjaxDemoV2.Controllers
{
    public class ApiController : Controller
    {
        private MyDBContext _dbContext;
        public ApiController(MyDBContext dBContext) 
        {
            _dbContext = dBContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cities()
        {
            var data = _dbContext.Addresses.Select(x => x.City).Distinct();
            return Json(data);
        }
    }
}
