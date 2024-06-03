using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

[Authorize]
public class StudentController : Controller
{
    private readonly ApplicationDbContext _context;

    public StudentController(ApplicationDbContext context)
    {
        _context = context;
    }

    // Ваши действия контроллера

    [HttpGet]
    public IActionResult Index()
    {
        // Получение текущего пользователя
        var currentUser = HttpContext.User;
        // Получение Id текущего пользователя
        var currentUserId = currentUser.Claims.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
        // Использование Id для поиска студента в базе данных
        var student = _context.Students.FirstOrDefault(s => s.UserId == currentUserId);

        // Если студент найден, возвращаем представление с информацией о студенте
        if (student != null)
        {
            return View(student);
        }
        // В противном случае перенаправляем на страницу ошибки или другое представление
        else
        {
            return RedirectToAction("Error", "Home");
        }
    }
}
