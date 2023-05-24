using Module_2.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;

public class AllowanceController : Controller
{
    private List<Allowance> allowances; // Предполагается, что данные о надбавках хранятся в списке

    public AllowanceController()
    {
        // Инициализация списка надбавок
        allowances = new List<Allowance>();
    }

    // Действие для отображения списка надбавок
    public ActionResult Index()
    {
        return View(allowances);
    }

    // Действие для отображения деталей о надбавке по идентификатору
    public ActionResult Details(int id)
    {
        var allowance = allowances.FirstOrDefault(a => a.Id == id);
        if (allowance == null)
        {
            return HttpNotFound(); // Если надбавка не найдена, возвращаем ошибку 404
        }

        return View(allowance);
    }

    // Другие методы действий для создания, редактирования и удаления надбавок
    // ...
}