using System.Web.Mvc;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View();
    }

    public ActionResult About()
    {
        ViewData["Message"] = "Your application description page.";
        return View();
    }

    public ActionResult Contact()
    {
        ViewData["Message"] = "Your contact page.";
        return View();
    }

    public ActionResult Privacy()
    {
        return View();
    }

    // Другие действия контроллера...

    public ActionResult Error()
    {
        return View();
    }
}