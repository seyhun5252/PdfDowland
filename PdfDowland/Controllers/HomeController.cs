using BusinessLayer.Concrete;
using EntityLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PdfDowland.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PdfDowland.Controllers
{
    public class HomeController : Controller
    {
        PdfManager c = new PdfManager();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Pdf()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Pdf(Pdf p, IFormFile file1)
        {
            if (file1 != null)
            {
                var extention = Path.GetExtension(file1.FileName);
                if (true)
                {
                    var randomName = string.Format($"{Guid.NewGuid()}{extention}");
                    p.PdfPath = randomName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\files", randomName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file1.CopyToAsync(stream);
                    }
                }
            }

            c.CreatePaper(p);
            ViewBag.Message = String.Format("Basarıli bir sekilde yuklenmistir.");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
