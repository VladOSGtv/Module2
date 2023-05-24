using Module_2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;


public class EmployeeController : Controller
{
    private List<Employee> employees; // Предполагается, что данные о сотрудниках хранятся в списке

    public EmployeeController()
    {
        // Инициализация списка сотрудников
        employees = new List<Employee>();
    }

    // Действие для отображения списка сотрудников
    public ActionResult Index()
    {
        return View(employees);
    }

    // Действие для отображения деталей о сотруднике по идентификатору
    public ActionResult Details(int id)
    {
        var employee = employees.FirstOrDefault(e => e.Id == id);
        if (employee == null)
        {
            return HttpNotFound(); // Если сотрудник не найден, возвращаем ошибку 404
        }

        return View(employee);
    }

    // Другие методы действий для создания, редактирования и удаления сотрудников
    // ...
}


