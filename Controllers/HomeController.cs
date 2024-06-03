using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Grades()
    {
        // Здесь необходимо получить данные из базы данных и передать их в представление
        return View();
    }

    public IActionResult Achievements()
    {
        // Здесь необходимо получить данные из базы данных и передать их в представление
        return View();
    }

    public IActionResult Teachers()
    {
        // Здесь необходимо получить данные из базы данных и передать их в представление
        return View();
    }
}
