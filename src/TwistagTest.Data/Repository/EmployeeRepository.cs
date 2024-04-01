using TwistagTest.Business.Interfaces;
using TwistagTest.Data.Context;
using TwistagTest.Shared.Models;

namespace TwistagTest.Data.Repository
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(MyDbContext db) : base(db)
        {
        }
    }
}
