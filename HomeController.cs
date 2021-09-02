using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace BasicWebSite
{
    public class HomeController : Controller
    {
        public IWebHostEnvironment Environment { get; set; }
        public HomeController(IWebHostEnvironment environment)
        {
            this.Environment = environment;
        }
        public IActionResult Test(string text)
        {
            string filePath = Path.Combine(this.Environment.WebRootPath, "test", text + ".txt");
            System.IO.File.WriteAllText(filePath, text);

            return this.View();
        }
    }
}
