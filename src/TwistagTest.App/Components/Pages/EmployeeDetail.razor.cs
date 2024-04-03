using Microsoft.AspNetCore.Components;
using TwistagTest.App.Models;
using TwistagTest.App.Services;
using TwistagTest.Shared.Models;

namespace TwistagTest.App.Components.Pages
{
    public partial class EmployeeDetail
    {
        [Inject]
        public IEmployeeDataService? EmployeeDataService { get; set; }

        [Parameter]
        public string Id { get; set; } = string.Empty;

        public Employee? Employee { get; set; } = new Employee();

        protected async override Task OnInitializedAsync()
        {
            Employee = await EmployeeDataService.GetEmployeeDetails(Guid.Parse(Id));
        }
    }
}
