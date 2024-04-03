using System.Diagnostics.Metrics;
using System.Reflection;
using TwistagTest.Shared.Models;

namespace TwistagTest.App.Models
{
    public class MockDataService
    {
        private static List<Employee> _employees;
        public static List<Employee> Employees
        {
            get
            {
                if (_employees == null)
                {
                    InitializeMockEmployees();
                }

                return _employees;
            }
        }

        private static void InitializeMockEmployees()
        {
            var e1 = new Employee
            {
                Id = Guid.NewGuid(),
                BirthDate = new DateTime(1989, 3, 11),
                Email = "bethany@bethanyspieshop.com",
                FirstName = "Bethany",
                LastName = "Smith",
                PhoneNumber = "324777888773",
                ExitDate = null,
                JoinedDate = new DateTime(2015, 3, 1),
            };

            var e2 = new Employee
            {
                Id = Guid.NewGuid(),
                BirthDate = new DateTime(1979, 1, 16),
                Email = "gill@bethanyspieshop.com",
                FirstName = "Gill",
                LastName = "Cleeren",
                PhoneNumber = "33999909923",
                ExitDate = null,
                JoinedDate = new DateTime(2017, 12, 24),
            };

            _employees = new List<Employee>() { e1, e2};
        }
    }
}
