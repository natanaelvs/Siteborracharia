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
    
    // Se você removeu as ações Services() e Contacts(), pode deixar apenas a Index.
}