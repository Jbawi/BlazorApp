using EmployeeManagement.Web.Pages.Services;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        //protected string ButtonText { get; set; } = "Hide Footer";
        //protected string CssClass { get; set; } = null;
        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        public bool ShowFooter { get; set; } = true;

        protected string Coordinates { get; set; }

        public IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetEmployees()).ToList();
        }
        protected async Task EmployeeDeleted()
        {
            Employees = (await EmployeeService.GetEmployees()).ToList();
        }
        protected int SelectedEmployeesCount { get; set; } = 0;

        protected void EmployeeSelectionChanged(bool isSelected)
        {
            if (isSelected)
            {
                SelectedEmployeesCount++;
            }
            else
            {
                SelectedEmployeesCount--;
            }
        }

        //protected void Button_Click()
        //{
        //    if (ButtonText == "Hide Footer")
        //    {
        //        ButtonText = "Show Footer";
        //        CssClass = "HideFooter";
        //    }
        //    else
        //    {
        //        CssClass = null;
        //        ButtonText = "Hide Footer";
        //    }
        //}
    }
}