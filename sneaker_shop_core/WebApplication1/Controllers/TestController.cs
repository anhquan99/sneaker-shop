﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return ViewComponent("ProductList");
        }
    }
}
