using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorpagesTutorial.Models;
using RazorpagesTutorial.Services;
#nullable disable

namespace RazorpagesTutorial.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IEmployeeRepository employeeRepository;
        public IEnumerable<Employee> employees;
        public IndexModel(ILogger<IndexModel> logger, IEmployeeRepository employeeRepository)
        {
            _logger = logger;
            this.employeeRepository = employeeRepository;
        }

        public void OnGet()
        {
            employees=employeeRepository.GetAllEmployees();
        }
    }
}