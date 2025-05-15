using EmployeesApp.Web.Models;

namespace EmployeesApp.Web.Services
{
    public class EmployeeService
    {
        private List<Employee> employees = [
            new Employee {
                Id = 12,
                Name = "Anna Andersson",
                Email = "anna84@gmail.com"
            },
            new Employee {
                Id = 2,
                Name = "Berit Bertilsson",
                Email = "berit@gmail.com"
            },
            new Employee {
                Id = 344,
                Name = "Håkan Jonsson",
                Email = "hakis@gmail.com"
            }
        ];

        public void AddEmployee(Employee employee)
        {
            employee.Id = employees.Count == 0 ? 1 : employees.Max(d => d.Id) + 1;
            employees.Add(employee);
        }

        public Employee[] GetAll() => employees
            .OrderBy(d => d.Name)
            .ToArray();

        public Employee GetById(int id) => employees.Single(d => d.Id == id);

    }
}
