using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View(); // Isso ir� procurar e renderizar Views/Home/Index.cshtml
    }
 
    public IActionResult Mais()
    {
        return View();
    }
    
    // Se voc� removeu as a��es Services() e Contacts(), pode deixar apenas a Index.
}