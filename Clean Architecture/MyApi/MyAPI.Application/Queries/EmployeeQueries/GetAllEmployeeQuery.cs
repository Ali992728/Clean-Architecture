using MediatR;
using MyAPI.Application.Interfaces;
using MyAPI.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAPI.Application.Queries.EmployeeQueries
{
    public record GetAllEmployeeQuery() : IRequest<List<EmployeeDto>>;

    public class GetAllEmployeeQueryHandler(IEmployeeRepository repository) : IRequestHandler<GetAllEmployeeQuery, List<EmployeeDto>>
    {
        public Task<List<EmployeeDto>> Handle(GetAllEmployeeQuery request, CancellationToken cancellationToken)
        {
            return repository.GetAllEmployeesAsync();
        }
    }
}
