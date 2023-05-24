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
    public IActionResult Index()
    {
        return View(employees);
    }

    // Действие для отображения деталей о сотруднике по идентификатору
    public IActionResult Details(int id)
    {
        var employee = employees.FirstOrDefault(e => e.Id == id);
        if (employee == null)
        {
            return NotFound(); // Если сотрудник не найден, возвращаем ошибку 404
        }

        return View(employee);
    }

    // Другие методы действий для создания, редактирования и удаления сотрудников
    // ...
}









































































//public class EmployeeController : Controller
//{
//    private readonly List<Employee> employees; // Заглушка для данных сотрудников
//    private readonly List<Position> positions; // Заглушка для данных должностей
//    private readonly List<Allowance> allowances; // Заглушка для данных надбавок

//    public EmployeeController()
//    {
//        // Инициализация заглушек данных
//        employees = new List<Employee>
//        {
//            new Employee { Id = 1, FullName = "John Doe", EmployeeNumber = 1001, PositionId = 1, Salary = 5000 },
//            new Employee { Id = 2, FullName = "Jane Smith", EmployeeNumber = 1002, PositionId = 2, Salary = 6000 },
//            // Добавьте других сотрудников
//        };

//        positions = new List<Position>
//        {
//            new Position { Id = 1, Name = "Manager", BaseSalary = 5000 },
//            new Position { Id = 2, Name = "Developer", BaseSalary = 4000 },
//            // Добавьте другие должности
//        };

//        allowances = new List<Allowance>
//        {
//            new Allowance { Id = 1, Name = "Bonus", Amount = 1000, PositionId = 1 },
//            new Allowance { Id = 2, Name = "Overtime", Amount = 500, PositionId = 2 },
//            // Добавьте другие надбавки
//        };
//    }

//    public IActionResult Index()
//    {
//        List<EmployeeViewModel> employeeViewModels = new List<EmployeeViewModel>();

//        foreach (var employee in employees)
//        {
//            var position = positions.FirstOrDefault(p => p.Id == employee.PositionId);
//            var allowancesForPosition = allowances.Where(a => a.PositionId == employee.PositionId);

//            decimal totalAllowances = allowancesForPosition.Sum(a => a.Amount);
//            decimal totalSalary = employee.Salary + totalAllowances;

//            EmployeeViewModel employeeViewModel = new EmployeeViewModel
//            {
//                Employee = employee,
//                Position = position,
//                TotalSalary = totalSalary
//            };

//            employeeViewModels.Add(employeeViewModel);
//        }

//        return View(employeeViewModels);
//    }

//    public IActionResult Details(int id)
//    {
//        var employee = employees.FirstOrDefault(e => e.Id == id);
//        if (employee == null)
//        {
//            return NotFound();
//        }

//        var position = positions.FirstOrDefault(p => p.Id == employee.PositionId);
//        var allowancesForPosition = allowances.Where(a => a.PositionId == employee.PositionId);

//        decimal totalAllowances = allowancesForPosition.Sum(a => a.Amount);
//        decimal totalSalary = employee.Salary + totalAllowances;

//        EmployeeViewModel employeeViewModel = new EmployeeViewModel
//        {
//            Employee = employee,
//            Position = position,
//            TotalSalary = totalSalary
//        };

//        return View(employeeViewModel);
//    }

//    // Другие методы действий

//    // ViewModel для передачи данных сотрудника в представление
//    public class EmployeeViewModel
//    {
//        public Employee Employee { get; set; }
//        public Position Position { get; set; }
//        public decimal TotalSalary { get; set; }
//    }
//}