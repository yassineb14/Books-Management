﻿using Microsoft.AspNetCore.Mvc;

namespace Books_Management.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
