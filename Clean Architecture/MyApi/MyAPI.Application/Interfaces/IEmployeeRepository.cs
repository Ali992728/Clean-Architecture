using MyAPI.Core.DTO;
using MyAPI.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAPI.Application.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<List<EmployeeDto>> GetAllEmployeesAsync();
        Task<EmployeeDto?> GetEmployeeByIdAsync(int id);
        Task<string> AddEmployeeAsync(EmployeeDto employee);
        Task<string> UpdateEmployeeAsync(EmployeeDto employee);
        Task<string> DeleteEmployeeAsync(int id);
    }
}
