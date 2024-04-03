using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using System;
using TwistagTest.App.Services;
using TwistagTest.Shared.Models;

namespace TwistagTest.App.Components.Pages
{
    public partial class EmployeeEdit
    {
        [Inject]
        public IEmployeeDataService? EmployeeDataService { get; set; }

        [Parameter]
        public string Id { get; set; } = string.Empty;

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public Employee? _Employee { get; set; } = new Employee();

        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Saved;

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                Guid.TryParse(Id, out Guid id);
                if (id != Guid.Empty)
                {
                    _Employee = await EmployeeDataService.GetEmployeeDetails(id);
                }
                else
                {
                    _Employee = new Employee { FirstName = "john", LastName = "doe", Email = "johndoe@gmail.com", BirthDate = DateTime.Now, JoinedDate = DateTime.Now };
                }
            }
        }

        protected async Task HandleInvalidSubmit()
        {
            StatusClass = "alert-danger";
            this.Message = "There are some validation errors. Please try again.";
        }

        protected async Task Submit()
        {
            if (_Employee.Id == Guid.Empty)
            {
                await EmployeeDataService.AddEmployee(_Employee);
            }
            else
            {
                await EmployeeDataService.UpdateEmployee(_Employee);
            }
        }

        protected async Task HandleValidSubmit()
        {
            if (_Employee.Id == Guid.Empty)
            {
                await EmployeeDataService.AddEmployee(_Employee);
            }
            else
            {
                await EmployeeDataService.UpdateEmployee(_Employee);
            }
            Saved = true;
        }

        protected async Task DeleteEmployee(Guid id)
        {
            await EmployeeDataService.DeleteEmployee(_Employee.Id);

            StatusClass = "alert-success";
            Message = "Deleted successfully";

            Saved = true;
        }

        protected void NavigateToOverview()
        {
            NavigationManager.NavigateTo("/employeeoverview");
        }
    }
}
