using MediatR;
using MyAPI.Application.Interfaces;
using MyAPI.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAPI.Application.Commands.EmployeeCommands
{
    public record AddEmployeesCommand(EmployeeDto dto) : IRequest<string>;

    public class AddEmployeesCommandHandler(IEmployeeRepository repository) : IRequestHandler<AddEmployeesCommand, string>
    {
        public Task<string> Handle(AddEmployeesCommand request, CancellationToken cancellationToken)
        {
            return repository.AddEmployeeAsync(request.dto);
        }
    }

}
