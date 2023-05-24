using Module_2.Models;
using System.Collections.Generic;
using System.Web.Mvc;

public class PositionController : Controller
{
    private List<Position> positions; // Предполагается, что данные о должностях хранятся в списке

    public PositionController()
    {
        // Инициализация списка должностей
        positions = new List<Position>();
    }

    // Действие для отображения списка должностей
    public IActionResult Index()
    {
        return View(positions);
    }

    // Действие для отображения деталей о должности по идентификатору
    public IActionResult Details(int id)
    {
        var position = positions.FirstOrDefault(p => p.Id == id);
        if (position == null)
        {
            return NotFound(); // Если должность не найдена, возвращаем ошибку 404
        }

        return View(position);
    }

    // Другие методы действий для создания, редактирования и удаления должностей
    // ...
}