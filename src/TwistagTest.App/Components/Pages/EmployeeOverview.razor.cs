using TwistagTest.App.Models;
using TwistagTest.Shared.Models;

namespace TwistagTest.App.Components.Pages
{
    public partial class EmployeeOverview
    {
        public List<Employee> Employees { get; set; } = default!;

        //protected override void OnInitialized()
        //{
        //    Employees = MockDataService.Employees;
        //}
    }
}
