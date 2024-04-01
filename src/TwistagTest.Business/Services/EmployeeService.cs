using TwistagTest.Business.Interfaces;
using TwistagTest.Shared.Models;

namespace TwistagTest.Business.Services;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeService(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public async Task Add(Employee employee)
    {
        await _employeeRepository.Add(employee);
    }

    public async Task Update(Employee employee)
    {
        await _employeeRepository.Update(employee);
    }

    public async Task Delete(Guid id)
    {
        await _employeeRepository.Delete(id);
    }

    public void Dispose()
    {
        _employeeRepository.Dispose();
    }

    public async Task<Employee> Get(Guid id)
    {
        return await _employeeRepository.GetById(id);
    }

    public async Task<IEnumerable<Employee>> GetAll()
    {
        return await _employeeRepository.GetAll();
    }
}
