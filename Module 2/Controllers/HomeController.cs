using Module_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

public class HomeController : Controller
{
    private List<Employee> employees; // Предполагается, что данные о сотрудниках хранятся в списке

    public HomeController()
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

    // Действие для подсчета средней суммы зарплат сотрудников
    public ActionResult CalculateAveragePayment()
    {
        decimal averagePayment = employees.Average(e => e.TotalPayment);

        // Возвращаем среднюю сумму зарплаты
        return PartialView("_AveragePayment", averagePayment);
    }

    // Действие для проверки превышения суммы выплаты сотрудника
    public ActionResult CheckPaymentExceeding(int employeeId)
    {
        var employee = employees.FirstOrDefault(e => e.Id == employeeId);
        if (employee == null)
        {
            return HttpNotFound(); // Если сотрудник не найден, возвращаем ошибку 404
        }

        decimal maximumPayment = 10000; // Максимальная сумма выплаты

        bool paymentExceeded = employee.TotalPayment > maximumPayment;

        // Возвращаем результат проверки
        return Json(new { exceeded = paymentExceeded });
    }
}