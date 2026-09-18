using Microsoft.EntityFrameworkCore;
using MyAPI.Application.Interfaces;
using MyAPI.Core.DTO;
using MyAPI.Core.Entities;
using MyAPI.Infrastructure.Persistency;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAPI.Infrastructure.Repositories
{
    public class EmployeeRepository(AppDbContext context) : IEmployeeRepository
    {
        public async Task<List<EmployeeDto>> GetAllEmployeesAsync()
        {
            return await context.Employees.Select(x => new EmployeeDto
            {
                Id=x.Id,
                City=x.City,
                CreatedAtDate=x.CreatedAtDate,
                DateOfBirth=x.DateOfBirth,
                Email=x.Email,
                Name=x.Name,
                PhoneNumber=x.PhoneNumber,
                Position=x.Position,
            }).ToListAsync();
        }

        public async Task<EmployeeDto?> GetEmployeeByIdAsync(int id)
        {
            return await context.Employees.Select(x => new EmployeeDto
            {
                Id = x.Id,
                City = x.City,
                CreatedAtDate = x.CreatedAtDate,
                DateOfBirth = x.DateOfBirth,
                Email = x.Email,
                Name = x.Name,
                PhoneNumber = x.PhoneNumber,
                Position = x.Position,
            }).FirstOrDefaultAsync(x=>x.Id==id);
        }

        public async Task<string> AddEmployeeAsync(EmployeeDto employee)
        {
            context.Employees.Add(new Employee
            {
                City=employee.City,
                CreatedAtDate=DateTime.Now,
                DateOfBirth=employee.DateOfBirth,
                Email=employee.Email,
                Name=employee.Name,
                PhoneNumber=employee.PhoneNumber,
                Position=employee.Position,
                UpdatedAtDate=employee.UpdatedAtDate
            });

            await context.SaveChangesAsync();

            return "Employee added successfully";
        }

        public async Task<string> UpdateEmployeeAsync(EmployeeDto employee)
        {
            var existUser= await context.Employees.FindAsync(employee.Id);

            existUser.Position=string.IsNullOrWhiteSpace(employee.Position)?existUser.Position:employee.Position;
            existUser.Name=string.IsNullOrWhiteSpace(employee.Name)?existUser.Name:employee.Name;
            existUser.Email=string.IsNullOrWhiteSpace(employee.Email)?existUser.Email:employee.Email;
            existUser.PhoneNumber=string.IsNullOrWhiteSpace(employee.PhoneNumber)?existUser.PhoneNumber:employee.PhoneNumber;
            existUser.City=string.IsNullOrWhiteSpace(employee.City)?existUser.City:employee.City;
            existUser.DateOfBirth=employee.DateOfBirth??existUser.DateOfBirth;
            existUser.UpdatedAtDate=DateTime.Now;
            

            context.Employees.Update(existUser);
            await context.SaveChangesAsync();

            return "Employee Updated Successfully";
        }

        public async Task<string> DeleteEmployeeAsync(int id)
        {
            var employee = await context.Employees.FindAsync(id);
            if (employee != null)
            {
                context.Employees.Remove(employee);
                await context.SaveChangesAsync();
            }

            return "Employee deleted successfully";
        }
    }
}
