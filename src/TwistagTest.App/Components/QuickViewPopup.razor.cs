using Microsoft.AspNetCore.Components;
using TwistagTest.Shared.Models;

namespace TwistagTest.App.Components
{
    public partial class QuickViewPopup
    {
        [Parameter]
        public Employee? Employee { get; set; }

        private Employee? _employee;

        protected override void OnParametersSet()
        {
            _employee = Employee;
        }

        public void Close()
        {
            _employee = null;
        }
    }
}
