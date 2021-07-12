using EmployeeManagement.Web.Pages.Services;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeDetailsBase : ComponentBase
    {
        public Employee Employee { get; set; } = new Employee();

        protected string Coordinates { get; set; }


        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        [Parameter]
        public string Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            // If Id value is not supplied in the URL, use the value 1
            Id = Id ?? "1";
            Employee = await EmployeeService.GetEmployee(int.Parse(Id));
        }
    }
}