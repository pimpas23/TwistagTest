using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwistagTest.Shared.Models;

namespace TwistagTest.Business.Interfaces
{
    public interface IEmployeeService
    {
        Task Add(Employee employee);

        Task Update(Employee employee);

        Task Delete(Guid id);

        Task<Employee> Get(Guid id);

        Task<IEnumerable<Employee>> GetAll();
    }
}
