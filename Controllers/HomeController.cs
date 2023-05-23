using iText.Html2pdf;
using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.CodeModifier.CodeChange;
using NuGet.Protocol;
using PageForMarkReport.Models;
using System.Diagnostics;
using System.Net;
using ToAspNetProject;

namespace PageForMarkReport.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Print()
        {
            var model = MarkReportPrintDto.Instanse;
            // Handler for convert Html to Pdf
            string html = await ConvertHtmlToString.RenderViewToStringAsync("Print", model, ControllerContext);

            using var file = new FileStream("output.pdf", FileMode.Create);

            HtmlConverter.ConvertToPdf(html, file);
            return View(file);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}