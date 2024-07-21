using System.Diagnostics;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Portfolio.Services;

namespace Portfolio.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly repoProjects _repositoryProjects;

    public HomeController(ILogger<HomeController> logger, repoProjects projects)
    {
        _logger = logger;
        _repositoryProjects = projects;
    }

    public IActionResult Index()
    {
        
        var projects = _repositoryProjects.GetProjects();
        return View(projects);
    }

    public IActionResult P()
    {

        return View();
    }


    //ACCIÓN CAMBIAR IDIOMA & CREACIÓN DE COOKIE DE IDIOMA
    public IActionResult CambiarIdioma(string cultura, string urlRetorno)
    {
        Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
            CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(cultura)),

                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

        return LocalRedirect(urlRetorno);
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
