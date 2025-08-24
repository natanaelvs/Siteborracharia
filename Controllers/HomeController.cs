using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View(); // Isso irá procurar e renderizar Views/Home/Index.cshtml
    }
 
    public IActionResult Mais()
    {
        return View();
    }

    public IActionResult Sobre()
    {
        return View();
    }
    public IActionResult Servicos() 
    {
        return View();
    }
    public IActionResult Fotos()
    {
        return View();
    }
    public IActionResult Produtos()
    {
        return View();
    }

}