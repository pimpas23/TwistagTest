using Microsoft.AspNetCore.Components;
using TwistagTest.App.Services;
using TwistagTest.Shared.Models;

namespace TwistagTest.App.Components
{
    public partial class EmployeeOverview
    {
        [Inject]
        public IEmployeeDataService? employeeDataService { get; set; }
        public List<Employee>? Employees { get; set; } = default!;
        private Employee? _selectedEmployee;

        protected override async Task OnInitializedAsync()
        {
            Employees = (await employeeDataService?.GetAllEmployees()).ToList();
        }

        public void ShowQuickViewPopup(Employee selectedEmployee)
        {
            _selectedEmployee = selectedEmployee;
        }
    }
}
