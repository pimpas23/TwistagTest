using Microsoft.AspNetCore.Components;
using TwistagTest.Shared.Models;

namespace TwistagTest.App.Components
{
    public partial class EmployeeCard
    {
        [Parameter]
        public Employee Employee { get; set; } = default!;

        [Parameter]
        public EventCallback<Employee> EmployeeQuickViewClicked { get; set; }
    }
}
