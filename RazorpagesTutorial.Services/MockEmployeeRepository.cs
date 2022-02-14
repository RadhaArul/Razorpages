using RazorpagesTutorial.Models;
using System.Linq;
#nullable disable

namespace RazorpagesTutorial.Services
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){ Id = 1, Name ="Mary",Department =Dept.Hr,
                    Email="mary@gmail.com",PhotoPath="mary.jpg"},
                new Employee(){ Id = 2, Name ="John",Department =Dept.It,
                    Email="john@gmail.com",PhotoPath="john.jpg"},
                new Employee(){ Id = 3, Name ="Sara",Department =Dept.It,
                    Email="sara@gmail.com",PhotoPath="sara.jpg"},
                new Employee(){ Id = 4, Name ="David",Department =Dept.Payroll,
                    Email="david@gmail.com"},
            };
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e=>e.Id==id);
        }
    }
}