﻿using Microsoft.AspNetCore.Mvc;

namespace TrainingFPTCo.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("SessionUserId")))
            {
                return RedirectToAction(nameof(DashboardController.Index), "Dashboard");
            }
            return View();
        }
    }
}
